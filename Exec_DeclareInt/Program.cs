using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DeclareInt
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q1:計算1+(2+2)*3-1
			int value1 = 1 + (2 + 2) * 3 - 1;
			Console.WriteLine("Ans1:" + value1);

			//Q2:求120/7的商數及餘數各是多少
			int value2_1 = 120 / 7;
			int value2_2 = 120 % 7;
			Console.WriteLine("Ans2:商數=" + value2_1 + " 餘數=" + value2_2);

			//Q3:判斷9,202各別是奇數還偶數
			/*寫法1
            int value3_1 = 9 % 2;
            int value3_2 = 202 % 2;
            if (value3_1 == 0)
            {
                Console.WriteLine("Ans3:9是偶數");
            }
            else
            {
                Console.WriteLine("Ans3:9是奇數");
			}
            if (value3_2 == 0)
            {
                Console.WriteLine("Ans3:202是偶數");
			}
            else
            {
                Console.WriteLine("Ans3:202是奇數");
            }*/

			//寫法2
			int value3_1 = 9;
			int value3_2 = 202;
			string result1 = (value3_1 % 2 == 0) ? value3_1 + "是偶數" : value3_1 + "是奇數";
			string result2 = (value3_2 % 2 == 0) ? value3_2 + "是偶數" : value3_2 + "是奇數";
			Console.WriteLine("Ans3:" + result1 + " " + result2);

		}
	}
}
