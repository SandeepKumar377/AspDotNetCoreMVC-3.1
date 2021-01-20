using BookLibrary.Data;
using BookLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public class LanguageRepository
    {
        private readonly BookLibraryContext _context = null;

        public LanguageRepository(BookLibraryContext context)
        {
            _context = context;
        }

        public async Task<List<LanguageModel>> GetLanguages()
        {
            return await _context.Language.Select(x => new LanguageModel()
            {
                Id=x.Id,
                Description=x.Description,
                Name=x.Name
            }).ToListAsync();
        }
    }
}
