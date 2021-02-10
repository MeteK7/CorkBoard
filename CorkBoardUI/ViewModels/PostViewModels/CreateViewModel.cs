using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CorkBoardDAL.Entities;

namespace CorkBoardUI.ViewModels.PostViewModels
{
    public class CreateViewModel
    {
        [Display(Name = "Left Side Image")]
        public IFormFile LeftSideImage { get; set; }

        [Required, Display(Name = "Header Image")]
        public IFormFile HeaderImage { get; set; }

        public Post Post { get; set; }
    }
}
