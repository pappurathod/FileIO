using System;
using System.IO;
namespace TaskFileIO
{
    class Program
    {
        public string filePath = @"C:\Users\Pappu Rathod\source\repos\Temp.txt";
        public void FileReadAllText()
        {
            
            string testData = File.ReadAllText(filePath);
            Console.WriteLine(testData);
        }
        public void FileReadAllLines()
        {
            string[] testDataLineByLine = File.ReadAllLines(filePath);
            foreach(var item in testDataLineByLine)
            {
                Console.WriteLine(item);
            }
        }
        public void FileReadAllBytes()
        {
            byte[] testDataRawBytes = File.ReadAllBytes(filePath);
            foreach (var item in testDataRawBytes)
            {
                Console.Write(item);
            }
        }

        public void FileWriteAllText()
        {
            string data = "C# Corner MVP & Microsoft MVP;";
            File.WriteAllText(filePath, data);
        }
        public void FileWriteAllLines()
        {
            string[] data = { "MCT", "MCPD", "MCTS", "MCSD.NET", "MCAD.NET", "CSM" };
            File.WriteAllLines(filePath, data);    
        }
        public void FileAppendAllText()
        {
            string data = "Also Certified from IIT Kharagpur";
            File.AppendAllText(filePath, data);
        }
        public void FileAppendAllLines()
        {
            string[] otherData = { "Worked with Microsoft", "Lived in USA" };
            File.AppendAllLines(filePath, otherData);
        }
        public void FileCopy()
        {
            string destinationFilePath = @"C:\Users\Pappu Rathod\source\repos\Temp2.txt";
            bool overWrite = true;
            File.Copy(filePath, destinationFilePath, overWrite);
            Console.WriteLine("File Copy Successfully");
        }
        public void FileDelete()
        {
            string destinationFilePath = @"C:\Users\Pappu Rathod\source\repos\Temp2.txt";
            File.Delete(destinationFilePath);
        }
        public void FileExistorNot()
        {
            bool doesFileExist = File.Exists(filePath);
            Console.WriteLine(doesFileExist);
        }
        public void GetFileCreationTime()
        {
            DateTime fileCreatedOn = File.GetCreationTime(filePath);
            Console.WriteLine(fileCreatedOn);
        }
        public void FileInfo()
        {
            FileInfo fInfo = new FileInfo(filePath);
            Console.WriteLine(fInfo);
        }
        public void FileCopyTo()
        {
            string destinationFilePath = @"F:\Data.txt";
            bool overwrite = true;
            FileInfo fInfo = new FileInfo(filePath);
            fInfo.CopyTo(destinationFilePath, overwrite);
        }
        public void FileDeleteTo()
        {
            string sourceFilePath = @"F:\Data.txt";
            FileInfo fInfo = new FileInfo(sourceFilePath);
            fInfo.Delete();
        }
        public void DirectoryName()
        {
            string sourceFilePath = @"F:\Data.txt";
            FileInfo fInfo = new FileInfo(sourceFilePath);
            string directoryPath = fInfo.DirectoryName;
            Console.WriteLine(directoryPath);
            //returns F:\
        }
        public void FileExist()
        {
            FileInfo fInfo = new FileInfo(filePath);
            bool filesExists = fInfo.Exists;
            Console.WriteLine(filesExists);
        }
        public void FileExtension()
        {
            FileInfo fInfo = new FileInfo(filePath);
            string filesExtn = fInfo.Extension;
            Console.WriteLine("File Extension is : "+filesExtn);
        }
        public void FileLength()
        {
            FileInfo fInfo = new FileInfo(filePath);
            long length = fInfo.Length;
            Console.WriteLine("file length is : "+length);
        }
        public void CreateDirectory()
        {
            string sourceDirPath = @"F:\MyDir\";
            Directory.CreateDirectory(sourceDirPath);
        }
        public void DeleteDirectory()
        {
            string sourceDirPath = @"F:\MyDir\";
            bool deleteRecursively = true;
            Directory.Delete(sourceDirPath, deleteRecursively);
        }
        public void ExistDirectory()
        {
            string sourceDirPath = @"C:\MyData\Data";
            bool tempDataDirectoryExists = Directory.Exists(sourceDirPath);
            Console.WriteLine(tempDataDirectoryExists);
        }
        public void GetDirectory()
        {
            string sourceDirPath = @"C:\";
            string[] subDirectories = Directory.GetDirectories(sourceDirPath);
            foreach (string subDirectory in subDirectories)
            {
                Console.WriteLine(subDirectory);
            }
        }
        public void GetFiles()
        {
            string sourceDirPath = @"C:\Users\";
            string[] files = Directory.GetFiles(sourceDirPath);
            foreach(string file in files)
            {
                Console.WriteLine(file);
            }
        }
        public static void Main()
        {
            Program program = new Program();
            Console.WriteLine("select choice");
            int ch;
            do
            {
                Console.WriteLine("1 for FileReadAllText");
                Console.WriteLine("2 for FileReadAllLines");
                Console.WriteLine("3 for FileReadAllBytes");
                Console.WriteLine("4 for FileWriteAllText");
                Console.WriteLine("5 for FileWriteAllLines");
                Console.WriteLine("6 for FileAppendAllText");
                Console.WriteLine("7 for FileAppendAllLines");
                Console.WriteLine("8 for FileCopy");
                Console.WriteLine("9 for FileDelete");
                Console.WriteLine("10 for FileExistorNot");
                Console.WriteLine("11 for GetFileCreationTime");
                Console.WriteLine("12 for FileInfo");
                Console.WriteLine("13 for FileCopyTo");
                Console.WriteLine("14 for FileDeleteTo");
                Console.WriteLine("15 for DirectoryName");
                Console.WriteLine("16 for FileExist");
                Console.WriteLine("17 for FileExtension");
                Console.WriteLine("18 for FileLength");
                Console.WriteLine("19 for CreateDirectory");
                Console.WriteLine("20 for DeleteDirectory");
                Console.WriteLine("21 for ExistDirectory");
                Console.WriteLine("22 for GetDirectory");
                Console.WriteLine("23 for GetFiles");               
                Console.WriteLine("0 for Exit");

                ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        program.FileReadAllText();
                        break;
                    case 2:
                        program.FileReadAllLines();
                        break;
                    case 3:
                        program.FileReadAllBytes();
                        break;
                    case 4:
                        program.FileWriteAllText();
                        break;
                    case 5:
                        program.FileWriteAllLines();
                        break;
                    case 6:
                        program.FileAppendAllText();
                        break;
                    case 7:
                        program.FileAppendAllLines();
                        break;
                    case 8:
                        program.FileCopy();
                        break;
                    case 9:
                        program.FileDelete();
                        break;
                    case 10:
                        program.FileExistorNot();
                        break;
                    case 11:
                        program.GetFileCreationTime();
                        break;
                    case 12:
                        program.FileInfo();
                        break;
                    case 13:
                        program.FileCopyTo();
                        break;
                    case 14:
                        program.FileDeleteTo();
                        break;
                    case 15:
                        program.DirectoryName();
                        break;
                    case 16:
                        program.FileExist();
                        break;
                    case 17:
                        program.FileExtension();
                        break;
                    case 18:
                        program.FileLength();
                        break;
                    case 19:
                        program.CreateDirectory();
                        break;
                    case 20:
                        program.DeleteDirectory();
                        break;
                    case 21:
                        program.ExistDirectory();
                        break;
                    case 22:
                        program.GetDirectory();
                        break;
                    case 23:
                        program.GetFiles();
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Envalid choice");
                        break;
                }
            } while (ch != 0);
        }
    }
}