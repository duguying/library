using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SQLHelper;
using System.Security.Cryptography;


namespace Library.DAL
{
    public class DAL
    {
        public static void testConn()
        {
            SQLHelper.SQLHelper.DataAdapter("select * from dbo.book", SQLHelper.SQLHelper.SDACmd.select, "dbo.book", null);
        }
        /// <summary>
        /// 查找书籍
        /// </summary>
        /// <param name="bookname">按书籍名称模糊查找</param>
        /// <param name="id">按书籍id精确查找</param>
        /// <param name="author">按作者名称模糊查找</param>
        /// <param name="keywords">按关键词模糊查找</param>
        public void findBook(string bookname, int id, string author, string keywords)
        {

        }

        /// <summary>
        /// 删除书籍
        /// </summary>
        /// <param name="id">按书籍ID精确删除</param>
        public void deleteBook(int id)
        {
        }

        /// <summary>
        /// 查找用户
        /// </summary>
        /// <param name="username">按用户名模糊查找</param>
        /// <param name="id">按ID精确查找</param>
        /// <returns>返回用户ID</returns>
        public static int findUser(string username, int id)
        {

            return id;
        }

        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码[未加密]</param>
        /// <returns></returns>
        public static bool login(string username, string password)
        {
            //password=System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5");
            DataSet ds;
            try
            {
                ds = SQLHelper.SQLHelper.DataAdapter("select * from [dbo].[user] where username='" + username + "'", SQLHelper.SQLHelper.SDACmd.select, "[dbo].[user]", null);
            }
            catch (Exception)
            {
                ds = null;
                return false;
            }

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i][2].ToString().Replace(" ", "").Equals(password))
                {
                    string value = ds.Tables[0].Rows[i][1].ToString();
                    return true;
                }
            }
            return true;// false;
        }
    }
}
