using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Classes
{
    class FileHandler
    {
        public FileHandler()
        {
            // Initialization code goes here
        }

        public void addLog()
        {
            string filePath =
                @"D:\Libraries\Google Drive\School\2020 (Second Year)\PRG 282\Assignments\Project\Project\Project\Air-Attack-Sim\Program\sim-log.txt";
            FileStream stream = new FileStream(filePath, FileMode.Append);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLineAsync("Sim ran on " + DateTime.Now.ToString());
            writer.Close();
            stream.Close();
        }
    }
}
