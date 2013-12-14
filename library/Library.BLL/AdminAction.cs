using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.DAL;
using Library.Model;

namespace Library.BLL
{
    public class AdminAction
    {
        /// <summary>
        /// 管理员登录验证
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>验证成功true</returns>
        public static bool AdminLogin(string username, string password) {
            bool login_result = false;

            username = username.Trim();
            password = password.Trim();

            Admin rstobj = AdminDAL.getAdminByUsername(username);
            
            if (rstobj == null)
            {
                login_result = false;
            }
            else {
                string rstpwd = rstobj.adminPassword;
                if (rstpwd == password)
                {
                    login_result = true;
                }
            }
            
            return login_result;
        }

        public static int ChangePWD(string username, string oldpwd, string newpwd) {
            string sql = @"declare @pwd nchar(50)
set @pwd=(select adminPassword from TB_Admin where adminUsername='"+username+@"')
select @pwd
if(@pwd='"+oldpwd+@"')
	update TB_Admin set adminPassword='"+newpwd+@"'
	where adminUsername='"+username+@"'
else
	RAISERROR ('原密码错误',16,1);";
            return SqlHelper.ExecuteNonQuery(sql);
            
        }
    }
}
