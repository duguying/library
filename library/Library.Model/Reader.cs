using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Model
{
    [Serializable]
    public class Reader
    {
        public Reader() { }

        private string _rdUsername;
        private string _rdPassword;
        private string _rdName;
        private string _rdSex;
        private string _rdDept;
        private string _rdPhone;
        private string _rdEmail;
        private string _rdStatus;


        #region 读者表
        public int rdID { get; set; }//读者编号，借书证号
        public string rdUsername { get { return _rdUsername; } set { _rdUsername = value.Trim(); } }//读者用户名
        public string rdPassword { get { return _rdPassword; } set { _rdPassword = value.Trim(); } }//读者密码
        public string rdName { get { return _rdName; } set { _rdName = value.Trim(); } }//读者姓名
        public string rdSex { get { return _rdSex; } set { _rdSex = value.Trim(); } }//读者性别
        public int rdType { get; set; }//读者类别
        public string rdDept { get { return _rdDept; } set { _rdDept = value.Trim(); } }//单位代码/单位名称
        public string rdPhone { get { return _rdPhone; } set { _rdPhone = value.Trim(); } }//读者电话
        public string rdEmail { get { return _rdEmail; } set { _rdEmail = value.Trim(); } }//读者邮箱
        public DateTime rdDateReg { get; set; }//读者注册时间
        public byte[] rdPhoto { get; set; }//读者照片
        public string rdStatus { get { return _rdStatus; } set { _rdStatus = value.Trim(); } }//证件状态
        public int rdHaveBorrowNum { get; set; }//已借书数量
        #endregion
    }
}
