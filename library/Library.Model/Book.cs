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

        #region Book表
        public int bkId { get; set; }//书籍ID
        public string bkCode { get; set; }//条码
        public string bkName { get; set; }//书名
        public string bkAuthor { get; set; }//作者
        public string bkPress { get; set; }//出版社
        public string bkDatePress { get; set; }//出版时间
        public string bkISBN { get; set; }//ISBN
        public string bkCatalog { get; set; }//分类
        public int bkLanguage { get; set; }//书籍语种 : 语言，0-中文，1-英文，2-日文，3-俄文，4-德文，5-法文

        public int bkPages { get; set; }//页数
        public float bkPrice { get; set; }//价格
        public string bkDateIn { get; set; }//入馆日期
        public string bkBrief { get; set; }//简介
        public byte[] bkCover { get; set; }//封面图片
        public string bkStatus { get; set; }//在馆状态
        #endregion
    }
}
