using Project.ENTITIES.Models;
using Project.MAP.Options;
using System.Data.Entity;


namespace Project.DAL.ContextClasses
{
    //DAL katmanımız görevi veritabanı ile iletişimi sağlamaktır. EntityFramework indirmek zorunludur. (Referanslara baktığınızda hata alıyorsanız Build etmenizi tavsiye ediyoruz.)

    //ÖNEMLİ: Bu katmanda, UI katmanından referans aldığınız takdirde büyük bir güvenlik risk'i ile karşı karşıya kalabilirsiniz! 

    public class MyContext : DbContext
    {//MyContext'e DbContext'den miras vererek, ona bir veritabanı sınıfı olduğunu bildirmiş oluyoruz.
        public MyContext() : base("MyConnection")
        { //*BAŞLANGIÇ* projesinin AppConfig eylemleri içerisinden veritabanı özelliklerimizi alıp gerçekleştirecek olan Constructor'dır.

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Map katmanından veritabanı ayarlamalarımızı alıyoruz. (Aşağıdaki işlemleri yapabilmeniz için Map ve Entities katmanlarının referansı Dal katmanında da olmalıdır.)

            //Bu işlemleri gerçekleştirebilmek için Map ve Entities katmanlarının işlemlerinin bitmiş olması gerekmektedir.
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new AppUserProfileMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new BookingMap());
            modelBuilder.Configurations.Add(new HouseKeepingMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new RoomBookingMap());
            modelBuilder.Configurations.Add(new RoomMap());
            modelBuilder.Configurations.Add(new RoomTypeMap());

        }
        //Tablo olabilmeleri için DbSetlerimizi tanımlıyoruz.
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> AppUserProfiles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<HouseKeeping> HouseKeepings { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomBooking> RoomBookings { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }

    }
    //Sıradaki işlem migration işlemi olacaktır ve DAL katmanı ile olan işlemlerimiz sonlanacaktır.
}
