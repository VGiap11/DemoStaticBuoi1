using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStaticBuoi1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int r = null;
            //string q = null;
            //var name = new HashSet<string>();
            //name.Add(People.name);
            //name.Add(People.description);

            //foreach (var item in name)
            //{
            //    Console.WriteLine(item);
            //}

            List<Student> students = new List<Student>();
            var lstStudent = new List<Student>();
            students.Add(new Student()
            {
                Id = 1,
                Name = "Giap",
                Age = 1,
                Description = "abfbqwoifoi"

            });
            students.Add(new Student()
            {
                Id = 2,
                Name = "Giapvv",
                Age = 13,
                Description = "abfbqwoifoi"
            });
            students.Add(new Student()
            {
                Id = 3,
                Name = "Giapvv1",
                Age = 14,
                Description = "abfbqwoifoi"
            });
            students.Add(new Student()
            {
                Id = 4,
                Name = "Giapvv2",
                Age = 15,
                Description = "abfbqwoifoi"
            });

            // query syntax
            var s = from student in students
                    where student.Age >= 12
                    select student.Name;
            // method Syntax
            var d = students.Where(x => x.Age >= 12).Select(x=>x.Name).ToList();

            //mixed Syntax
            var b = (from student in students where student.Age >= 12 select student.Age).ToList();

           // Console.WriteLine(b);
            foreach (var student in d)
            {
                Console.WriteLine(student);
            }

            //foreach (var item in students)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //string path = @"C:\Users\ADMIN\source\repos\DemoStaticBuoi1\DemoStaticBuoi1\FIle\Demo.txt";

            ////neu file da ton tai thi xoa khoi thu muc
            //if (File.Exists(path))
            //{
            //    File.Delete(path);
            //}
            //// ghi vaof file
            //using (FileStream fs = File.Create(path))
            //{
            //    AddTextToFile(fs, "Hello");
            //    AddTextToFile(fs, "oiehgoiewngiewngikn");
            //    AddTextToFile(fs, "owiehgoiwgoien");
            //}

            //if (File.Exists(path))
            //{
            //    //using(FileStream fs = File.OpenRead(path))
            //    //{
            //    //    byte[] buffer = new byte[1024];
            //    //    UTF8Encoding uTF8Encoding = new UTF8Encoding(true);
            //    //    while(fs.Read(buffer, 0 , buffer.Length) > 0)
            //    //    {
            //    //        Console.WriteLine(uTF8Encoding.GetString(buffer));
            //    //    }
            //    //}
            //    using(TextReader reader = File.OpenText(path)) {
            //        Console.WriteLine(reader.ReadToEnd());
            //    }
            //}
            //Specify the directory which we want to manipulate

            //string sourcedir = @"D: \FPoly";

            //string targetdir = @"D: \Test";

            //DirectoryInfo sdi = new DirectoryInfo(sourcedir);

            //DirectoryInfo tdi = new DirectoryInfo(targetdir);

            //// Check if target directory exists, if not, create it

            //if (!tdi.Exists)

            //{

            //    tdi.Create();

            //}
            //    // Copy each file into it's new directory.

            //    foreach (FileInfo fi in sdi.GetFiles())
            //    {
            //        fi.CopyTo(Path.Combine(tdi.ToString(), fi.Name), true);

            //        Console.WriteLine(@"Copying {0}\{1})", tdi.FullName, fi.Name);
            //    }

            //// Copy each subdirectory and it's files

            //foreach (DirectoryInfo sourceSubDir in sdi.GetDirectories())
            //{

            //    DirectoryInfo targetSubDir =

            //    tdi.CreateSubdirectory(sourceSubDir.Name);

            //    // Copy each file into it's new directory.

            //    foreach (FileInfo fi in sourceSubDir.GetFiles())

            //    {

            //        fi.CopyTo(Path.Combine(targetSubDir.ToString(), fi.Name), true);

            //        Console.WriteLine(@"Copying {0}\{1})", targetSubDir.FullName, fi.Name);

            //    }

            //}




            Console.ReadKey();
        }
        //public static void AddTextToFile(FileStream fileStream, string text)
        //{
        //    byte[] buffer = new UTF8Encoding(true).GetBytes(text);
        //    fileStream.Write(buffer, 0, buffer.Length);
        //}
    }
}
