using System;
using System.Collections.Generic;
using Demo.Core.Data;

namespace Demo.Core.Repositories.Interfaces
{
    public class CategoriesRepository : Repository<Category>, ICategoriesRepository
    {
        public CategoriesRepository(NORTHWNDContext context) : base(context)
        {
        }

        public IEnumerable<Category> GetOtherDefinedCategories()
        {
            throw new NotImplementedException();
        }
    }
}