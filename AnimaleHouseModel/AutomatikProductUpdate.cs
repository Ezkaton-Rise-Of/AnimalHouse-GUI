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
        private string TempPath;
        private int counter = 0;

        public AutomatikProductUpdate(string path = @"\MedicinPriser")
        {
            ProduktFactory pF = ProduktFactory.GetInstance();
            p = pF.GetProduktC();
            this.Path = path;

            // skaber stien hvor der skal ser efter filer 
            this.ThisPath = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + path;
            CheckforFolder();
        }
        //se om den ønskede mappe eksistere eller skabes den
        private void CheckforFolder()
        {
            if (!Directory.Exists(ThisPath))
            {
                Directory.CreateDirectory(ThisPath);
            }
        }

        //program start, køre "uendeligt" eller til form lukker
        public void Autorun()
        {
            while (true)
            {
                //hvis uploadet ikke er sket tilføres counter en så filen ikke bliver kørt igen før mainform åbener igen
                if(p.ProduktFromExtern(CheckForFiles()) == false)
                {
                    counter++;
                }
                File.Delete(TempPath);
            }
        }
        private List<string> CheckForFiles()
        {
            //køre til den finder nogle filer ellers holder den pause i 60 sekunder
            while (true)
            {
                // se som mappen har nogle txt filer
                if (Directory.GetFiles(ThisPath, "*.txt").Length != 0)
                {
                    return GetFilesConstentAndPath();

                }
                else
                {
                    // sleep for 1 minut
                    Thread.Sleep(60000);
                }
            }
        }
        private List<string> GetFilesConstentAndPath()
        {
            List<string> Lines = new List<string>();
            // skaber en array af filer der er fundes
            string[] files = Directory.GetFiles(ThisPath, "*.txt");
            // hvis counter er mindren en antal filer, bliver den næste fil læst
            if (counter < files.Length)
            {

                // tilføre produkt liner til lines
                    Lines.AddRange(ReadFile(files[counter]));
         
            }
            return Lines;
        }
        //læser filen og returner det som en liste af strings
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
            TempPath = pathfile;
            return Lines;
        }

        // skaber et singleton for at benytte interfaces til at sende med,
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