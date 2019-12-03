using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class Email
    {
        public int EmailId;
        public int DyrId;
        public string Title;
        public string Indhold;
        public DateTime Dato;
        public string ModtagerEmaiL;
        public Email()
        {
        }

        public Email(int dyrId, string title, string indhold)
        {
            DyrId = dyrId;
            Title = title;
            Indhold = indhold;
        }
    }
}
