using Microsoft.EntityFrameworkCore;
using SozlarJadvali.Models.Words;

namespace SozlarJadvali.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Word> Word { get; set; }

        public async ValueTask<Word> InsertWordAsync(Word word) =>
            await InsertAsync(word);

        public IQueryable<Word> SelectAllWords() =>
            SelectAll<Word>();

        public async ValueTask<Word> SelectWordByIdAsync(Guid id) =>
            await SelectAsync<Word>(id);

        public async ValueTask<Word> UpdateWordAsync(Word word) =>
            await UpdateAsync(word);

        public async ValueTask<Word> DeleteWordAsync(Word word) =>
            await DeleteAsync(word);
    }
}