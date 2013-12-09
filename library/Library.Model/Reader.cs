using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Model
{
    [Serializable]
    class Reader
    {
        public Reader() { }

        #region 读者表
        public int rdID { get; set; }//读者编号，借书证号
        public string rdUsername { get; set; }//读者用户名
        public string rdPassword { get; set; }//读者密码
        public string rdName { get; set; }//读者姓名
        public string rdSex { get; set; }//读者性别
        public int rdType { get; set; }//读者类别
        public string rdDept { get; set; }//单位代码/单位名称
        public string rdPhone { get; set; }//读者电话
        public string rdEmail { get; set; }//读者邮箱
        public string rdDateReg { get; set; }//读者注册时间
        public byte[] rdPhoto { get; set; }//读者照片
        public string rdStatus { get; set; }//证件状态
        public int rdHaveBorrowNum { get; set; }//已借书数量
        #endregion
    }
}
