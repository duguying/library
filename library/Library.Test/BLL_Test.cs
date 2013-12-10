using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Model;
using Library.BLL;

namespace Library.Test
{
    class BLL_Test
    {
        public static void run()
        {
            #region AdminAction
            Console.WriteLine("测试AdminAction.AdminLogin...");
            string u1 = "lijun", p1 = "lijun";
            Console.WriteLine("用户名："+u1+"密码："+p1);
            if (AdminAction.AdminLogin(u1, p1))
            {
                Console.WriteLine("登陆成功\n");
            }
            else {
                Console.WriteLine("登陆失败\n");
            }

            Console.WriteLine("测试AdminAction.AdminLogin...");
            string u2 = "lijun", p2 = "error";
            Console.WriteLine("用户名：" + u2 + "密码：" + p2);
            if (AdminAction.AdminLogin(u2, p2))
            {
                Console.WriteLine("登陆成功\n");
            }
            else
            {
                Console.WriteLine("登陆失败\n");
            }
            #endregion
        }
    }
}
