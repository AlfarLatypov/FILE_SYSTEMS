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

            /*Программным путем:
            1.	В папке С:\temp создайте папки К1 и К2.
            2.	В папке К1:
            1.	создайте файл t1.txt, в который запишите следующий текст :
            Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов
            2.	создайте файл t2.txt, в который запишите следующий текст:
            Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс
            3.	В папке К2 создайте файл t3.txt, в который перепишите вначале текст из файла t1.txt, а затем из t2.txt
            4.	Выведите развернутую информацию о созданных файлах.
            5.	Файл t2.txt перенесите в папку K2.
            6.	Файл t1.txt скопируйте в папку K2.
            7.	Папку K2 переименуйте в ALL, а папку K1 удалите.
            8.	Вывести полную информацию о файлах папки All.
            */



            /* 1.В папке С:\temp создайте папки К1 и К2.*/

            Directory.CreateDirectory(@"C:\temp\K1");
            Directory.CreateDirectory(@"C:\temp\K2");


            /* 2.	В папке К1:
            1.	создайте файл t1.txt, в который запишите следующий текст :
            Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов*/

            FileInfo fi = new FileInfo(@"C:\temp\K1\t1.txt");  //открыли поток
            FileStream fstr = fi.Create(); //создайте файл t1.txt
            fstr.Close();



            StreamWriter sw = new StreamWriter(@"C:\temp\K1\t1.txt");
            sw.Write("Иванов Иван Иванович, 1965 года рождения, место жительства г.Саратов"); //запишите следующий текст
            sw.Close();

            /* 2.	создайте файл t2.txt, в который запишите следующий текст:
            Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс*/


            FileInfo fi2 = new FileInfo(@"C:\temp\K1\t2.txt");//открыли поток
            FileStream ffstr = fi2.Create(); //создайте файл t1.txt
            ffstr.Close();

            StreamWriter sw2 = new StreamWriter(@"C:\temp\K1\t2.txt");
            sw2.Write("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс"); //запишите следующий текст
            sw2.Close();


            /* 3. В папке К2 создайте файл t3.txt, в который перепишите вначале текст из файла t1.txt, а затем из t2.txt*/

            fi.CopyTo(@"C:\temp\K2\t3.txt");

            if (fi.Exists)
            {
                using (StreamWriter writer = new System.IO.StreamWriter(@"C:\temp\K2\t3.txt", true))
                {
                    writer.WriteLine();
                    writer.WriteLine("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
                }
            }

            /*4.Выведите развернутую информацию о созданных файлах.*/

            DirectoryInfo dinf = new DirectoryInfo(@"C:\temp\K2\t3.txt");
            FileInfo[] finf = dinf.GetFiles();
           // foreach (FileInfo fi in finf)
            {
                Console.WriteLine(fi.DirectoryName, fi.Name);
            }









            //    if (!Directory.Exists("c:\\temp"))
            //    {
            //        Directory.CreateDirectory("c:\\temp");
            //    }
            //    Directory.CreateDirectory("c:\\temp\\K1");
            //    Directory.CreateDirectory("c:\\temp\\K2");
            //    StreamWriter sw = new StreamWriter("c:\\temp\\K1\\t1.txt");
            //    sw.Write("Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
            //    sw.Close();
            //    sw = new StreamWriter("c:\\temp\\K1\\t2.txt");
            //    sw.Write("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
            //    sw.Close();
            //    sw = new StreamWriter("c:\\temp\\K2\\t3.txt");
            //    StreamReader sr = new StreamReader("c:\\temp\\K1\\t1.txt");
            //    sw.WriteLine(sr.ReadToEnd());
            //    sr.Close();
            //    sr = new StreamReader("c:\\temp\\K1\\t2.txt");
            //    sw.WriteLine(sr.ReadToEnd());
            //    sr.Close();
            //    sw.Close();
            //    File.Move("c:\\temp\\K1\\t2.txt", "c:\\temp\\K2\\t2.txt");
            //    File.Copy("c:\\temp\\K1\\t1.txt", "c:\\temp\\K2\\t1.txt");
            //    Directory.Move("c:\\temp\\K2", "c:\\temp\\ALL");
            //    Directory.Delete("c:\\temp\\K1", true);
            //    DirectoryInfo dinf = new DirectoryInfo("c:\\temp\\ALL");
            //    FileInfo[] finf = dinf.GetFiles();
            //    foreach (FileInfo fi in finf)
            //    {
            //        Console.WriteLine(fi.FullName.ToString() + fi.Attributes.ToString());//в скобках могут быть другая нужная тебе инфа
            //    }
            //}




            #region Classnaya

            // string path = Path.Combine(@"C:\Users\ЛатыповА\Documents\Visual Studio 2015\Projects\FILE_SYSTEMS\FILE_SYSTEMS\bin\Debug\",   "AlfarFile3.txt");

            //  NewFile();
            //  NewFile2();
            // NewFile2();


            /*1. Написать программу, читающую побайтно заданный файл и подсчитывающую число появлений каждого из 256 возможных знаков.*/


            /*2. С помощью класса StreamWriter записать в текстовый файл свое имя, фамилию и возраст. Каждая запись должна начинаться с новой строки.*/

            //Команда создать файл
            //    FileInfo fi = new FileInfo(Console.ReadLine()); //= new FileInfo("FileT.txt"); //

            //    //FileStream fs = fi.Create();
            //    //fs.Close();


            //    //Console.WriteLine(fi.DirectoryName + "\n" +fi.Directory);

            //    //string path = Path.Combine(fi.DirectoryName, fi.Name); //

            //    //Console.WriteLine(path);

            //    //using (StreamWriter sw = new StreamWriter(path)) // открыли поток
            //    //{
            //    //    Console.WriteLine("Enter name : ");
            //    //    sw.Write(Console.ReadLine());

            //    //    Console.WriteLine("Enter Soname : ");
            //    //    sw.Write(Console.ReadLine());

            //    //    Console.WriteLine("Enter age : ");
            //    //    sw.Write(Console.ReadLine());

            //    //}


            //    /*3.Напишите программу на C # Sharp для создания пустого файла на диске, если тот же файл уже существует 
            //    (Expected Output : Файл, созданный с именем mytest.txt)*/


            //    //   M1(fi);



            //    /*4.	Напишите программу на C # Sharp, чтобы создать файл и добавить текст (Expected Output: Файл, созданный с именем содержимого mytest.txt)*/


            //    // APpendFile(fi);


            //    /*5.	Напишите программу на C # Sharp, чтобы создать файл с текстом и прочитать файл (Expected Output : Here is the content of the file mytest.txt :
            //   Hello and Welcome 
            //   It is the first content  
            //   of the text file mytest.txt */




            //}

            ///*3.Напишите программу на C # Sharp для создания пустого файла на диске, если тот же файл уже существует 
            //   (Expected Output : Файл, созданный с именем mytest.txt)*/
            ////static void M1(FileInfo fi)
            ////{
            ////    if(!fi.Exists)
            ////    {
            ////        using (FileStream fs = fi.Create())
            ////        {
            ////            Console.WriteLine("File create sucsessfule");
            ////        }
            ////    }
            ////}




            ///*4.	Напишите программу на C # Sharp, чтобы создать файл и добавить текст (Expected Output: Файл, созданный с именем содержимого mytest.txt)*/
            //static void APpendFile(FileInfo fi)
            //{
            //    if (fi.Exists)
            //    {
            //        using (StreamWriter sw = fi.AppendText())
            //        {
            //            GetInfo(sw);
            //        }

            //    }
            //}



            //static void GetInfo(StreamWriter sw)
            //{
            //    Console.WriteLine("Enter name : ");
            //    sw.Write(Console.ReadLine());

            //    Console.WriteLine("Enter Soname : ");
            //    sw.Write(Console.ReadLine());

            //    Console.WriteLine("Enter age : ");
            //    sw.Write(Console.ReadLine());

            //}





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





            #endregion Classnaya
        }
    }



}
