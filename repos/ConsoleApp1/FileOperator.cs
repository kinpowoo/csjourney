using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class FileOperator
    {

        /// <summary>
        /// 往文件中读文件
        /// </summary>
        /// <param name="str"></param>
        public static void ReadFromFile()
        {
            try
            {
                FileStream fs = new FileStream(@"F:\\data.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fs, false);
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
                fs.Close();
                sr.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(ex.ToString());
            }
        }


        /// <summary>
        /// 往文件中写文件
        /// </summary>
        /// <param name="str"></param>
        public static void WriteToFile(string str)
        {
            try
            {
                FileStream fs = new FileStream(@"F:\\data.txt", FileMode.OpenOrCreate, FileAccess.Write);
                //Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);

                char[] msg = str.ToCharArray();
                fs.Seek(0, SeekOrigin.End);

                byte[] byData = Encoding.UTF8.GetBytes(str);
                fs.Write(byData, 0, byData.Length);
                fs.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
