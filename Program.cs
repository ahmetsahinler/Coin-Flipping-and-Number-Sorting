using System;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            siralama();
        }
        

        public static void siralama()
        {
            // int gecici=0;
            // int tasiyici=0;
            // Console.Write("Kaç adet sayı gireceksiniz: ");
            // int uzunluk = Convert.ToInt32(Console.ReadLine());
            
            // for (int i = 0; i < uzunluk; i++)
            // {
            //     Console.Write("Lütfen sayıları giriniz: ");
            //     int sayi = Convert.ToInt32(Console.ReadLine());
            //     if (sayi>tasiyici)
            //     {
            //         gecici = sayi;
            //         sayi = tasiyici;
            //         tasiyici = gecici;
            //     }
            //     else 
            //     {
            //         continue;
            //     }
            // }
            // Console.WriteLine("En büyük sayı: "+tasiyici);
            
            
            
            
            Console.Write("Sayılar: ");
            int[] sayilar = {5,6,7,5,3,8,0,33,4,6,888};
            for (int i = 0; i < sayilar.Length; i++)
            {
                //sayilar[i] = random.Next(-100, 100);
                
                Console.Write("[{"+sayilar[i]+"}]");
            }
  
            Console.WriteLine();
            int tasiyici;
            Console.Write("Sıralı Hali: ");
            for (int i = 0; i < sayilar.Length; i++)
            {
                for (int j = i+1; j < sayilar.Length; j++)
                {

                    if (sayilar[i] > sayilar[j])
                    {

                        tasiyici = sayilar[j];
                        sayilar[j] = sayilar[i];
                        sayilar[i]=tasiyici;

                    }
                }
                
                Console.Write("[{"+sayilar[i]+"}]");

            }
        }


        


    }
}




// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Ahmet
// {
//     internal class Program2
//     {
//         static void YaziTura()
//         {
//             //Random random = new Random();
//             //bool sonuc = Convert.ToBoolean(random.Next(2));

//             //switch (sonuc)
//             //{
//             // case true:
//             // Console.WriteLine("TURA");
//             // break;
//             // case false:
//             // Console.WriteLine("YAZI");
//             // break ;

//             // default:
//             // break;
//             //}

//             Random random = new Random();
//             int sonuc = random.Next(0,3);

//             switch (sonuc)
//             {
//                 case 1:
//                 Console.WriteLine("TURA");
//                 break;

//                 case 2:
//                 Console.WriteLine("YAZI");
//                 break;

//                 default:
//                 break;
//             }

//         }
//         static void Main(string[] args)
//         {
//             YaziTura();
//             Console.ReadLine();
//         }
//     }
// }