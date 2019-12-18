using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using AnimalHouseBLL;
namespace AnimaleHouseModel
{
    public class AutomatikProductUpdate
    {
        IProdukt p;

        private string Path;
        private string ThisPath;

        public AutomatikProductUpdate(string path = @"\MedicinPriser")
        {
            ProduktFactory pF = ProduktFactory.GetInstance();
            p = pF.GetProduktC();
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
        public void Autorun()
        {
            while (true)
            {
                p.ProduktFromExtern(CheckForFiles());
            }
        }
        private List<string> CheckForFiles()
        {
            while (true)
            {
                if (Directory.GetFiles(ThisPath, "*.txt").Length != 0)
                {
                    List<string> Lines = new List<string>();
                    string[] files = Directory.GetFiles(ThisPath, "*.txt");
                    for (int i = 0; i < files.Length; i++)
                    {
                        Lines.AddRange(ReadFile(files[i]));
                    }
                    return Lines;

                }
                else
                {
                    // sleep for 1 minut
                    Thread.Sleep(60000);
                }
            }
        }

        private List<string> ReadFile(string pathfile)
        {


            string line;
            List<string> Lines = new List<string>();
            StreamReader file = new StreamReader(pathfile);
            while ((line = file.ReadLine()) != null)
            {
                Lines.Add(line);
            }

            file.Close();
            File.Delete(pathfile);
            return Lines;
        }


        public class ProduktFactory
        {
            private static ProduktFactory _instance = null;
            private ProduktFactory() { }
            public static ProduktFactory GetInstance()
            {
                if (_instance == null)
                {
                    _instance = new ProduktFactory();
                    return _instance;
                }
                else return _instance;
            }   
            public IProdukt GetProduktC()
            {
                return new ProductController();
            }
        }
    }
}
