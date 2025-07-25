using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.DTOs.Users;
using Entities.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        List<UserListViewModel> GetUserList();
        UserDetailsViewModel? GetById(int userId);
    }
}
