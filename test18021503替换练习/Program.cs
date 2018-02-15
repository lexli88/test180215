using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test18021503替换练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //请用两种方法将msg中的多个空格替换成1个空格。
            //string msg = "    我   爱  北京  天安门   啊啊！   ";
            //string[] parts = msg.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //msg = string.Join(" ", parts);
            //Console.WriteLine(msg);

            //string msg = "    我   爱  北京  天安门   啊啊！   ";
            //msg = Regex.Replace(msg, @"\s+", " ");  //正则表达式中的替换方法  \s  空格  +  尽可能的匹配

            //Console.WriteLine(msg);

            ////练习8 将连续的-都替换成一个-
            //string msg = "234-----234-----34--55";
            //msg = Regex.Replace(msg,@"\-+","-");
            //Console.WriteLine(msg);
            //string msg = "234---234---34---55";
            //msg = Regex.Replace(msg, @"\-+", "-");
            //Console.WriteLine(msg);

            //例9 替换使用提取组
            //string msg = "山东地区中奖观众：13888888888，手机号为：13122221111，还有13233332222，还有磊家中奖观众18944441325.";
            //msg = Regex.Replace(msg, @"(\d{3})(\d{4})(\d{4})", "$1****$3");//$1  表示组1    $3表示组3
            //Console.WriteLine(msg);

            //msg = Regex.Replace(msg, @"(\d{3})(\d{4})(\d{4})", "$1****$3");
            //Console.WriteLine(msg);
            //例10 替换组练习 05/21/2010替换为2010/05/21
            //string msg = "我的生日是05/21/2010耶。TA的生日是06/07/2010";
            //msg = Regex.Replace(msg, @"(\d{1,2})/(\d{1,2})/(\d{4})", "$3-$1-$2");
            //Console.WriteLine(msg);
            string msg = "我的生日是05/21/2010耶。TA的生日是06/07/2010";
            msg = Regex.Replace(msg,@"(\d{1,2})/(\d{1,2})/(\d{4})","$3-$1-$2");
            Console.WriteLine(msg);
            Console.ReadLine();
        }
    }
}
