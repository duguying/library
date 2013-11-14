using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.DAL
{
    public class DAL
    {
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

        public void findUser()
        { }
    }
}
