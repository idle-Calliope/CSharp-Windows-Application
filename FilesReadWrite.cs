using System;
using System.IO;

/*
 *      1923636 --- ELLAINE FONTAMILLAS 
 */

namespace AfroMed
{
    class FilesReadWrite
    {
        private string folder;
        private string fileName;
        private string fullPath;

        public FilesReadWrite()
        {
            this.folder = @"C:\Users\Ella\Desktop\";
            this.fileName = "TXTFILE.txt";
            this.fullPath = null;
        }

        public FilesReadWrite(string folder, string filename, string fullpath)
        {
            this.folder = folder;
            this.fileName = filename;
            this.fullPath = fullpath;
        }

        public string Folder
        {
            get { return this.folder; }
            set { this.folder = value; }
        }

        public string Filename
        {
            get { return this.fileName; }
            set { this.fileName = value; }
        }

        public string Fullpath
        {
            get { return this.fullPath; }
            set { this.fullPath = value; }
        }

        public void ReadAndWrite(string texts)
        {
            fullPath = folder + fileName;

            string[] message = new string[] { texts };

            //File.WriteAllLines(fullPath, message);
            File.AppendAllText(fullPath, texts);

            //string readText = File.ReadAllText(fullPath);
            //Console.WriteLine(readText);
        }
    }
}
