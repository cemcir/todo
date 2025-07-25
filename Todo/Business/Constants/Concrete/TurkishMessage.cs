using Business.Constants.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Concrete
{
    public class TurkishMessage : IMessage
    {
        public TurkishMessage() {

            this.UsernameOrPasswordError = "Kullanıcı Adı veya Şifre Hatalı";

            this.UserAdded = "Kullanıcı Başarıyla Eklendi";

            this.UserUpdated = "Kullanıcı Başarıyla Güncellendi";

            this.UserNotAdded = "Kullanıcı Eklenirken Hata Oluştu";

            this.UserNotFound = "Kullanıcı Kaydı Bulunamadı";

            this.UsernameAlreadyExist = "Kullanıcı Adı Zaten Kayıtlı";

            this.UserEmailAlreadyExist = "Eposta Hesabına Kayıtlı Kullanıcı Zaten Mevcut";

            this.UserPhoneAlreadyExist = "Telefon Numarasına Kayıtlı Kullanıcı Zaten Mevcut";

            this.ProductBarcodeNoAlreadyExist = "Ürün Barkod Numarası Zaten Kayıtlı";

            this.ProductAdded = "Ürün Başarıyla Kaydedildi";

            this.PaymentRecordForCustomer = "Müşteriye Ait Tahsilat Kaydı Mevcut";

            this.SalesRecordForCustomer = "Müşteriye Ait Satış Kaydı Mevcut";

            this.ProductExistForCategory = "Kategoriye Ait Ürün Kaydı Mevcut";

            this.CategoryNotFound = "Kategori Kaydı Bulunamadı";

            this.CategoryAdded = "Kategori Başarıyle Eklendi";

            this.CategoryNotAdded = "Kategori Eklenirken Hata Oluştu";

            this.CategoryUpdated = "Kategori Başarıyla Güncellendi";

            this.CompanyAdded = "Firma Başarıyla Eklendi";

            this.CompanyNotAdded = "Firma Eklenirken Hata Oluştu";

            this.CompanyNotFound = "Firma Kaydı Bulunamadı";

            this.CompanyDeleted = "Firma Başarıyla Silindi";

            this.CompanyUpdated = "Firma Başarıyla Güncelledi";

            this.CategoryNameAlreadyExist = "Kategori Adı Zaten Kayıtlı";

            this.PaymentCustomerForSales = "İşlemi Gerçekleştirebilmeniz İçin Satışa Ait Tüm Ürünlerin Ürün İadesini Yapmanız Gerekmektedir";

            this.PaymentCustomerDeleted = "Cari Tahsilat Kaydı Başarıyla Silindi";

            this.PaymentCustomerNotDeleted = "Cari Tahsilat Kaydı Silinirken Hata Oluştu";

            this.CompanyNameAlreadyExist = "Firma Adı Zaten Kayıtlı";

            this.PaymentExistForCompany = "Firmaya Ait Borç veya Ödeme Kaydı Mevcut";

            this.WareHouseNameAlreadyExist = "Depo Zaten Kayıtlı";

            this.ProductExistForWareHouse = "Depoaya Ait Ürün Kaydı Mevcut";

            this.RoleNameAlreadyExist = "Rol Adı Zaten Kayıtlı";

            this.UserExistForRole = "Role Ait Kullanıcı Kaydı Mevcut";

            this.RoleNotFound = "Rol Kaydı Bulunamadı";
            
            this.RoleAdded = "Rol Kaydı Başarıyla Tamamlandı";

            this.RoleNotAdded = "Rol Kaydı Esnasında Hata Oluştu";
            
            this.RoleDeleted = "Rol Kaydı Başarıyla Silindi";

            this.RoleNotDeleted = "Rol Kaydı Silinirken Hata Oluştu";

            this.ProductStockIncremented = "Ürün Depoya Başarıyla Aktarıldı";

            this.ProductStockNotIncremented = "Ürün Depoya Aktarılırken Hata Oluştu";

            this.ProductStockDecremented = "Depodan Stoğa Ürün Başarıyla Aktarıldı";

            this.ProductStockNotDecremented = "Depodan Stoğa Ürün Aktarılırken Hata Oluştu";

            this.CategoryDeleted = "Kategori Kaydı Başarıyla Silindi";
           
            this.UserPasswordUpdated = "Kullanıcı Şifresi Başarıyla Güncellendi";

            this.UserPasswordNotUpdated = "Kullanıcı Şifresi Güncellenirken Hata Oluştu";

            this.UserOldPasswordFalse = "Kullanıcı Eski Şifresi Hatalı";

            this.ProductNotAdded = "Ürün Eklenirken Hata Oluştu";

            this.ExternalIncomeAdded = "Gelir Kaydı Başarıyla Tamamlandı";
            
            this.ExternalIncomeNotAdded = "Gelir Kaydı Esnasında Hata Oluştu";
            
            this.TodoAdded = "Yapalıcak Görev Başarıyla Kaydedildi";

            this.TodoNotAdded = "Yapılacak Görev Eklenirken Hata Oluştu";

            this.TodoUpdated = "Yapılacak Görev Başarıyla Güncellendi";

            this.TodoNotUpdated = "Yapılacak İşler Güncellenirken Hata Oluştu";

            this.TodoDeleted = "Yapılacak İşler Başarıyla Silindi";
            
            this.TodoNotDeleted = "Yapılacak İşler Silinirken Hata Oluştu";

            this.TodoNotFound = "Yapılacak İş Kaydı Bulunamadı";
        }

        public string UserAdded { get; }

        public string UserUpdated { get; }

        public string UserNotAdded { get; }

        public string UserNotFound { get; }

        public string CustomerAdded { get; }

        public string CustomerNotAdded { get; }

        public string CustomerUpdated { get; }

        public string CustomerNotUpdated { get; }

        public string CustomerDeleted { get; }

        public string CustomerNotDeleted { get; }

        public string CustomerNotFound { get; }

        public string PaymentCustomerAdded { get; }

        public string PaymentCustomerNotAdded { get; }

        public string PaymentCustomerNotFound { get; }

        public string CustomerPhoneAlreadyExist { get; }

        public string UsernameOrPasswordError { get; }

        public string UsernameAlreadyExist { get; }

        public string UserEmailAlreadyExist { get; }

        public string UserPhoneAlreadyExist { get; }

        public string ProductBarcodeNoAlreadyExist { get; }

        public string ProductAdded { get; }

        public string PaymentRecordForCustomer { get; }

        public string SalesRecordForCustomer { get; }

        public string ProductExistForCategory { get; }

        public string CategoryNotFound { get; }

        public string CategoryNameAlreadyExist { get; }

        public string CategoryAdded { get; }
        public string CategoryNotAdded { get; }

        public string CategoryUpdated { get; }

        public string CategoryNotUpdated { get; }

        public string PaymentCustomerForSales { get; }

        public string PaymentCustomerDeleted { get; }

        public string PaymentCustomerNotDeleted { get; }

        public string CompanyNameAlreadyExist { get; }

        public string CompanyAdded { get; }

        public string CompanyDeleted { get; }

        public string CompanyNotAdded { get; }

        public string CompanyNotDeleted { get; }

        public string CompanyNotFound { get; }

        public string CompanyUpdated { get; }

        public string CompanyNotUpdated { get; }

        public string PaymentExistForCompany { get; }

        public string WareHouseNameAlreadyExist { get; }

        public string ProductExistForWareHouse { get; }

        public string WareHouseAdded { get; }

        public string WareHouseNotAdded { get; }

        public string WareHouseNotFound { get; }

        public string WareHouseDeleted { get; }

        public string WareHouseNotDeleted { get; }

        public string WareHouseUpdated { get; }

        public string WareHouseNotUpdated { get; }

        public string RoleNameAlreadyExist { get; }

        public string UserExistForRole { get; }

        public string RoleNotFound { get; }

        public string RoleAdded { get;}

        public string RoleNotAdded { get; }

        public string RoleDeleted { get; }

        public string RoleNotDeleted { get; }

        public string ReturnProductAdded { get; }

        public string SalesDetailNotFound { get; }

        public string SalesNotFound { get; }

        public string ProductStockIncremented { get; }

        public string ProductStockNotIncremented { get; }

        public string ProductStockDecremented { get; }

        public string ProductStockNotDecremented { get; }

        public string CategoryDeleted {  get; }

        public string UserPasswordUpdated { get; }

        public string UserPasswordNotUpdated { get; }

        public string UserOldPasswordFalse {  get; }

        public string ProductNotAdded { get; }

        public string ExternalIncomeAdded { get; }

        public string ExternalIncomeNotAdded { get; }

        public string TodoAdded { get; }

        public string TodoNotAdded { get; }
        public string TodoUpdated { get;}

        public string TodoNotUpdated { get;}

        public string TodoDeleted { get; }

        public string TodoNotDeleted { get; }

        public string TodoNotFound { get; }
    }
}
