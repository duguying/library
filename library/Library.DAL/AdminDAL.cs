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
        /// <returns>返回当前插入的记录的ID</returns>
        public static int Add(Admin admin_record)
        {
            int rows = 0;

            #region SQL 语句准备
            string sql = @"insert into TB_Admin(
adminUsername,
adminPassword,
adminEmail,
adminLastLoginDate
)values(
@adminUsername,
@adminPassword,
@adminEmail,
@adminLastLoginDate
)";
            SqlParameter[] parameters = { 
                                            new SqlParameter("@adminUsername",admin_record.adminUsername),
                                            new SqlParameter("@adminPassword",admin_record.adminPassword),
                                            new SqlParameter("@adminEmail",admin_record.adminEmail),
                                            new SqlParameter("@adminLastLoginDate",admin_record.adminLastLoginDate),
                                        };
            
            
            string sqlGetId = @"select adminId from TB_Admin where
adminUsername=@adminUsername and
adminPassword=@adminPassword and
adminEmail=@adminEmail and
adminLastLoginDate=@adminLastLoginDate
";
            //获取当前插入项的ID
            SqlParameter[] parameters1 = { 
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

            if (rows > 0)
            {
                try
                {
                    rows = (int)SqlHelper.ExecuteScalar(sqlGetId, parameters1);
                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message);
                }
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

        #region 扩展操作
        Admin getAdminByUsername(string username) {
            object r=SqlHelper.ExecuteScalar("select * from TB_Admin where adminUsername='lijun'");
            return null;
        }
        #endregion
    }
}
