using System.Collections.Concurrent;

namespace SaheninHesablanmasi
{
    internal class Program
    {
        static void Main(string[] args)

        {

            string menu = "1.Sahənin hesablanması \n" +
                "2.Perimetr hesablanması\n" +
                "3.Çıxış";
            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine(menu);
                Console.WriteLine("Operation daxil esdin");
                int operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Menu1();
                        break;
                    case 2:
                        Menu2();
                        break;
                    case 3:                       
                        isContinue = !Eminsenmi(); 
                        break;
                    default:
                        Console.WriteLine("Duzgun secim edin");
                        break;
                }
            }  
         }

        public static void Menu1()
        {
            string Menu = "1.Kvadrat\n" +
                  "2.Düzbucaqlı\n" +
                  "3.Üçbucaq\n4" +
                  ".Çevrə\n" +
                  "5.Əsas Menyu";
            
            bool isContinue = true;
            
            while (isContinue)
            {
                Console.WriteLine(Menu);
                Console.WriteLine("operation daxil edin");
                int operation = int.Parse(Console.ReadLine());
                
                switch (operation)
                {
                    case 1:
                        SaheKvadrat();
                        break;
                    case 2:
                        SaheDuzbucaqli();
                        break;
                        case 3:
                        SaheUcbucaq();
                            break;
                    case 4:
                        SaheCevre();
                        break;
                    case 5:
                        isContinue = false;
                        break;


                    default:
                        Console.WriteLine("duzgun secim edin");
                        break;
                }

            }
        }

        public static void Menu2()
        {
            string Menu2 = "1.Kvadrat\n" +
                  "2.Düzbucaqlı\n" +
                  "3.Üçbucaq\n4" +
                  ".Çevrə\n" +
                  "5.Əsas Menyu";
            bool isContinue = true;

            while (isContinue)
            {
                Console.WriteLine(Menu2);
                Console.WriteLine("operation daxil edin");
                int operation = int.Parse(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        PerimetrKvadrat();
                        break;
                    case 2:
                        PerimetrDuzbucaqli();
                        break;
                    case 3:
                        PerimetrUcbucaq();
                        break;
                    case 4:
                        UzunlugCevre();
                        break;
                    case 5:
                        isContinue = false;
                        break;


                    default:
                        Console.WriteLine("duzgun secim edin");
                        break;
                }

                
            }
        }


public static void PerimetrKvadrat()
        {
            Console.WriteLine("Terefini daxil edin");
           float teref = float.Parse(Console.ReadLine());
            float perimetr = 4*teref;
            Console.WriteLine("kvadratin perimetri :"+ perimetr);
        }
        public static void SaheKvadrat() {
            Console.WriteLine("Terefini daxil edin");
            float teref = float.Parse(Console.ReadLine());
            float sahe = teref*teref;
            Console.WriteLine("kvadratin sahesi :" + sahe);
        }
        public static void PerimetrDuzbucaqli()
        {
            Console.WriteLine("uzunlugunu daxil edin");
            float teref1 = float.Parse(Console.ReadLine());
            Console.WriteLine("eni daxil edin");
            float teref2 = float.Parse(Console.ReadLine());
            float perimetr = 2*(teref1+teref2);
            Console.WriteLine("duzbucaqlinin perimetri :" +perimetr);
        }
        public static void SaheDuzbucaqli()
        {
            Console.WriteLine("uzunlugunu daxil edin");
            float teref1 = float.Parse(Console.ReadLine());
            Console.WriteLine("eni daxil edin");
            float teref2 = float.Parse(Console.ReadLine());
            float sahe = teref1*teref2 ;
            Console.WriteLine("duzbucaqlinin sahesi :" + sahe);
        }
        public static void PerimetrUcbucaq()
        {
            Console.WriteLine("ucbucagin 1ci tefini daxil edin");
            float teref1 = float.Parse(Console.ReadLine()) ;
            Console.WriteLine("ucbucagin 2ci tefini daxil edin");
            float teref2 = float.Parse(Console.ReadLine());
            Console.WriteLine("ucbucagin 3cu tefini daxil edin");
            float teref3 = float.Parse(Console.ReadLine());
            float perimetr = teref1 + teref2 + teref3;
            Console.WriteLine("ucbucagin perimetri :" + perimetr);
        }
        public static void SaheUcbucaq()
        {
            Console.WriteLine("ucbucagin 1ci tefini daxil edin");
            float teref1 = float.Parse(Console.ReadLine());
            Console.WriteLine("ucbucagin 2ci tefini daxil edin");
            float teref2 = float.Parse(Console.ReadLine());
            Console.WriteLine("ucbucagin 3cu tefini daxil edin");
            float teref3 = float.Parse(Console.ReadLine());
            float p = (teref1 + teref2 + teref3)/2;
            float sahe =(float) Math.Sqrt((double)(p * (p - teref1) * (p - teref2) * (p - teref3)));
            Console.WriteLine("ucbucagin perimetri :"+sahe);
        }
        public static void UzunlugCevre()
        {
            Console.WriteLine("Cevrenin radiusun daxil edin");
            float r = float.Parse(Console.ReadLine());
            float uzunlug = 2 * r *(float) Math.PI;
            Console.WriteLine("cevrenin uzunlugu :"+uzunlug);
        }
        public static void SaheCevre()
        {
            Console.WriteLine("Cevrenin radiusun daxil edin");
            float r = float.Parse(Console.ReadLine());
            float sahe =r*r * (float)Math.PI;
            Console.WriteLine("cevrenin sahesi :" + sahe);
        }

        public static bool Eminsenmi()
        {
            Console.WriteLine("cixmaq isteyirsiniz?(b/x)");
            char cavab = char.Parse(Console.ReadLine());
            if (cavab=='b')
            {
                return true;
                
            }
            else
            {
                return false;
            }

        }

        }
    
}
