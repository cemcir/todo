using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.DTOs.Users;
using Entities.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ProjectContext>, IUserDal
    {
        public EfUserDal(ProjectContext context) : base(context) { }

        public UserDetailsViewModel? GetById(int userId)
        {
            return _context.Users.Select(u => new UserDetailsViewModel { 
                                              UserId=u.UserId,
                                              Name=u.Name,
                                              Email=u.Email
                                        }).Where(u => u.UserId == userId).FirstOrDefault();
        }

        public List<UserListViewModel> GetUserList()
        {
            return _context.Users.Select(u=>new UserListViewModel {
                                            UserId =u.UserId,
                                            Name = u.Name,
                                            Email = u.Email
                                        }).ToList();
        }
        /*
public User? GetUser(string username,string passwordHash)
{

   return _context.Users.SingleOrDefault(u => u.UserName == username && u.PasswordHash == passwordHash);

}

public List<UserListDto> GetUserList(int userId)
{

   return _context.Users.Where(u => u.UserId != userId).
                           Select(u => new UserListDto {
                           UserId=u.UserId,
                           Username=u.UserName,
                           Email=u.Email,
                           Phone=u.Phone,
                           IsActive=u.IsActive,
                           Image=u.Image
                           }).OrderByDescending(u=>u.UserId).
                           ToList();

} 

public UserDto? UserDetails(int userId)
{

   return _context.Users.Where(u => u.UserId == userId).
                           Select(u=>new UserDto {
                           UserId=u.UserId,
                           Email=u.Email,
                           Phone=u.Phone,
                           Image=u.Image
                           }).SingleOrDefault();


}
*/
    }
}
