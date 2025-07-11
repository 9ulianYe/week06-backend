using System.IO.Compression;
using System.Text.RegularExpressions;

namespace week06_backend
{
    internal class Program
    {
        static void Main(string[] args)
        {   //CH6. 字串
            //Q1.輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin。

            //Console.Write("輸入姓名 : ");
            //string input = Console.ReadLine();
            //Console.WriteLine($"Hi~{input}");

            //Q2. 請輸入任何一個字，是否出現在”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡。

            //Console.Write("請輸入任何一個字 : ");
            //string input = Console.ReadLine();
            //string sentcne = "人人為我，我為人人、饒人不癡漢，癡漢不饒人";
            //if (sentcne.Contains(input)) 
            //{
            //    Console.WriteLine($"\"{input}\"在句子中");
            //}
            //else
            //{
            //    Console.WriteLine($"\"{input}\"不在句子中");
            //}

            //Q3.輸入一段字，輸出每個之間多一個-，如輸入apple ，輸出a-p-p-l-e。

            //Console.Write("請輸入一個字 : ");
            //string input = Console.ReadLine();
            //char[] chars = input.ToCharArray();
            //string newString = " ";

            //for (int i = 0; i < chars.Length; i++)
            //{
            //    newString += chars[i];
            //    if (i < chars.Length-1)
            //    {
            //        newString += "-";
            //    }
            //}
            //Console.WriteLine(newString);

            //Q4. 輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg

            //Console.Write("請輸入檔名： ");
            //string fileName = Console.ReadLine();
            //string pattern =@"^[^\\/:*?<>|]+\.[a-zA-Z0-9]+$";
            //if (Regex.IsMatch(fileName, pattern)) 
            //{
            //    string[] fileNamePart = fileName.Split('.');
            //    string fileExtention = fileNamePart[^1];
            //    Console.WriteLine($"副檔名是：{fileExtention}" );
            //}
            //else
            //{
            //    Console.WriteLine("檔名格式不正確！");
            //}

            //Q5.輸入一個大於五個字的單字，若小於五個字輸出長度不夠，若大於五個字，則輸出前三個字
            
            Console.Write("請輸入一個單字：");
            string word = Console.ReadLine();
            if (word.Length < 5)
            {
                Console.WriteLine("長度不夠");
            }
            else {
                string firstThreeword = word.Substring(0, 3);
                Console.WriteLine($"前三個字是：{firstThreeword}");
            }
        }   

    }
}
