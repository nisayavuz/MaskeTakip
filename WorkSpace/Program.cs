using Business.Concrete;
using Entities.Concrete;

namespace WorkSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SelamVer(isim: "Nisa"); //parametre çağırma
            SelamVer(isim: "Nursena");
            SelamVer(isim: "Enes");
            SelamVer();
            int sonuc = Topla();



            //Diziler /Arrays
            string ogrenci1 = "Nisa";
            string ogrenci2 = "Nursena";
            string ogrenci3 = "Enes";

            //zor yöntem
            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);



            string[] ogrenciler = new string[3]; 
            ogrenciler[0] = "Nisa";
            ogrenciler[1] = "Nursena";
            ogrenciler[2] = "Enes";
            //ogrenciler[3] = "Ali"; 
            ogrenciler = new string[4];
            ogrenciler[3] = "Ahmet";



            for (int i = 0; i < ogrenciler.Length; i++)
            {
                // Console.WriteLine(ogrenciler[i]);
            }


            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);


            Person person1 = new Person();
            person1.FirstName = "Nur";
            person1.LastName = "Yavuz";
            person1.DateOfBirthYear = 1996;
            person1.NationalIdentity = 11057046408;


            Person person2 = new Person();
            person2.FirstName = "Nisa";


            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            //generic collection 
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1"); 
            {
                Console.WriteLine(sehir);
            }



            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SelamVer(string isim = "noname")
        {
            Console.WriteLine("Merhaba " + isim);
        }
        static int Topla(int sayi1 = 12, int sayi2 = 13)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc.ToString());
            return sonuc;
        }
    }

}
