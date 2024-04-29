using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories
{
    public interface ICategoryRepository
    {
        public List<Category> FindAll();
        public Category CreateOne(Category category);
        public Category FindOne(Category newcategory);
        public Category DeleteOne(Category Deletecategory);

        public Category UpdateOne(Category Updatecategory);

    }
}