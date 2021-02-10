using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorkBoardDAL.Entities;

namespace CorkBoardUI.ViewModels.HomeViewModels
{
    public class AuthorViewModel
    {
        public ApplicationUser Author { get; set; }
        public IPagedList<Post> Posts { get; set; }
        public string SearchString { get; set; }
        public int PageNumber { get; set; }
    }
}
