using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.IO;
using static System.Net.WebRequestMethods;

namespace FILE_SYSTEMS
{
    class Program
    {
        static void Main(string[] args)
        {
            // string path = Path.Combine(@"C:\Users\ЛатыповА\Documents\Visual Studio 2015\Projects\FILE_SYSTEMS\FILE_SYSTEMS\bin\Debug\",   "AlfarFile3.txt");

            //  NewFile();
            //  NewFile2();
            // NewFile2();


            /*1. Написать программу, читающую побайтно заданный файл и подсчитывающую число появлений каждого из 256 возможных знаков.*/


            /*2. С помощью класса StreamWriter записать в текстовый файл свое имя, фамилию и возраст. Каждая запись должна начинаться с новой строки.*/

            //Команда создать файл
          FileInfo fi = new FileInfo(Console.ReadLine()); //= new FileInfo("FileT.txt"); //

            //FileStream fs = fi.Create();
            //fs.Close();


            //Console.WriteLine(fi.DirectoryName + "\n" +fi.Directory);

            //string path = Path.Combine(fi.DirectoryName, fi.Name); //

            //Console.WriteLine(path);

            //using (StreamWriter sw = new StreamWriter(path)) // открыли поток
            //{
            //    Console.WriteLine("Enter name : ");
            //    sw.Write(Console.ReadLine());

            //    Console.WriteLine("Enter Soname : ");
            //    sw.Write(Console.ReadLine());

            //    Console.WriteLine("Enter age : ");
            //    sw.Write(Console.ReadLine());

            //}


            /*3.Напишите программу на C # Sharp для создания пустого файла на диске, если тот же файл уже существует 
            (Expected Output : Файл, созданный с именем mytest.txt)*/


            //   M1(fi);



            /*4.	Напишите программу на C # Sharp, чтобы создать файл и добавить текст (Expected Output: Файл, созданный с именем содержимого mytest.txt)*/


            // APpendFile(fi);


            /*5.	Напишите программу на C # Sharp, чтобы создать файл с текстом и прочитать файл (Expected Output : Here is the content of the file mytest.txt :
           Hello and Welcome 
           It is the first content  
           of the text file mytest.txt */




        }

        /*3.Напишите программу на C # Sharp для создания пустого файла на диске, если тот же файл уже существует 
           (Expected Output : Файл, созданный с именем mytest.txt)*/
        //static void M1(FileInfo fi)
        //{
        //    if(!fi.Exists)
        //    {
        //        using (FileStream fs = fi.Create())
        //        {
        //            Console.WriteLine("File create sucsessfule");
        //        }
        //    }
        //}




        /*4.	Напишите программу на C # Sharp, чтобы создать файл и добавить текст (Expected Output: Файл, созданный с именем содержимого mytest.txt)*/
        static void APpendFile(FileInfo fi)
        {
            if (fi.Exists)
            {
                using (StreamWriter sw = fi.AppendText())
                {
                    GetInfo(sw);
                }
                   
            }
        }



        static void GetInfo(StreamWriter sw)
        {
            Console.WriteLine("Enter name : ");
            sw.Write(Console.ReadLine());

            Console.WriteLine("Enter Soname : ");
            sw.Write(Console.ReadLine());

            Console.WriteLine("Enter age : ");
            sw.Write(Console.ReadLine());

        }





        #region
        //static void NewFile()
        //{
        //    //создаем файл
        //    FileInfo file = new FileInfo(@"C:\Users\ЛатыповА\Documents\Visual Studio 2015\Projects\FILE_SYSTEMS\FILE_SYSTEMS\bin\Debug\AlfarFile.txt");
        //    FileStream fs = file.Create();

        //    fs.Close();

        //}

        //static void NewFile2()
        //{
        //    //создаем файл
        //    FileInfo file = new FileInfo(@"AlfarFile4.txt");

        //    using (FileStream fs = file.Open(FileMode.OpenOrCreate, FileAccess.Write))
        //    {
        //        using( StreamWriter sw = new StreamWriter (fs, System.Text.Encoding.Default))
        //        {
        //            sw.Write("Some text");
        //        }
        //    }


        //    FileStream fi = file.Open(FileMode.OpenOrCreate, FileAccess.Write);

        //        using (StreamWriter sw = new StreamWriter(fi, System.Text.Encoding.Default))
        //        {
        //            sw.Write("Some text");
        //        }

        //    fi.Close();

        //    CopyToFile(file);

        //}



        //static void NewFile3(FileInfo fi)
        //{
        //    fi.CopyTo(@"C:\NewCopy.txt");
        //}

        #endregion

    }



}
