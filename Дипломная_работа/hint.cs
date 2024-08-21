using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Net.Security;

namespace NIR
{
    internal class Program
    {
        static bool Find_serially(StreamReader file, string word)//from file of string
        {
            string temp;
            while (file.EndOfStream != true)
            {
                temp = file.ReadLine();
                if (word == temp)
                {
                    return true;
                }
            }
            file.DiscardBufferedData();
            file.BaseStream.Position = 0;
            return false;
        }

        static string Seek(StreamReader file, int n)//find n word from file
        {   
            string temp="";
            for (int i = 0; i < n; i++)
            {
                temp = file.ReadLine();
            }
            file.DiscardBufferedData();
            file.BaseStream.Position = 0;
            return temp;
        }

        static int Compare(string w1, string w2)//w1=искомое w2=полученное
        {
            if (w1 == w2) return 0;
            for (int i = 0; i < w1.Length && i < w2.Length; i++)
            {
                if (w1[i] != w2[i])
                {
                    if (w1[i] < w2[i])
                    {
                        return -1;
                    }
                    else return 1;
                }
            }
            if (w1.Length < w2.Length) return -1;
                else return 1;
            //0=равные слова 1=первая половина -1=вторая половина
        }

        static bool Dyhot(string Find_word, StreamReader file, double Nmax)//for file
        {
            string Temp_word = "";
            int Sign = 3;
            double N = Math.Ceiling(Nmax / 2);
            int z = Convert.ToInt32(N);
            double Nmin = 1;            
            while (Sign!=0)
            {              
                Temp_word = Seek(file, z);
                Sign = Compare(Find_word, Temp_word);
                if (Sign == 0)
                {
                    return true;
                }
                if (N == Nmin || N == Nmax)
                {
                    return false;
                }
                if (Sign == -1)
                {
                    Nmax = N;
                    N = Math.Floor(Nmax - (Nmax - Nmin) / 2);
                    z = Convert.ToInt32(N);
                }
                if (Sign == 1)
                {
                    Nmin = N;
                    N = Math.Ceiling(Nmax - (Nmax - Nmin) / 2);
                    z = Convert.ToInt32(N);
                }                
            }
            return false;
        }

        static bool Find_serially_arr(string[] file, string word)//for array
        {
            for(int i = 0; i < file.Length; i++)
            {
                if (file[i] == word) return true;
            }
            return false;
        }

        static bool Dyhot_arr(string[] file, string Find_word)//for array
        {
            string Temp_word;
            double Nmax = file.Length;
            double Nmin = 0;
            double N = Math.Ceiling(Nmax / 2);
            int z = Convert.ToInt32(N);
            int Sign = 3;
            while (Sign != 0)
            {
                Temp_word = file[z];
                Sign = Compare(Find_word, Temp_word);
                if (Sign == 0)
                {
                    return true;
                }
                if (N == Nmin || N == Nmax)
                {
                    return false;
                }
                if (Sign == -1)
                {
                    Nmax = N;
                    N = Math.Floor(Nmax - (Nmax - Nmin) / 2);
                    z = Convert.ToInt32(N);
                }
                if (Sign == 1)
                {
                    Nmin = N;
                    N = Math.Ceiling(Nmax - (Nmax - Nmin) / 2);
                    z = Convert.ToInt32(N);
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            string Find_word;
            string path = "russian_words_sorted.txt";
            string[] file = File.ReadAllLines(path);
            double N = file.Length;
            Console.WriteLine("Выберите откуда искать слово:");
            Console.WriteLine("1 - Из файла");
            Console.WriteLine("2 - Из массива");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    {
                        Console.WriteLine("Выберите способ поиска слова:");
                        Console.WriteLine("1 - Методом последовательного поиска");
                        Console.WriteLine("2 - Методом Дихотомии");
                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.D1:
                                {
                                    Console.WriteLine("Введите искомое слово");
                                    Find_word = Console.ReadLine();                                   
                                    using (StreamReader sr = new StreamReader(path))
                                        Console.WriteLine(Find_serially(sr, Find_word));                                                                                                               
                                    break;
                                }                             
                            case ConsoleKey.D2:
                                {
                                    Console.WriteLine("Введите искомое слово");
                                    Find_word = Console.ReadLine();
                                    using (StreamReader sr = new StreamReader(path))
                                        Console.WriteLine(Dyhot(Find_word, sr, N));                                    
                                    break;
                                }                             
                        }
                        break;
                    }                        
                case ConsoleKey.D2:
                    {
                        Console.WriteLine("Выберите способ поиска слова:");
                        Console.WriteLine("1 - Методом последовательного поиска");
                        Console.WriteLine("2 - Методом Дихотомии");
                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.D1:
                                {
                                    Console.WriteLine("Введите искомое слово");
                                    Find_word = Console.ReadLine();
                                    Console.WriteLine(Find_serially_arr(file, Find_word));                                                                        
                                    break;
                                }                                
                            case ConsoleKey.D2:
                                {
                                    Console.WriteLine("Введите искомое слово");
                                    Find_word = Console.ReadLine(); 
                                    Console.WriteLine(Dyhot_arr(file, Find_word));  
                                    break;
                                }                                
                        }
                        break;
                    }                  
            }  
            Console.ReadKey();
        }
    }
}
/*
var startTime = System.Diagnostics.Stopwatch.StartNew();
for (int i = 0; i < 1000; i++)
{
    
}
startTime.Stop();
var resultTime = startTime.Elapsed;
string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
resultTime.Hours,
resultTime.Minutes,
resultTime.Seconds,
resultTime.Milliseconds);
Console.WriteLine(elapsedTime);
*/