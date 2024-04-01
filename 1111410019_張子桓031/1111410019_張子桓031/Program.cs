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
            string[] words = new string[50];
            bool[] t = new bool[50];
            char x;

            WriteLine("輸入字串 以空白鍵分隔：");
            w = ReadLine();
            WriteLine("輸入想找的字母：");
            x = char.Parse(ReadLine());
            words = w.Split(' ');

            if (words.Length > 50)
            {
                WriteLine("字串數量不可超過50!");
                return;
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 50)
                {
                    WriteLine("字串長度不可超過50!");
                    return;
                }
                t[i] = words[i].Contains(x);
            }

            Write("[");
            bool a = true;
            for (int j = 0; j < words.Length; j++)
            {
                if (t[j])
                {
                    if (!a)
                    {
                        Write(",");
                    }
                    Write(j);
                    a = false;
                }
            }
            Write("]");
        }
    }
}