namespace week06_backend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1.輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin。
            Console.Write("輸入姓名 : ");
            string input = Console.ReadLine();
            Console.WriteLine($"Hi~{input}");
        }
    }
}
