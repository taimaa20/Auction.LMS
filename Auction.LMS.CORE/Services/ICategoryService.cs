using Auction.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Services
{
  public   interface ICategoryService
    {
        List<Category> GetAllCategory();
        bool InsertCategory(Category category);
        bool UpdateCategory(Category category);
        bool DeleteCategory(int id);
        List<Category> SearchByCategoryName(Category category);
    }
}
