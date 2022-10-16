using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DeclareString
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Q1:呈現C:\temp\a.jpg
			string filepath1_1 = "C:\\temp\\a.jpg";
			Console.WriteLine(filepath1_1);
			string filepath1_2 = @"C:\temp\a.jpg"; //用@""的話路徑可不用加上逸出字元
			Console.WriteLine(filepath1_2);

			//Q2:呈現我是一個"好學生".
			string sentence2 = "我是一個\"好學生\"";
			Console.WriteLine(sentence2);

			/*Q3:呈現我是第一行
                     我是第二行*/
			string sentence3 = "我是第一行\r\n我是第二行";
			Console.WriteLine(sentence3);

		}
	}
}
