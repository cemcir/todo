using AutoMapper;
using Business.Abstract;
using Business.Constants.Abstract;
using Business.ValidationRules.FluentValidation.User;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Business;
using Core.Utilities.FileOperation;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using Entities.DTOs.Users;
using Entities.ViewModels.Users;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore.Storage.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserDal _userDal;
        private IMessage _message;
        private IMapper _mapper;

        public AuthManager(IUserDal userDal,IMapper mapper,IMessage message)
        {
            _userDal = userDal;
            _message = message;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(UserAddDto userAddDto)
        {
            try { 
                var resullt = BusinessRules.Run(this.CheckIfUserEmailAlreadyExist(userAddDto.Email));

                if (!resullt.Success) {
                    return resullt;
                }

                User user = _mapper.Map<User>(userAddDto);

                user.PasswordHash=HashingHelper.HashPasswordWithSHA256(userAddDto.Password); // gönderilen şifreyi heşler
                _userDal.Add(user);
                
                return new SuccessResult(_message.UserAdded);
            }
            catch (Exception e) { 
                return new ErrorResult(e.Message);
            }
        }

        public IDataResult<string> Login(UserForLoginDto userForLoginDto)
        {
            string passwordHash = HashingHelper.HashPasswordWithSHA256(userForLoginDto.Password);  // gönderilen şifreyi SHA256 algoritmasıyla heşler
            User? user = _userDal.Get(u=>u.Email==userForLoginDto.Email && u.PasswordHash==passwordHash); // kullanıcı aktif mi kontrol et
            if (user != null) 
            {    
                string token = TokenService.GenerateToken(user.UserId); // rol bazlı jwt üret
                _userDal.Update(user); 

                return new SuccessDataResult<string>(token,""); // üretilen jwt yi dön
            }
            return new ErrorDataResult<string>(_message.UsernameOrPasswordError);
        }
        
        // buradaki kod mantığında resim gönderilmediyse null varsa gönderilen ifadesi
        public IResult Update(UserUpdateDto userUpdateDto)
        {
            try {
                User? user = _userDal.Get(u=>u.UserId==userUpdateDto.UserId);
                if (user != null) {
                    _mapper.Map(userUpdateDto,user);
                    _userDal.Update(user);
                    return new SuccessResult(_message.UserUpdated);
                }
                return new ErrorResult(_message.UserNotFound);
            }
            catch (Exception) {
                return new ErrorResult();
            }
        }

        private IResult CheckIfUserEmailAlreadyExist(string email,int userId=0) // Eposta Adresi Mevcut mu Kontrol Et
        {
            User? user = _userDal.Get(u => u.Email == email && u.UserId!=userId);
            if (user != null)
            {
                return new ErrorResult(_message.UserEmailAlreadyExist);
            }
            return new SuccessResult();
        }

        public IDataResult<List<UserListViewModel>> GetUserList()
        {
            return new SuccessDataResult<List<UserListViewModel>>(_userDal.GetUserList());
        }

        public IDataResult<UserDetailsViewModel> GetById(int userId)
        {
            UserDetailsViewModel? userDetails = _userDal.GetById(userId);
            if (userDetails != null)
            {
                return new SuccessDataResult<UserDetailsViewModel>(userDetails);
            }
            return new ErrorDataResult<UserDetailsViewModel>(userDetails);
        }

    }
}
