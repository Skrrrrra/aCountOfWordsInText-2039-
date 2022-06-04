using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace aCountOfWordsInText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //путь и создание файлов
            #region
            //путь
            string inputpath = "D:\\SolutionsForSpaceApp\\2039\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2039\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();
            #endregion

            string firstLine;
            using (var reader = new StreamReader(inputpath))
            {
                firstLine = reader.ReadLine();
            }

            //заполнение массивов буквами
            #region

            List<char> latinAlph = new List<char>();
            char aFromAlphSmall = 'a';
            for (int i = 0; i <= 26; i++)
            {
                latinAlph.Add((char)(32+i));
            }

            #endregion

            List<int> forCount = new List<int>();
            int counter = 0;
            foreach (char c in firstLine)
            {
                if (latinAlph.Contains(c))
                {
                    counter++;
                }
                else
                {
                    forCount.Add(counter);
                    counter = 0;
                }
            }

            while(forCount.Contains(0))
            {
                forCount.Remove(0);
            }
            


            int countOfWords = forCount.Count()+1;
                       
            File.WriteAllText(outputpath, countOfWords.ToString());

        }
    }
}
