using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Ekleme İşleme Başarılı";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";        
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Kategori ürün sayısı limitini aştınız. Maksimum 10 olabilir.";
        public static string ProductNameAlreadyExists = "Aynı isimden bir ürün daha var.";
        public static string CategoryLimitExceded = "Kategori sayısı aşıldı. Dolasıyla ürün eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz Yok!";
    }
}
