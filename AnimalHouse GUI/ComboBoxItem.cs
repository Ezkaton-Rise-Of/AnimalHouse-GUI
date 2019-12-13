using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_GUI
{
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public Object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }

    }
}
