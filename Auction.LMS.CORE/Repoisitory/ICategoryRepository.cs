using Auction.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Repoisitory
{
   public interface ICategoryRepository
    {
        List<Category> GetAllCategory();
        bool InsertCategory(Category category);
        bool UpdateCategory(Category category);
        bool DeleteCategory(int id);
        List<Category> SearchByCategoryName(Category category);
        public Category GetAllCategoryId(int id);
    }
}
