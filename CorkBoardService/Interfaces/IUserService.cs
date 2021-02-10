using CorkBoardDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorkBoardService.Interfaces
{
    public interface IUserService
    {
        ApplicationUser Get(string id);
        Task<ApplicationUser> Update(ApplicationUser applicationUser);
    }
}
