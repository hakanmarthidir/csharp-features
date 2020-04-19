using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_7_3
{
    //stackalloc
    //Stack üzerinde memory alanı ayırt edebilmek için kullanılan bir keyworddur. 
    //Bu keyword kullanılarak yaratılan degerlerin System.Span<T> veya System.ReadOnlySpan<T> ya atanması tavsiye edilir. 
    //Bakınız Ref : https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/stackalloc

    //Span, ReadOnlySpan, Memory gibi nesneler memory yonetimini daha iyi yapabilmek ve performance saglayabilmek için kullanılan yapılardır. 
    //Spanlar genellikle arraylari ve arraylarin bazı bolumlerini tutmak için kullanılır. 
    //**  a Span<T> instance can point to managed memory, native memory, or memory managed on the stack.

    public class InitializersOnStackalloc
    {

        public InitializersOnStackalloc()
        {
            //Bu tip bir örnekte unsafe keywordunu kullanmanıza gerek yok. çünkü degeri Span nesnesine atamaktasınız. 
            //Onemli : unsafe anahtar kelimesi ancak pointer tanımlaması yaptıgınızda kullanılır. 

            //Stack memory üzerinde calisiyoruz. v7.2
            Span<int> luckynumbers = stackalloc int[10];
            Random rnd = new Random();
            for (var i = 0; i < luckynumbers.Length; i++)
            {
                luckynumbers[i] = rnd.Next(1,50);
            }

            foreach (var item in luckynumbers)
            {
                Console.WriteLine(item);
            }

            //v7.3 feature
            //yukarıdaki versiyonda önce tanımlama sonra doldurma işlemini yaptık. 7.3 ile beraber initialize edebiliyoruz.
            //Onemli : stackalloc ile kullanılabilecek unmanaged tipler : 
            //pointer, enum, sbyte, byte, short, ushort, int, uint, long, ulong, char, float, double, decimal, bool
            // bir sonraki versiyonda struct lar. (8.0)

            //spanlar tamamen stack bölümüne özgüdür. 
            Span<int> luckynumbers_first = stackalloc int[3] { rnd.Next(1, 50), rnd.Next(1, 50), rnd.Next(1, 50) };
            Span<byte> luckynumbers_second = stackalloc byte[] { 15, 23, 33 };
            ReadOnlySpan<long> luckynumbers_third = stackalloc[] { 1L, 2L, 3L };

            foreach (var item in luckynumbers_first)
            {
                Console.WriteLine(item);
            }

            //Span<T> ile managed memory, native memory ve stack memory üzerinde çalışabilirsiniz.  Ref: https://docs.microsoft.com/en-us/dotnet/api/system.span-1?view=netcore-3.1

        }



    }
}
