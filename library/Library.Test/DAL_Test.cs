using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Model;
using Library.DAL;

namespace Library.Test
{
    class DAL_Test
    {
        public static void run()
        {
            ConnectDataBase();
        }
        public static void ConnectDataBase()
        {
            #region DAL.ReaderType测试
            Console.WriteLine("DAL.SqlHelper:测试数据库连接...");
            SqlHelper.OpenConn();

            Console.WriteLine("DAL.SqlHelper:测试数据库关闭...");
            SqlHelper.CloseConn();

            Console.WriteLine("Model.ReaderType:测试创建数据单元...");
            ReaderType rdt1=new ReaderType();
            rdt1.rdType = 1;
            rdt1.rdTypeName = "admin";
            rdt1.maxBorrowDay = 30;
            rdt1.maxBorrowNum = 8;
            rdt1.maxContinueTimes = 1;

            Console.WriteLine("DAL.ReaderType:测试Delete()...");
            ReaderTypeDAL.Delete(rdt1);

            Console.WriteLine("DAL.ReaderType:测试Add()...");
            ReaderTypeDAL.Add(rdt1);

            string old_rdTypeName=rdt1.rdTypeName;
            rdt1.rdTypeName="管理员";
            Console.WriteLine("DAL.ReaderType:测试Update()...rdType由" + old_rdTypeName + "改为" + rdt1.rdTypeName);
            ReaderTypeDAL.Update(rdt1);

            ReaderTypeDAL.Delete(rdt1);
            Console.WriteLine("数据已清理");
            #endregion

            Console.WriteLine("Model.Reader:测试创建数据单元...");
            Reader rd1 = new Reader();
            rd1.rdID = 1;
            rd1.rdUsername = "lijun";
            rd1.rdPassword = "lijunpassword";
            rd1.rdName = "duguying";
            rd1.rdSex = "男";
            rd1.rdType = 1;
            rd1.rdDept = "计科院";
            rd1.rdPhone = "18900000000";
            rd1.rdEmail = "rex@duguying.net";
            rd1.rdDateReg = DateTime.Now.ToString();
            rd1.rdPhoto = Encoding.Default.GetBytes("test");
            rd1.rdStatus = "正常";
            rd1.rdHaveBorrowNum = 1;

            Console.WriteLine("DAL.Reader:测试Delete()...");
            ReaderDAL.Delete(rd1);

            Console.WriteLine("DAL.Reader:测试Add()...");
            ReaderDAL.Add(rd1);

            string old_rdPassword = rd1.rdPassword;
            rd1.rdPassword = "密码";
            Console.WriteLine("DAL.ReaderType:测试Update()...rdType由" + old_rdPassword + "改为" + rd1.rdPassword);
            Console.WriteLine("DAL.Reader:测试Update()...");
            ReaderDAL.Update(rd1);

            ReaderDAL.Delete(rd1);
            Console.WriteLine("数据已清理");
        }
    }
}
