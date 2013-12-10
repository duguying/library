using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("项目单元测试开始...\n");
            //DAL测试
            DAL_Test.run();
            
            Console.WriteLine("单元测试结束，Press Any Key To Finish!\n");
            Console.ReadKey();
        }
    }
}
