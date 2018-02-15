using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test180215
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 字符串提取练习1（提取组练习）


            //string path = @"192.168.10.5[port=21,type=ftp]";
            //Match match = Regex.Match(path, @"^((\d{1,3}\.){3}\d{1,3})\[port=(\d{2,6}),(type=([a-zA-Z]+))?\]$");
            //if (match.Success)
            //{
            //    Console.WriteLine(match.Groups[1].Value);
            //    Console.WriteLine(match.Groups[3].Value);
            //    string services = (string.IsNullOrEmpty(match.Groups[5].Value)) ? "http" : match.Groups[5].Value;
            //    Console.WriteLine(services);
            //}
            #endregion

            #region 提取月份
            //string month = "June    26   ,    1951";
            //string regMonth = @"([a-zA-Z]+)\s+(\d{1,2})\s*,\s*(\d{4})";
            //Match match = Regex.Match(month, regMonth);
            //if(match.Success)
            //{
            //    Console.WriteLine(match.Groups[0]);
            //    Console.WriteLine(match.Groups[1]);
            //    Console.WriteLine(match.Groups[2]);
            //    Console.WriteLine(match.Groups[3]);
            //    Console.WriteLine("ok");
            //}
            //Console.WriteLine("final");
            #endregion

            #region 提取名字（采用贪婪模式测试）
            //还不能提取句号第一个为止，把后面的都提取了，如果是多个句号的话
            string name = "大家好，我是S.H.E。我今天22岁了，我病了，55sffff，我是李小家。我是李大家。我是郑成功。";
            string regName = @"我是(.+?)。";    // 使用 我是(.+)。   提取出:S.H.E.   到。号为止
            //string regName = "我是(.+?)";   //因为使用? 不再贪婪模式，只提取出S

            //  Match match = Regex.Match(name, regName);
            // MatchCollection mc = Regex.Matches(html, regEmail)
            MatchCollection match = Regex.Matches(name, regName);
            foreach (Match mc in match)
            {
                Console.WriteLine("提取成功");
                Console.WriteLine(mc.Groups[1].Value);
               // Console.WriteLine(mc.Groups[2].Value);
               // Console.WriteLine(mc.Groups[3].Value);
            }
            #endregion

            #region 贪婪模式1
            //默认正则表达式采用贪婪模式，尽可能多的匹配
            //string str = "阿哈哈hello world wwwddd!";
            ////提取英文
            ////当正则表达式提取的时候，如果一个字符也能匹配，多个字符也能匹配，这时，会按照使用最多字符的方式来匹配，这就叫贪婪模式
            //string regStr = "[a-zA-Z]+?";  //使用?来终止贪婪模式，在限制符后面使用  只提取到h
            //Match match = Regex.Match(str, regStr);
            //Console.WriteLine(match.Value);
            #endregion


            Console.ReadLine();

        }
    }
}
