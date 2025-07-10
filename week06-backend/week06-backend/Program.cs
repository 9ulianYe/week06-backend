namespace week06_backend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1.輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin。
            //Console.Write("輸入姓名 : ");
            //string input = Console.ReadLine();
            //Console.WriteLine($"Hi~{input}");

            //Q2. 請輸入任何一個字，是否出現在”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡。
            Console.Write("請輸入任何一個字 : ");
            string input = Console.ReadLine();
            string sentcne = "人人為我，我為人人、饒人不癡漢，癡漢不饒人";
            if (sentcne.Contains(input)) 
            {
                Console.WriteLine($"\"{input}\"在句子中");
            }
            else
            {
                Console.WriteLine($"\"{input}\"不在句子中");
            }

        }

    }
}
