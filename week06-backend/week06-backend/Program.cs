using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;
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

            //Console.Write("請輸入一個單字：");
            //string word = Console.ReadLine();
            //if (word.Length < 5)
            //{
            //    Console.WriteLine("長度不夠");
            //}
            //else {
            //    string firstThreeword = word.Substring(0, 3);
            //    Console.WriteLine($"前三個字是：{firstThreeword}");
            //}

            //Q6.輸入一段字，輸出把輸入的一段字裡面的我，改成小明，如輸入我在唱歌，輸出小明在唱歌。

            //Console.Write("請輸入一段文字：");
            //string input = Console.ReadLine();
            //string wordReplace = input.Replace("我", "小明");
            //Console.WriteLine(wordReplace);

            //Q7.輸入一串字，顯示輸入幾個字

            //Console.Write("請輸入一段文字：");
            //string input = Console.ReadLine();
            //int wordCount = input.Length;
            //Console.WriteLine(wordCount);


            //CH6. 字串 補充練習題

            //Q8.連續輸入10組字，若沒輸入過，就顯示沒出現過，若輸入過，就顯示輸入過。

            //string allInput = " ";
            //int i = 0;
            //while (i < 10) {
            //    Console.Write($"第{i+1}次輸入 : ");
            //    string input = Console.ReadLine();

            //    if (allInput.Contains($"[{input}]"))
            //    {
            //        Console.WriteLine("輸入過");
            //    }
            //    else
            //    {
            //        Console.WriteLine("沒出現過");
            //        allInput += $"[{input}]";

            //    }
            //    i++;
            //}

            //Q9. 用字母大小寫來模擬波浪舞的動作後輸出

            //Console.Write("請輸入一段字：");
            //string input = Console.ReadLine().ToLower();

            //for (int i = 0; i < input.Length; i++) {
            //    char[] chars = input.ToCharArray();
            //    chars[i] = Char.ToUpper(chars[i]);
            //    string result = new string(chars);
            //    Console.WriteLine(result);  
            //}

            //Q10 輸入時間，顯示幾時幾分，例如輸入11:30，輸出11點30分

            //Console.Write("請輸入時間（格式：HH:mm）：");
            //string input = Console.ReadLine();
            //if (Regex.IsMatch(input, @"^([01]\d|2[0-3]):([0-5]\d)$"))
            //{
            //    string[] parts = input.Split(':');
            //    Console.WriteLine(parts[0] + "點" + parts[1] + "分");
            //}
            //else {
            //    Console.WriteLine("格式錯誤，請輸入 HH:mm，例如 09:30");
            //}

            //Q11 輸入的字，轉成HTML
            Console.Write("請輸入名字：");
            string input = Console.ReadLine();
            string[] names = input.Split(',');
            Console.WriteLine("<ul>");
            foreach (string name in names) { 
                Console.WriteLine($"\t<li>{name.Trim()}</li>");
            }
            Console.WriteLine("</ul>");
        }   
    }
}
