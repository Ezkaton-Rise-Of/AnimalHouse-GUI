using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
namespace AnimaleHouseModel
{
    public class AutomatikProductUpdate
    {
        string Path;
        string ThisPath;
        public List<string> Line = new List<string>(); 
 
       public AutomatikProductUpdate(string path = @"\MedicinPriser")
        {

            this.Path = path;
            this.ThisPath = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + path;
            CheckforFolder();

        }

        private void CheckforFolder()
        {
            if (!Directory.Exists(ThisPath))
            {
                Directory.CreateDirectory(ThisPath);
            }
        }


        private void CheckForFiles()
        {
            //
            if(Directory.GetFiles(ThisPath, "*.txt").Length != 0){

                string[] files = Directory.GetFiles(ThisPath, "*.txt");
                for (int i = 0; i < files.Length; i++)
                {
                    ReadFile(files[i]);
                }  
            }
            else
            {
                // sleep for 1 minut
                Thread.Sleep(60000);
            }
        }       
        
        private void ReadFile(string pathfile)
        {

            
            string line;
            StreamReader file = new StreamReader(pathfile);
            while ((line = file.ReadLine()) != null)
            {
                Line.Add(line);
            }
            file.Close();
            
        }

        



    }
}
