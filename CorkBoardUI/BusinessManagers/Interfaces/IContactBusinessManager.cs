using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorkBoardUI.ViewModels.ContactViewModels;

namespace CorkBoardUI.BusinessManagers.Interfaces
{
    public interface IContactBusinessManager
    {
        public string SendEmail(SendEmailViewModel sendEmailViewModel);
    }
}
