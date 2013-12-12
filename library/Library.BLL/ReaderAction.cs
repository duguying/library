using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Library.Model;
using Library.DAL;

namespace Library.BLL
{
    public class ReaderAction
    {
        /// <summary>
        /// 根据用户名获取用户
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static DataTable getUserByUsername(string username) {
            #region SQL 语句准备
            string sql = @"select 
rdId as 读者ID,
rdUsername as 用户名,
rdName as 姓名,
rdSex as 性别,
rdType as 类型,
rdDept as 部门,
rdPhone as 电话,
rdEmail as 邮箱,
rdDateReg as 注册时间,
rdStatus as 用户状态,
rdHaveBorrowNum as 已借书数目
    from TB_Reader where
rdUsername like '%'+@rdUsername+'%'
";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@rdUsername",username),
                                        };
            #endregion
            DataTable tmpTable;
            try
            {
                tmpTable = SqlHelper.GetDataTable(sql, parameters, "tmpTable");
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            return tmpTable;
        }
        /// <summary>
        /// 根据姓名获取用户
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataTable getUserByName(string name) {
            #region SQL 语句准备
            string sql = @"select 
rdId as 读者ID,
rdUsername as 用户名,
rdName as 姓名,
rdSex as 性别,
rdType as 类型,
rdDept as 部门,
rdPhone as 电话,
rdEmail as 邮箱,
rdDateReg as 注册时间,
rdStatus as 用户状态,
rdHaveBorrowNum as 已借书数目
    from TB_Reader where
rdName like '%'+@rdName+'%'
";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@rdName",name),
                                        };
            #endregion
            DataTable tmpTable;
            try
            {
                tmpTable = SqlHelper.GetDataTable(sql, parameters, "tmpTable");
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            return tmpTable;
        }
    }
}
