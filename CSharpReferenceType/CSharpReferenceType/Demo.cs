using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReferenceType
{
    class Demo
    {
        static void Main(string[] args)
        {
            //三种引用类型，object,string,dynamic
            // System.Object, System.String， System.Dynamic
            //声明一个object类型
            object o = new object();
            object b = new Object();
           //常用的方法
            Console.WriteLine(o.GetType());
            Console.WriteLine(o.ToString());  

            //string字符串
            string a = "ChallengerCY";
            string c = "Challenger";
            c += "CY";
            Console.WriteLine(a);
            Console.WriteLine(c);
            //判断俩个字符串是否相等,俩个字符串的值是相等的，但是引用存放的位置不一样
            Console.WriteLine(a == c);
            Console.WriteLine((object)a == (object)c);
            //获取字符串某一位的值
            char d = c[3];
            Console.WriteLine(d);
            //字符串中的每个字符可以是Unicode
            string u = "\\\u0066\n";
            Console.WriteLine(u); 
            //原样字符串
            string s = @"challenger'CY'";
            Console.WriteLine(s);
            //查找一个字符串是否存于另一个字符串 使用Constain
            Console.WriteLine(s.Contains("c"));
            //字符串的长度
            Console.WriteLine(s.Length);
            //索引字符串并且返回他的位置
            Console.WriteLine(s.IndexOf("all"));
            //如果需要对字符串进行多次修改，需要使用stringBulider
            StringBuilder bulider = new StringBuilder();
            //追加字符串
            bulider.Append("c");
            bulider.Append("y");
            Console.WriteLine(bulider);
            //占位操作格式化字符串
            bulider.AppendFormat(" Hello {0}", "CY");
            Console.ReadLine();
        }
    }
}
