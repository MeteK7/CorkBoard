using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorkBoardDAL.Entities;

namespace CorkBoardUI.ViewModels.AdminViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
    }
}
