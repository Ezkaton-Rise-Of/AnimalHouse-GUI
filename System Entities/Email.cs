using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class Email
    {
        public int EmailId { get; set; }
        public int DyrId { get; set; }
        public string Title { get; set; }
        public string Indhold { get; set; }
        public DateTime Dato { get; set; }
        public string ModtagerEmail { get; set; }
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
