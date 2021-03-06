﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public class Tools
    {
        /// <summary>
        /// 从PictureBox获取图片转为byte[]
        /// </summary>
        /// <param name="pb"></param>
        /// <returns></returns>
        public static byte[] GetBytesByImage(PictureBox pb)
        {
            byte[] photo_byte = null;

            if (!pb.Image.Equals(null))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    Bitmap bmp = new Bitmap(pb.Image);
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    photo_byte = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photo_byte, 0, Convert.ToInt32(ms.Length));
                    bmp.Dispose();
                }
            }

            return photo_byte;
        }
        /// <summary>
        /// 从路径获取图片转为byte[]
        /// </summary>
        /// <param name="strFile"></param>
        /// <returns></returns>
        public static byte[] GetBytesByImagePath(string strFile)
        {
            byte[] photo_byte = null;
            using (FileStream fs = new FileStream(strFile, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    photo_byte = br.ReadBytes((int)fs.Length);
                }
            }

            return photo_byte;
        }
        /// <summary>
        /// 将byte[]转为图片
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static Image GetImageByBytes(byte[] bytes)
        {
            Image photo = null;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                ms.Write(bytes, 0, bytes.Length);
                photo = Image.FromStream(ms, true);
            }

            return photo;
        }
        public static bool CheckBookCodeExist(string code) {
            bool rst = false;

            return rst;
        }
    }
}
