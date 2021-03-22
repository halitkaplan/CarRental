using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç Listeye Eklendi.";
        public static string CarNameInvalid = "Araç Adı Minimum 2 Karakter Olmalıdır ve Günlük fiyatı 0 dan büyük olmalıdır.";
        public static string CarDeleted = "Araç Silindi";
        public static string CarUpdated = "Araç Güncellendi";

        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marka Güncellendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk Güncellendi";

        public static string MaintenanceTime = "Sistem bakımda.";

        public static string CustomerAdded = "Müşteri Eklendi.";
        public static string CustomerDeleted = "Müşteri Silindi.";
        public static string CustomerUpdated = "Müşteri Güncellendi.";

        public static string UserAdded = "Kullanıcı Eklendi.";
        public static string UserDeleted = "Kullanıcı Silindi.";
        public static string UserUpdated = "Kullanıcı bilgileri güncellendi.";

        public static string AddedRental = "Araç Kiralandı.";
        public static string DeletedRental = "Kiralık Araç Güncellendi.";
        public static string UpdatedRental = "Kiralık Araç Silindi.";

        public static string Rentable = "Araç Kiralanabilir.";
        public static string CannotBeRented = "Araç Kiralanamaz.";


    }
}
