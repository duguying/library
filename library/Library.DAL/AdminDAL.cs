using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Library.Model;

namespace Library.DAL
{
    [Serializable]
    public class AdminDAL
    {
        #region 表基本操作
        /// <summary>
        /// 添加管理员
        /// </summary>
        /// <param name="admin_record"></param>
        /// <returns></returns>
        public static int Add(Admin admin_record)
        {
            int rows = 0;

            #region SQL 语句准备
            string sql = @"insert into TB_Admin(
adminId,
adminUsername,
adminPassword,
adminEmail,
adminLastLoginDate
)values(
@adminId,
@adminUsername,
@adminPassword,
@adminEmail,
@adminLastLoginDate
)";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@adminId",admin_record.adminId),
                                            new SqlParameter("@adminUsername",admin_record.adminUsername),
                                            new SqlParameter("@adminPassword",admin_record.adminPassword),
                                            new SqlParameter("@adminEmail",admin_record.adminEmail),
                                            new SqlParameter("@adminLastLoginDate",admin_record.adminLastLoginDate),
                                        };
            #endregion

            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }

            return rows;
        }
        /// <summary>
        /// 删除管理员
        /// </summary>
        /// <param name="admin_record"></param>
        /// <returns></returns>
        public static int Delete(Admin admin_record)
        {
            int rows = 0;

            #region SQL 语句准备
            string sql = @"delete from TB_Admin where adminId=@adminId";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@adminId",admin_record.adminId),
                                        };
            #endregion

            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }

            return rows;
        }
        /// <summary>
        /// 修改管理员
        /// </summary>
        /// <param name="admin_record"></param>
        /// <returns></returns>
        public static int Update(Admin admin_record)
        {
            int rows = 0;

            #region SQL 语句准备
            string sql = @"update TB_Admin set
adminUsername=@adminUsername,
adminPassword=@adminPassword,
adminEmail=@adminEmail,
adminLastLoginDate=@adminLastLoginDate
where adminId=@adminId
";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@adminId",admin_record.adminId),
                                            new SqlParameter("@adminUsername",admin_record.adminUsername),
                                            new SqlParameter("@adminPassword",admin_record.adminPassword),
                                            new SqlParameter("@adminEmail",admin_record.adminEmail),
                                            new SqlParameter("@adminLastLoginDate",admin_record.adminLastLoginDate),
                                        };
            #endregion

            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }

            return rows;
        }
        #endregion

    }
}
