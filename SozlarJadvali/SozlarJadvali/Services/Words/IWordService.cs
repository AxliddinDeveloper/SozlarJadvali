using SozlarJadvali.Models.Words;

namespace SozlarJadvali.Services.Words
{
    public interface IWordService
    {
        ValueTask<Word> AddWordAsync(Word word);
        IQueryable<Word> RetrieveAllWords();
        ValueTask<Word> RetrieveWordByIdAsync(Guid id);
        ValueTask<Word> ModifyWordAsync(Word word);
        ValueTask<Word> RemoveWordAsync(Word word);
    }
}
