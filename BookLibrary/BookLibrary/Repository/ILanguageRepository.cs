using BookLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public interface ILanguageRepository
    {
        Task<List<LanguageModel>> GetLanguages();
    }
}