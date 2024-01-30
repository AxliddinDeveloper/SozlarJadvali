using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using SozlarJadvali.Brokers.Storages;
using SozlarJadvali.Brokers.TokenBroker;
using SozlarJadvali.Services.Admins;
using SozlarJadvali.Services.Tokens;
using SozlarJadvali.Services.Users;
using SozlarJadvali.Services.Words;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = "Standart Authorization header using the Bearer scheme (\"bearer {token}\")",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    options.OperationFilter<SecurityRequirementsOperationFilter>();
});

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("Jwt:Key").Value)),
            ValidateIssuer = false,
            ValidateAudience = false
        });

builder.Services.AddAuthorization();
builder.Services.AddDbContext<StorageBroker>();
AddBrokers(builder);
AddServices(builder);

static void AddBrokers(WebApplicationBuilder builder)
{
    builder.Services.AddTransient<IStorageBroker, StorageBroker>();
    builder.Services.AddTransient<ITokeBroker, TokenBroker>();
}

static void AddServices(WebApplicationBuilder builder)
{
    builder.Services.AddTransient<IAdminService, AdminService>();
    builder.Services.AddTransient<IUserService, UserService>();
    builder.Services.AddTransient<IWordService, WordService>();
    builder.Services.AddTransient<ITokenService, TokenService>();
}

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();
app.UseHttpsRedirection();
app.MapControllers();
app.UseStaticFiles();

app.Run();