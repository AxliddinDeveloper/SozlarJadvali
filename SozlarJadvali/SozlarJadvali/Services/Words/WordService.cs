using SozlarJadvali.Brokers.Storages;
using SozlarJadvali.Models.Words;

namespace SozlarJadvali.Services.Words
{
    public class WordService : IWordService
    {
        private readonly IStorageBroker storageBroker;

        public WordService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public async ValueTask<Word> AddWordAsync(Word word)
        {
            word.Id = Guid.NewGuid();

            Word word2= new Word
            {
                Id = word.Id,
                YordamchiSoz = word.YordamchiSoz.ToLower(),
                Turkumi = word.Turkumi.ToLower(),
                XalqaroTegi = word.XalqaroTegi.ToLower(),
                OzbekchaTegi = word.OzbekchaTegi.ToLower(),
                SofvazifaDosh = word.SofvazifaDosh.ToLower(),
                Shakli = word.Shakli.ToLower(),
                ManoTuri = word.ManoTuri.ToLower(),
                UslubiyXoslanishi = word.UslubiyXoslanishi.ToLower(),
                SofTurkumi = word.SofTurkumi.ToLower(),
                YordamchiSozVaOlinganManba = word.YordamchiSozVaOlinganManba
            };
            
            return await this.storageBroker.InsertWordAsync(word2);
        }

        public async ValueTask<Word> ModifyWordAsync(Word word) =>
            await this.storageBroker.UpdateWordAsync(word);

        public async ValueTask<Word> RemoveWordAsync(Word word) =>
            await this.storageBroker.DeleteWordAsync(word);

        public IQueryable<Word> RetrieveAllWords() =>
            this.storageBroker.SelectAllWords();

        public async ValueTask<Word> RetrieveWordByIdAsync(Guid id) =>
            await this.storageBroker.SelectWordByIdAsync(id);
    }
}