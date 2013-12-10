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

            Console.WriteLine("DAL.SqlHelper:测试数据库关闭...\n");
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
            rdt1.rdType=ReaderTypeDAL.Add(rdt1);

            string old_rdTypeName=rdt1.rdTypeName;
            rdt1.rdTypeName="管理员";
            Console.WriteLine("DAL.ReaderType:测试Update()...rdType由" + old_rdTypeName + "改为" + rdt1.rdTypeName + "\n");
            ReaderTypeDAL.Update(rdt1);
            #endregion

            #region DAL.Reader测试
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
            rd1.rdID=ReaderDAL.Add(rd1);

            string old_rdPassword = rd1.rdPassword;
            rd1.rdPassword = "密码";
            Console.WriteLine("DAL.Reader:测试Update()...rdPassword由" + old_rdPassword + "改为" + rd1.rdPassword + "\n");
            ReaderDAL.Update(rd1);
            #endregion

            #region DAL.Borrow测试
            Console.WriteLine("Model.Borrow:测试创建数据单元...");
            Borrow br1 = new Borrow();
            br1.borrowId = 1;
            br1.bkId = 1;
            br1.ldContinueTimes = 0;
            br1.ldDateOut = DateTime.Now.ToString();
            br1.ldDateRetPlan = DateTime.Now.ToString();
            br1.ldDateRetAct = DateTime.Now.ToString();
            br1.ldOverDay = 12;
            br1.ldOverMoney = 1.2f;
            br1.IsHasReturn = false;
            br1.OperatorLendId = 1;
            br1.OperatorRetId = 0;

            Console.WriteLine("DAL.Borrow:测试Delete()...");
            BorrowDAL.Delete(br1);

            Console.WriteLine("DAL.Borrow:测试Add()...");
            br1.borrowId = (decimal)BorrowDAL.Add(br1);

            float old_ldPunishMoney = br1.ldPunishMoney;
            br1.ldPunishMoney = 2.4f;
            Console.WriteLine("DAL.Borrow:测试Update()...ldPunishMoney由" + old_ldPunishMoney + "改为" + br1.ldPunishMoney + "\n");
            BorrowDAL.Update(br1);
            #endregion

            #region DAL.Book测试
            Console.WriteLine("Model.Book:测试创建数据单元...");
            Book bk1 = new Book();
            bk1.bkId = 1;
            bk1.bkCode = "1234";
            bk1.bkName = "测试书籍";
            bk1.bkAuthor = "作者";
            bk1.bkPress = "出版社";
            bk1.bkDatePress = DateTime.Now.ToString();
            bk1.bkISBN = "92520111234";
            bk1.bkCatalog = "计算机科学";
            bk1.bkLanguage = 0;
            bk1.bkPages = 300;
            bk1.bkPrice = 30.5f;
            bk1.bkDateIn = DateTime.Now.ToString();
            bk1.bkBrief = "Go语言基础教程";
            bk1.bkCover = Encoding.Default.GetBytes("test");
            bk1.bkStatus = "在馆";

            Console.WriteLine("DAL.Book:测试Delete()...");
            BookDAL.Delete(bk1);

            Console.WriteLine("DAL.Book:测试Add()...");
            bk1.bkId=BookDAL.Add(bk1);

            string old_bkName = bk1.bkName;
            bk1.bkName = "Go语言云动力";
            Console.WriteLine("DAL.Book:测试Update()...bkName由" + old_bkName + "改为" + bk1.bkName + "\n");
            BookDAL.Update(bk1);
            #endregion

            #region DAL.Admin测试
            Console.WriteLine("Model.Admin:测试创建数据单元...");
            Admin ad1 = new Admin();
            ad1.adminId = 1;
            ad1.adminUsername = "1234";
            ad1.adminPassword = "测试书籍";
            ad1.adminEmail = "作者";
            ad1.adminLastLoginDate = DateTime.Now.ToString();

            Console.WriteLine("DAL.Admin:测试Delete()...");
            AdminDAL.Delete(ad1);

            Console.WriteLine("DAL.Admin:测试Add()...");
            ad1.adminId=AdminDAL.Add(ad1);

            string old_adminPassword = ad1.adminPassword;
            ad1.adminPassword = "guanliyuanyonghu@mi~ma";
            Console.WriteLine("DAL.Admin:测试Update()...bkName由" + old_adminPassword + "改为" + ad1.adminPassword+"\n");
            AdminDAL.Update(ad1);
            #endregion

            #region 测试数据清理
            ReaderTypeDAL.Delete(rdt1);
            Console.WriteLine("ReaderType:数据已清理");
            ReaderDAL.Delete(rd1);
            Console.WriteLine("Reader:数据已清理");
            BorrowDAL.Delete(br1);
            Console.WriteLine("Borrow:数据已清理");
            BookDAL.Delete(bk1);
            Console.WriteLine("Book:数据已清理");
            AdminDAL.Delete(ad1);
            Console.WriteLine("Admin:数据已清理\n");
            #endregion
            
        }
    }
}
