using System;
using System.CodeDom.Compiler;
using System.IO;

namespace FeedBackSystem
{
    static class TempFileHandler
    {
        private static string _directory;
        private static TempFileCollection _collection;

        static TempFileHandler()
        {
            Directory.CreateDirectory(Path.GetTempPath() + @"FeedBackSystem\");
            _directory = Path.GetTempPath()+@"FeedBackSystem\";
            _collection = new TempFileCollection(_directory,false);
        }

        //Cleans everything in the temp file (Run on startup only to ensure no files are being in used)
        public static void CleanTempFile()
        {
            Array.ForEach(Directory.GetFiles(_directory), File.Delete);
        }

        //Clean the current session temp files (May skip some files due to it being used by a process)
        public static void CleanTempSession()
        {
           _collection.Delete();
        }

        //Make a temp file and return the path
        public static string MakeTempFile(byte[] fileBytes)
        {
            string tempfile = _directory + Path.GetRandomFileName();
            _collection.AddFile(tempfile,false);
            File.WriteAllBytes(tempfile, fileBytes);
            return tempfile;
        }

        //Use this to make a PDF file to attach to the email. 
        public static string MakeTempFilePdf(byte[] fileBytes,string fileName)
        {
            string filePath = _directory + fileName + ".pdf";
            File.WriteAllBytes(filePath, fileBytes);
            _collection.AddFile(filePath, false);
            return filePath;
        }
    }
}
