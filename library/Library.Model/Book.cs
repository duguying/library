using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Model
{
    [Serializable]
    public class Book
    {
        public Book() { }

        private string _bkCode="";
        private string _bkName = "";
        private string _bkAuthor = "";
        private string _bkPress = "";
        private string _bkISBN = "";
        private string _bkCatalog = "";
        private string _bkBrief = "";
        private string _bkStatus = "";

        #region Book表
        public int bkId { get; set; }//书籍ID
        public string bkCode { get { return _bkCode; } set { _bkCode = value.Trim(); } }//条码
        public string bkName { get { return _bkName; } set { _bkName = value.Trim(); } }//书名
        public string bkAuthor { get { return _bkAuthor; } set { _bkAuthor = value.Trim(); } }//作者
        public string bkPress { get { return _bkPress; } set { _bkPress = value.Trim(); } }//出版社
        public DateTime bkDatePress { get; set; }//出版时间
        public string bkISBN { get { return _bkISBN; } set { _bkISBN = value.Trim(); } }//ISBN
        public string bkCatalog { get { return _bkCatalog; } set { _bkCatalog = value.Trim(); } }//分类
        public int bkLanguage { get; set; }//书籍语种 : 语言，0-中文，1-英文，2-日文，3-俄文，4-德文，5-法文

        public int bkPages { get; set; }//页数
        public float bkPrice { get; set; }//价格
        public DateTime bkDateIn { get; set; }//入馆日期
        public string bkBrief { get { return _bkBrief; } set { _bkBrief = value.Trim(); } }//简介
        public byte[] bkCover { get; set; }//封面图片
        public string bkStatus { get { return _bkStatus; } set { _bkStatus = value.Trim(); } }//在馆状态
        #endregion
    }
}
