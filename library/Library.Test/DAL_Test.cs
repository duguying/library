using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.DAL;

namespace Library.Test
{
    class DAL_Test
    {
        public static void run()
        {
            ConnectDataBase();
        }
        public static void ConnectDataBase() {
            Console.WriteLine("SqlHelper:正在测试数据库连接...");
            SqlHelper.OpenConn();
            Console.WriteLine("SqlHelper:正在测试数据库关闭...");
            SqlHelper.CloseConn();
        }
    }
}
