using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace クイックソート
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] a = { '7', '6', '5', '4', '3', '2', '1' };
            int i;
            
            Console.WriteLine("元々の配列順");
            for (i = 0; i < a.Length; i++)
                Console.Write(a[i]);
            Console.WriteLine();

            //クイックソートする
            Quicksort.QSort(a);
            Console.WriteLine("ソート後の配列順");
            for (i = 0; i < a.Length; i++)
                Console.Write(a[i]);
            Console.WriteLine();
            
        }
    }
    class Quicksort
    {
        //クイックソートの本体を呼ぶための開始部分
        public static void QSort(char[] items)
        {
            qs(items, 0, items.Length - 1);
        }

        //文字配列のクイックソートの再帰呼び出しバージョン
        static void qs(char[] items, int left, int right)
        {
            int i, j;
            char x, y;
            i = left; j = right;
            x = items[(left + right) / 2];

            do
            {
                while ((items[i] < x) & (i < right)) i++;
                while ((x < items[j]) & (j > left)) j--;
                if (i <= j)
                {
                    y = items[i];
                    items[i] = items[j];
                    items[j] = y;
                    i++; j--;
                }
            } while (i <= j);
            if (left < j) qs(items, left, j);
            if (i < right) qs(items, i, right);
        }
    }
}
