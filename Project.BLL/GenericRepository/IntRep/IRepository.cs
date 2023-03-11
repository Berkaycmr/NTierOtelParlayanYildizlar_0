using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Project.BLL.GenericRepository.IntRep
{
    public interface IRepository<T> where T : BaseEntity
    {
        // List Commands - Liste Komutları - List emirleri yani loglama emirleri. Bu metotlar geriye değer döndüren metotlar. Metotlar çağırdığımız zaman bize hep bi T listesi döndürecek.

        List<T> GetAll(); // Bu metot ilgili T neyse o yapıdaki tüm verileri getirecek.
        List<T> GetActives(); // Bu metot sadece Aktif kullanımda olan verileri getirecek.
        List<T> GetPassives(); // Bu metot sadece Pasif olan verileri getirecek.
        List<T> GetModifieds(); // Bu metot sadece  güncellenmiş olan verileri getirecek.


        // Modification Commands - Değişiklik Komutları - Veritabanında bir değişikliğe neden olacak yapılar. Geriye değer döndürmelerine gerek yok sadece değişiklik yapacaklar ve bitecek.
        void Add(T item); // Geriye değer döndürmeyen bir ekleme metotu, içerisine T ne ise onu alacak.
        void AddRange(List<T> list); // Toplu halde ekleme yapan bir metot. List alacak parametreyi. T listesi ne ise hepsini birlikte ekleyecek.
        void Update(T item); // Bu metot, veri öğesinin güncelleştirilmesi gerektiği durumlarda kullanılır.
        void UpdateRange(List<T> list); // liste halinde bir güncelleme yapacak.
        void Delete(T item); // Bu metotun amacı veriyi pasifize etmek. Yok etmek değil.
        void DeleteRange(List<T> list); // Bu metot, koleksiyondaki tüm öğeleri veritabanından siler.
        void Destroy(T item); // Bu metot, veritabanından bir veri öğesini siler.
        void DestroyRange(List<T> list); // Bu metot, koleksiyondaki tüm öğeleri veritabanından siler.



        // Linq Expression - Linq İfadesi - Sql mantığı ile sorgu yaratmak.
        List<T> Where(Expression<Func<T, bool>> exp); // T tipindeki nesnelerin bir koleksiyonundan, belirli bir koşulu karşılayan T nesnelerinin listesini döndürmek için kullanılır.
        bool Any(Expression<Func<T, bool>> exp); // T tipindeki nesnelerin bir koleksiyonunda belirli bir koşulu sağlayan en az bir T nesnesi olup olmadığını kontrol etmek için kullanılır.
        T FirstOrDefault(Expression<Func<T, bool>> exp); // T tipindeki nesnelerin bir koleksiyonunda belirli bir koşulu sağlayan ilk T nesnesini döndürür.
        IQueryable<X> Select<X>(Expression<Func<T, X>> exp); // T tipindeki nesnelerin bir koleksiyonundan,  belirtilen bir ifadeye(expression)  göre bir projeksiyon(projection) oluşturur ve sonucunda X tipindeki nesnelerin bir koleksiyonunu döndürür.


        // Find 

        T Find(int id); // Belirli bir ID'ye sahip olan T tipindeki bir nesneyi veritabanından bulup döndürür.

        // Get Last Datas

        List<T> GetLastDatas(int number); // Belirtilen sayıda en son verileri döndürür.

        // Get First Datas

        List<T> GetFirstDatas(int number);  // Belirtilen sayıda ilk verileri döndürür.

        // GetCounted Datas
        List<T> GetCountedDatas(int number); // Belirtilen sayıda veri döndürür.



    }


}
