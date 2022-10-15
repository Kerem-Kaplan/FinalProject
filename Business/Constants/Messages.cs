using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi!";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductListed = "Ürünler Lietelendi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olur";
        public static string ProductNameAlredyExists="Bu isimde zaten başka ürün var";
        public static string CategoryLimitExceded="Kategori limiti aşıldı!!!";
        public static string AuthorizationDenied="Yetkiniz yok!";
        public static string UserRegistered="Kullanıcı kayıt edildi!";
        public static string UserNotFound="Kullanıcı bulunamadı!";
        public static string PasswordError="Hatalı şifre!";
        public static string SuccessfulLogin="Giriş başarılı!";
        public static string UserAlreadyExists="";
        public static string AccessTokenCreated="";
    }
}
