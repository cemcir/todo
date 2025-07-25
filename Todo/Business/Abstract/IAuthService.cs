using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs.Users;
using Entities.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<string> Login(UserForLoginDto userForLoginDto); // geriye token döner
        IResult Add(UserAddDto userAddDto);
        IResult Update(UserUpdateDto userUpdateDto);
        IDataResult<List<UserListViewModel>> GetUserList();
        IDataResult<UserDetailsViewModel> GetById(int userId);
    }
}
