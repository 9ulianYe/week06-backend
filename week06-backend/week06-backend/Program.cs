using System.Globalization;
using System.IO.Compression;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

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
            //Console.Write("請輸入名字：");
            //string input = Console.ReadLine();
            //string[] names = input.Split(',');
            //Console.WriteLine("<ul>");
            //foreach (string name in names)
            //{
            //    Console.WriteLine($"\t<li>{name.Trim()}</li>");
            //}
            //Console.WriteLine("</ul>");

            //Q12 輸入7處數字，用空白隔開，輸出結果。例如：輸入‘11 19 12 25 1 7 12，輸出總和是87

            //Console.Write("請輸入7個數字，用空白隔開：");
            //string input = Console.ReadLine();
            //string[] parts = input.Split(' ');
            //if (parts.Length != 7)
            //{
            //    Console.WriteLine("請輸入正好 7 個數字！");
            //    return;
            //}
            //int sum = 0;
            //foreach (string part in parts)
            //{   
            //    int transToNumber = Convert.ToInt32(part); 
            //    sum += int.Parse(part);
            //}
            //Console.WriteLine(sum);

            //Q13 輸入一串文字，倒著輸出，例如輸入：Justin，輸出nitsuJ

            //Console.Write("請輸入一串文字：");
            //string input = Console.ReadLine();
            //char[] chars = input.ToCharArray();
            //Array.Reverse(chars); 
            //string newString = new string(chars);
            //Console.WriteLine(newString);


            //===========================================================//
            // Ch7 Function

            //Ch7 Q1 寫一個function 可以把一般對話框的文字轉成HTML

            //string ConvertToHtml(string input)
            //{
            //    return input
            //        .Replace("&", "&amp;")       
            //        .Replace(">", "&gt;")
            //        .Replace("<", "&lt;")
            //        .Replace("\r\n", "<br>")
            //        .Replace("|", "&brvbar;")
            //        .Replace(" ", "&nbsp;");
            //}
            //Console.Write("請輸入對話框的文字：");
            //string text = Console.ReadLine();
            //string html = ConvertToHtml(text);
            //Console.WriteLine("HTML：");
            //Console.WriteLine(html);

            //Ch7 Q2寫一個function，回傳輸入的值是否數字 ?

            //bool IsNumber(string input)
            //{
            //    return Regex.IsMatch(input, @"^-?\d+(\.\d+)?$");
            //}

            //Console.Write("請輸入一個數值：");
            //string input = Console.ReadLine();

            //if (IsNumber(input))
            //{
            //    Console.WriteLine("是數字！");
            //}
            //else
            //{
            //    Console.WriteLine("不是數字！");
            //}

            //Ch7 Q3 寫一個function，回傳輸入的值是否符合Ｅ－ｍａｉｌ格式

            //bool IsEmail(string input)
            //{
            //    return Regex.IsMatch(input, @"^[\w.-]+@[\w.-]+\.[a-zA-Z]{2,}$");
            //}

            //Console.Write("請輸入 Email：");
            //string input = Console.ReadLine();

            //if (IsEmail(input))
            //{
            //    Console.WriteLine("這是正確的 Email 格式");
            //}
            //else
            //{
            //    Console.WriteLine("格式錯誤！");
            //} 

            //Ch7 Q4 寫一個function，回傳輸入的值是否符合手機格式

            //bool IsTaiwanPhone(string input)
            //{
            //    return Regex.IsMatch(input, @"^09\d{8}$");
            //}

            //Console.Write("請輸入手機號碼：");
            //string input = Console.ReadLine();

            //if (IsTaiwanPhone(input))
            //{
            //    Console.WriteLine("這是正確的手機格式");
            //}
            //else
            //{
            //    Console.WriteLine("格式錯誤！");
            //} 

            //Ch7 Q5 寫一個function，回傳輸入的值是否符合身分證字號格式

            //bool IsID(string input)
            //{
            //    return Regex.IsMatch(input, @"^[A-Z][12]\d{8}$");
            //}

            //Console.Write("請輸入身份證字號：");
            //string id = Console.ReadLine();

            //if (IsID(id))
            //{
            //    Console.WriteLine("這是正確的身份證格式");
            //}
            //else
            //{
            //    Console.WriteLine("格式錯誤！");
            //}

            //Ch7 Q6 寫一個function，若輸入的文字大於Ｎ個，則超過的字不要，變成點點點?

            //string Function (string input, int maxLength)
            //{
            //    if (input.Length <= maxLength)
            //        return input;
            //    else
            //        return input.Substring(0, maxLength) + "...";
            //}

            //Console.Write("請輸入最多顯示N個字：");
            //int n = Convert.ToInt32(Console.ReadLine());

            //Console.Write("請輸入一段文字：");
            //string input = Console.ReadLine();

            //string result = Function(input, n);
            //Console.WriteLine($"結果：{result}");

            //Ch7 Q7 寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式

            //string ConvertToROC(string input) 
            //{
            //    // 正則式：支援 YYYY/MM/DD、YYYY-MM-DD、YYYY.MM.DD
            //    string pattern = @"^(\d{4})[\/\.-](\d{1,2})[\/\.-](\d{1,2})$";
            //    Match match = Regex.Match(input, pattern);
            //    if (!match.Success)
            //    {
            //        Console.WriteLine("日期格式錯誤！");
            //        return null;
            //    }
            //    int year = int.Parse(match.Groups[1].Value);
            //    int month = int.Parse(match.Groups[2].Value);
            //    int day = int.Parse(match.Groups[3].Value);

            //    // 建立 DateTime，避免無效日期如 2025/13/99
            //    if (!DateTime.TryParse($"{year}/{month}/{day}", out DateTime date))
            //    {   
            //        Console.WriteLine("日期格式錯誤！");
            //        return null;
            //    }

            //    int rocYear = year - 1911;
            //    return $"{rocYear}.{month:D2}.{day:D2}";
            //}

            //Console.Write("請輸入日期：");
            //string input = Console.ReadLine();

            //string result = ConvertToROC(input);
            //if (result != null) 
            //{ 
            //    Console.WriteLine($"民國格式：{result}");
            //}

            //Ch7 Q8寫一個function，輸入一個日期，把該日期轉成民國XX年XX月XX日 星期X 格式 

            //string ConvertToROCWithWeek(string input)
            //{
            //    string pattern = @"^(\d{4})[\/](\d{1,2})[\/](\d{1,2})$";
            //    Match match = Regex.Match(input, pattern);

            //    if (!match.Success)
            //    {
            //        Console.WriteLine("日期格式錯誤！請使用 yyyy/MM/dd");
            //        return null;
            //    }

            //    if (!DateTime.TryParse(input, out DateTime date))
            //    {
            //        Console.WriteLine("此日期不存在，例如 2025/02/30");
            //        return null;
            //    }

            //    int rocYear = date.Year - 1911;
            //    string weekday = date.ToString("dddd", new CultureInfo("zh-TW"));

            //    return $"民國{rocYear}年{date.Month:D2}月{date.Day:D2}日 {weekday}";
            //}

            //Console.Write("請輸入日期（例如 2025/07/11）= ");
            //string input = Console.ReadLine();

            //string result = ConvertToROCWithWeek(input);
            //if (result != null)
            //    Console.WriteLine(result);

            //Q9 寫一個function，回傳輸入的年是否閏年

            //bool IsLeapYear(int year)
            //{
            //    return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            //}

            //Console.Write("請輸入年份：");

            //int input = Convert.ToInt32(Console.ReadLine());

            //if (IsLeapYear(input))
            //    Console.WriteLine($"{input} 是閏年");
            //else
            //    Console.WriteLine($"{input} 不是閏年");

            //Q10 寫一個function，輸入手機號碼，回傳今天運勢
            //(手機運勢算法：用你的手機號碼的最後四位數除以80，再減去整數部分（只留小數），再乘以80，
            //就會得到一個數，這就是代表吉凶的數字，印出結果。)

            //static int GetFortuneNumber(string phone)
            //{
            //    string last4 = phone.Substring(phone.Length - 4);
            //    int last4Num = int.Parse(last4);

            //    double step1 = last4Num / 80.0;
            //    double step2 = step1 - Math.Floor(step1);
            //    int step3 = (int)(step2 * 80) ;

            //    return step3;
            //}

            //string[] fortunesArr = new string[81]
            //{
            //    "大展鴻圖．可獲成功　吉",
            //    "一盛一衰．勞而無功　凶",
            //    "蒸蒸日上．百事順遂　吉",
            //    "坎坷前途．苦難折磨　凶",
            //    "生意欣榮．名利雙收　吉",
            //    "天降幸運．可成大功　吉",
            //    "和氣致祥．必獲成功　吉",
            //    "貫徹志望．成功可期　吉",
            //    "獨營無力．財利無望　凶",
            //    "空費心力．徒勞無功　凶",
            //    "穩健著實．必得人望　吉",
            //    "薄弱無力．謀事難成　凶",
            //    "天賦吉運．能得人望　吉",
            //    "是成是敗．惟靠堅毅　凶",
            //    "大事成就．一定興隆　吉",
            //    "成就大業．名利雙收　吉",
            //    "有貴人助．可得成功　吉",
            //    "順利昌隆．百事亨通　吉",
            //    "內外不合．障礙重重　凶",
            //    "歷盡艱難．焦心憂勞　凶",
            //    "專心經營．善用智慧　吉",
            //    "懷才不遇．事不如意　凶",
            //    "名顯四方．終成大業　吉",
            //    "須靠自力．能奏大功　吉",
            //    "天時地利．再得人格　吉",
            //    "波瀾起伏．凌駕萬難　凶",
            //    "一盛一衰．可守成功　凶帶吉",
            //    "遇衰轉吉. 遇厄轉好　吉",
            //    "青雲直上．才略奏功　吉",
            //    "吉凶參半．得失相伴　凶",
            //    "名利雙收．大業成就　吉",
            //    "池中之龍．成功可望　吉",
            //    "智慧慎始．必可昌隆　吉",
            //    "災難不絕．難望成功　凶",
            //    "中吉之數．進退保守　吉",
            //    "波瀾重疊．常陷窮困　凶",
            //    "逢凶化吉．風調雨順　吉",
            //    "名雖可得．利則難獲　凶帶吉",
            //    "光明坦途．指日可待　吉",
            //    "一盛一衰．浮沉不定　吉帶凶",
            //    "天賦吉運．前途無限　吉",
            //    "事業不專．十九不成　吉帶凶",
            //    "忍耐自重．轉凶為吉　吉帶凶",
            //    "事難遂願．貪功好進　凶",
            //    "綠葉發枝．一舉成名　吉",
            //    "坎坷不平．艱難重重　凶",
            //    "有貴人助．可成大業　吉",
            //    "名利俱全．繁榮富貴　吉",
            //    "遇吉則吉．遇凶則凶　凶",
            //    "吉凶互見．一成一敗　吉帶凶",
            //    "一盛一衰．浮沉不常　吉帶凶",
            //    "雨過天青．即獲成功　吉",
            //    "盛衰參半．先吉後凶　吉帶凶",
            //    "雖傾全力．難望成功　凶",
            //    "外觀隆昌．內隱禍患　吉帶凶",
            //    "事與願違．終難成功　凶",
            //    "努力經營．時來運轉　吉",
            //    "浮沉多端．始凶終吉　凶帶吉",
            //    "遇事猶疑．難望成事　凶",
            //    "心迷意亂．難定方針　凶",
            //    "雲遮半月．百隱風波　吉帶凶",
            //    "煩悶懊惱．事事難展　凶",
            //    "萬物化育．繁榮之象　吉",
            //    "十九不成．徒勞無功　凶",
            //    "吉運自來．能享盛名　吉",
            //    "內外不和．信用缺乏　凶",
            //    "事事如意．富貴自來　吉",
            //    "不失先機．可望成功　吉",
            //    "動搖不安．常陷逆境　凶",
            //    "慘澹經營．難免貧困　凶",
            //    "吉凶參半．惟賴勇氣　吉帶凶",
            //    "得而復失．難以安順　凶",
            //    "安樂自來．自然吉祥　吉",
            //    "如無智謀．難望成功　凶",
            //    "吉中帶凶．進不如守　吉帶凶",
            //    "此數大凶．破產之象　凶",
            //    "先苦後甘．不致失敗　吉帶凶",
            //    "有得有失．華而不實　吉帶凶",
            //    "前途無光．希望不大　凶",
            //    "得而復失．枉費心機　吉帶凶",
            //    "最極之數．能得成功　吉"
            //};



            //Console.Write("請輸入手機號碼：");
            //string input = Console.ReadLine();
            //if (!Regex.IsMatch(input, @"^09\d{8}$"))
            //{
            //    Console.WriteLine("手機格式錯誤，請輸入正確的 10 位數字，例如：0912345678");
            //    return;
            //}
            //int fortuneNum = GetFortuneNumber(input);
            //Console.WriteLine($"你的運勢是：{fortunesArr[fortuneNum - 1]}");
            
        }   
    }
}
