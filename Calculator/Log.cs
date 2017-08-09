using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Web;


namespace Calculator
{
    public class Log
    {
        /// <summary>
        /// 写入日志文件
        /// </summary>
        /// <param name="input"></param>
        public static void WriteLogFile(string input)
        {
            ///指定日志文件的目录
            string fname = "F:\\" +
            DateTime.Now.Year + '-' +
            DateTime.Now.Month + '-' +
            DateTime.Now.Day + "_LogFile" + ".log";

            if (!File.Exists(fname))
            {
                //不存在文件
                File.Create(fname).Dispose();//创建该文件
            }

            /**/
            ///判断文件是否存在以及是否大于2K
            /* if (finfo.Length > 1024 * 1024 * 10)
            {
            /**/
            //文件超过10MB则重命名
            /* File.Move(fname, Directory.GetCurrentDirectory() + DateTime.Now.TimeOfDay + "\\LogFile.txt");
            //删除该文件
            //finfo.Delete();
            }*/

            using (StreamWriter log = new StreamWriter(fname, true))
            {
                //FileStream fs = new FileStream(url, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);FileMode.Append

                ///设置写数据流的起始位置为文件流的末尾
                log.BaseStream.Seek(0, SeekOrigin.End);

                ///写入“Log Entry : ”
               // log.Write("Log Entry : ");

                ///写入当前系统时间并换行
                log.Write("{0} \t", DateTime.Now.ToLongTimeString()
               /* DateTime.Now.ToLongDateString()*/);

                ///写入日志内容并换行
                log.Write(input + "\n");

                //清空缓冲区
                log.Flush();
                //关闭流
                log.Close();
            }
        }



        /// <summary>
        /// 将异常打印到LOG文件
        /// </summary>
        /// <param name="ex">异常</param>
        /// <param name="LogAddress">日志文件地址</param>
        public static void WriteLogTxt(Exception ex, string LogAddress = "")
        {
            //如果日志文件为空，则默认在Debug目录下新建 YYYY-mm-dd_Log.log文件
            if (LogAddress == "")
            {
                ///指定日志文件的目录
                LogAddress = "E:\\" +
                DateTime.Now.Year + '-' +
                DateTime.Now.Month + '-' +
                DateTime.Now.Day + "_Log.log";
            }

            FileInfo finfo = new FileInfo(LogAddress);

            if (!finfo.Exists)
            {
                FileStream fs;
                fs = File.Create(LogAddress);
                fs.Close();
                finfo = new FileInfo(LogAddress);
            }

            //把异常信息输出到文件
            StreamWriter sw = new StreamWriter(LogAddress, true);
            sw.WriteLine("当前时间：" + DateTime.Now.ToString());
            sw.WriteLine("异常信息：" + ex.Message);
            sw.WriteLine("异常对象：" + ex.Source);
            sw.WriteLine("调用堆栈：\n" + ex.StackTrace.Trim());
            sw.WriteLine("触发方法：" + ex.TargetSite);
            sw.WriteLine();
            sw.Close();
        }
    }
}

