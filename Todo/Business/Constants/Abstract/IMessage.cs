using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Abstract
{
    public interface IMessage
    {
        string UserAdded { get; }
        string UserUpdated { get; }
        string UserNotAdded { get; }
        string UserNotFound { get; }
        string UsernameOrPasswordError { get; }
        string UsernameAlreadyExist { get; }
        string UserEmailAlreadyExist { get; }
        string UserPhoneAlreadyExist { get; }
        string TodoAdded { get; }
        string TodoNotAdded { get; }
        string TodoUpdated { get; }
        string TodoNotUpdated { get; }
        string TodoDeleted { get; }
        string TodoNotDeleted { get; }
        string TodoNotFound { get; }
        string ProductBarcodeNoAlreadyExist { get; }
        string ProductAdded { get; }
        string CategoryNotFound { get; } // Kategori Bulunamadı
        string CategoryAdded { get; }
        string CategoryDeleted { get; }
        string CategoryNotAdded { get; }
        string CategoryUpdated { get; }
        string CategoryNotUpdated { get; }
        string CategoryNameAlreadyExist {  get; }
        string RoleNameAlreadyExist { get; }
        string UserExistForRole { get; }
        string RoleNotFound { get; }
        string RoleAdded { get; }
        string RoleNotAdded { get; }
        string RoleDeleted { get; }
        string RoleNotDeleted { get; }
        string UserPasswordUpdated { get; }
        string UserPasswordNotUpdated { get; }
        string UserOldPasswordFalse { get; }
        string ProductNotAdded { get; }
        string ProductExistForCategory { get; }
    }

}
