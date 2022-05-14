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

        public static string CarNameInvalid = "Araba adı en az iki karakterden oluşmalıdır.";
        public static string CarDailyPriceInvalid = "Araba günlük ücreti sıfırdan büyük olmalıdır.";

        public static string ReturnDateIsNull = "Araba teslim edilmemiş, kiralanamaz!";
        public static string ReturnDateIsNotNull = "Araba kiralandı.";
    }
}
