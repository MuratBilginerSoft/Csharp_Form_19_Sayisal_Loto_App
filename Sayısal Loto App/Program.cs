using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayısal_Loto_App
{
    class Program
    {


        static void Main(string[] args)
        {
            #region Parameters

            int[] KS = new int[6];
            int[] BS = new int[6];
            int[] TTS = new int[0];

            int x = 0; // Bilinen Adeti Tutacak
            int y;// Rastgele Seçilen Sayıyı Tutacak
            int k = 0;
            int s = 1;

            #endregion

            #region Definitions

            Random r = new Random();

            #endregion

            #region Kullanıcıdan Sayı Alma

            for (int i = 0; i < KS.Length; i++)
            {
                Console.Write(s+". Sayıyı Giriniz:");
                KS[i] = int.Parse(Console.ReadLine());
                s++;
            }

            #endregion

            #region Bilgisayardan Sayı Alma
            
            for (int i = 0; i < BS.Length; i++)
            {
                do
                {
                    y = r.Next(1,50);
                } while (Array.IndexOf(BS,y)!=-1);

                BS[i] = y;
            }
            #endregion

            #region Karşılaştırma

            for (int i = 0; i < KS.Length; i++) // 1 2 3 4 5  6
            {
                for (int j = 0; j < BS.Length; j++) // 1*6 2*6 3*6 4*6 5*6 6*6 
                {
                    if (KS[i] == BS[j])
                    {
                        x++; // 1 2
                        Array.Resize(ref TTS, x);
                        TTS[k] = KS[i];
                        k++;
                    }
                }
            }
            #endregion

            #region Kullanıcıya Gösterme

            Console.WriteLine();
            Console.WriteLine("Bizim Tuttuğumuz Sayılar");
            

            for (int i = 0; i < KS.Length; i++)
            {
                Console.Write(KS[i]+" - ");
            }

            Console.WriteLine();
            Console.WriteLine("Bilgisayarın Tuttuğu Sayılar");
           


            for (int i = 0; i < KS.Length; i++)
            {
                Console.Write(BS[i] + " - ");
            }

            Array.Sort(KS);
            Array.Sort(BS);

            Console.WriteLine();
            Console.WriteLine("Bizim Tuttuğumuz Sayılar Sıralı");

            for (int i = 0; i < KS.Length; i++)
            {
                Console.Write(KS[i] + " - ");
            }

            Console.WriteLine();
            Console.WriteLine("Bilgisayarın Tuttuğu Sayılar Sıralı");
           


            for (int i = 0; i < KS.Length; i++)
            {
                Console.Write(BS[i] + " - ");
            }

            Console.WriteLine();
            Console.WriteLine("Tutturduğumuz Sayılar");
          
            for (int i = 0; i < TTS.Length; i++)
            {
                Console.Write(TTS[i] + " - ");
            }

            Console.WriteLine();
            Console.WriteLine("Tutturduğunuz Adet:{0}",x);

            #endregion

            Console.ReadKey();
        }
    }
}
