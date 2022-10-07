using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
        internal static string CategoryLimitExceded="Kategori limiti aşıldı!!!";
    }
}
