using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test18021502贪婪模式2练习
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1111。 1    1。    111。   11111。";
            //string regStr = ".+。";   //因为.+要尽可能多的匹配，所以会认为 1111。1    1。   111。11111。都是匹配的结果，
            string regStr = ".+?。";    //结果1111。   因为.+?表示终结贪婪模式，只能提取到1，但是后面还有个句号，所以只能再向后rvfp3wh1，找到句号就不再提取了。
            Match match = Regex.Match(str, regStr);
            Console.WriteLine(match.Value);  //1111。 1    1。    111。   11111。  结果
            Console.ReadLine();
        }
    }
}
