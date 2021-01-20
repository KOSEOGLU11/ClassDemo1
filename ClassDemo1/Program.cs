using System;

namespace ClassDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.İsim = "Merve";
            musteri1.MüsteriNo = 111111;
            musteri1.ID = 1000000;

            Musteri musteri2 = new Musteri();

            musteri2.İsim = "Engin";
            musteri2.MüsteriNo = 222222;
            musteri2.ID = 20000000;

           
            Musteri[] musteriler= new Musteri[] { musteri1 ,musteri2};
           

          
            foreach (Musteri item in musteriler)
            {
                
                Console.WriteLine("Müsteri numarası: "+item.MüsteriNo);
                Console.WriteLine("Müsteri ismi: "+item.İsim);
                Console.WriteLine("Müsteri ID: "+item.ID);
                Console.WriteLine("************************");
            }



              MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);



        }



    }
}
