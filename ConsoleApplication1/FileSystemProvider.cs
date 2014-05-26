using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Interpreter
{
    class FileSystemProvider
    {
        string FPath = "C:\\"; //поле для хранения текущего пути

        public void Dir()
        {
            //список директорий
            string[] dirs = Directory.GetDirectories(FPath);
            foreach (string s in dirs)
            {
                string dirname = Path.GetFileName(s);
                Console.WriteLine(dirname);
            }
        }
    }
}
