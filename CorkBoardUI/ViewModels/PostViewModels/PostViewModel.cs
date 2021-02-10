using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorkBoardDAL.Entities;

namespace CorkBoardUI.ViewModels.PostViewModels
{
    public class PostViewModel
    {
        public Post Post { get; set; }
        public Comment Comment { get; set; }
    }
}
