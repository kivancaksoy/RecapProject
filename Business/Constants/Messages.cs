using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarsListed = "Arabalar listelendi.";
        public static string CarListed = "Araba listelendi.";
        public static string CarsDetailsListed = "Arabaların detayları listelendi.";

        public static string CarNameInvalid = "Araba adı en az iki karakterden oluşmalıdır.";
        public static string CarDailyPriceInvalid = "Araba günlük ücreti sıfırdan büyük olmalıdır.";
 
        public static string BrandAdded = "Araba markası eklendi.";
        public static string BrandDeleted = "Araba markası silindi.";
        public static string BrandUpdated = "Araba markası güncellendi.";
        public static string BrandsListed = "Araba markaları listelendi.";
        public static string BrandListed = "Araba markası listelendi.";

        public static string ColorAdded = "Araba rengi eklendi.";
        public static string ColorDeleted = "Araba rengi silindi.";
        public static string ColorUpdated = "Araba rengi güncellendi.";
        public static string ColorsListed = "Araba renkleri listelendi.";
        public static string ColorListed = "Araba rengi listelendi.";

        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomersListed = "Müşteriler listelendi.";
        public static string CustomerListed = "Müşteri listelendi.";

        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UsersListed = "Kullanıcılar listelendi.";
        public static string UserListed = "Kullanıcı listelendi.";

        public static string RentalAdded = "Araba kiralandı.";
        public static string RentalDeleted = "Kiralama kaydı silindi.";
        public static string RentalUpdated = "Kiralama kaydı güncellendi.";
        public static string RentalsListed = "Kiralama kayıtları listelendi.";
        public static string RentalListed = "Kiralama kaydı listelendi.";

        public static string ReturnDateIsNull = "Araba teslim edilmemiş, kiralanamaz!";
    }
}
