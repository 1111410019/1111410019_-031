using System;
using System.Collections.Generic;
using static System.Console;
namespace _1111410019_張子桓_031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string w;
            string[] words = new string[50];		//設定字串與儲存變數
            bool[] t = new bool[50];
            char x;

            WriteLine("輸入字串 以空白鍵分隔：");	//先輸入字串 以空白鍵區分
            w = ReadLine();
            WriteLine("輸入想找的字母：");		//想查詢的字元
            x = char.Parse(ReadLine());
            words = w.Split(' ');			//以空白鍵隔開 輸入進字串陣列裡

            if (words.Length > 50)
            {
                WriteLine("字串數量不可超過50!");	//先判斷字串數量有沒有超過50
     		return;
	    }
            for (int i = 0; i < words.Length; i++)	//以字串陣列的大小迴圈
            {
                if (words[i].Length > 50)
                {
                    WriteLine("字串長度不可超過50!");	//判斷字串長度有沒有超過50
                    return;
                }
                t[i] = words[i].Contains(x);		//如果字串裡有字元 就加入t
            }

            Write("[");					//先括弧[
            bool a = true;				//判斷是否為第一個索引
            for (int j = 0; j < words.Length; j++)	
            {
                if (t[j])				
                {
                    if (!a)
                    {
                        Write(",");			//如果不是第一個索引就不要在索引前加上','
                    }
                    Write(j);
                    a = false;
                }
            }
            Write("]");					//最後加上括弧]
        }
    }
}