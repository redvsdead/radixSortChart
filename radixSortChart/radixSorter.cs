using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radixSortChart
{
    class radixSorter
    {
        public int sysBase = 10;    //основание системы счисления
        public int maxCount;        //наибольшее к-во цифр
        public long runTime;        //время выполнения

        public void countDig(int num, ref int max)
        {
            max = Math.Max(max, num.ToString().Length);
        }

        public void sorting(char[] arr)
        {
            runTime = DateTime.Now.Ticks;
            for (int i = 0; i < arr.Length; ++i)
            {
                countDig((int)arr[i], ref maxCount);
            }
            ArrayList[] lists = new ArrayList[sysBase];   //здесь хранятся списки элементов (элементы с 0, 1 и тд до 9 в нужном разряде)
            for (int i = 0; i < sysBase; ++i)
                lists[i] = new ArrayList();

            for (int digNum = 0; digNum < maxCount; ++digNum)
            {
                //распределение по спискам от 0 до 9
                for (int i = 0; i < arr.Length; ++i)
                {
                    //выделяем цифру на текущей позиции из номера символа и кладем символ в список
                    int temp = ((int)arr[i] % (int)Math.Pow(sysBase, digNum + 1)) / (int)Math.Pow(sysBase, digNum);
                    lists[temp].Add(arr[i]);
                }
                //сборка массива поразрядно
                int k = 0;
                for (int i = 0; i < sysBase; ++i)
                {
                    for (int j = 0; j < lists[i].Count; ++j)
                    {
                        arr[k++] = (char)lists[i][j];
                    }
                }
                for (int i = 0; i < sysBase; ++i)
                    lists[i].Clear();   //очистка списков элементов по разрядам

                runTime = DateTime.Now.Ticks - runTime;
            }
        }
    }
}
