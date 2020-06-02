using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diziler
            //Aynı tip(string, int, bool vb.) verileri tek bir yapı altında tutmamızı sağlayan yapılardır. RAM üzerindeki STACK bölümünde yer alırlar. Programlama dillerinin tamamında bulunan koleksiyon yapılarıdır. Bir dizi oluşturmak için aşağıdaki örnekleri inceleyebilirsiniz.

            string[] isimler = { "Ali", "Ayşe", "Mehmet", "Zeynep" };

            //Diziler 0. index'ten başlar.
            //string isim1 = isimler[0];
            //string isim2 = isimler[1];
            //string isim3 = isimler[2];
            //string isim4 = isimler[3];

            //Console.WriteLine(isim1+"\n"+isim2+"\n"+isim3+"\n"+isim4);
            //Console.Read();

            //isimler dizisinin elemanlarını döngü kullanarak tek tek console'a yazdırma.
            //for(int i=0; i<isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}

            //Console.Read();

            //Örnek(Instance) alarak dizi oluşturma.
            int[] sayilar = new int[3];
            sayilar[0] = 3;
            sayilar[1] = 7;
            sayilar[2] = 21;
            //sayilar[3] = 55;

            int x = 0;
            while (x < sayilar.Length)
            {
                Console.WriteLine(sayilar[x]);
                x++;
            }
            Console.Read();
        }
    }
}
