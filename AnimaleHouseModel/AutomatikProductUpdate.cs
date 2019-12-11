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
 
       public AutomatikProductUpdate(string path = @"\MedicinPriser")
        {

            this.Path = path;
            this.ThisPath = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + path;

            if (!Directory.Exists(ThisPath))
            {
                Directory.CreateDirectory(ThisPath);
            }
        }

        public void CheckForFiles()
        {
            //
            if(Directory.GetFiles(ThisPath, "*.txt").Length != 0){

                string[] files = Directory.GetFiles(ThisPath, "*.txt");

                for (int i = 0; i < files.Length; i++)
                {
                    
                }
            }
            else
            {
                // sleep for 1 minut
                Thread.Sleep(60000);
            }
        }       
        


    }
}
