using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahApps.Extra.Data
{
    public class AcordionGroup
    {
        public string Name { get; set; }

        public List<AccordionMenuItem> Items { get; set; }

        public AcordionGroup()
        {
            Items = new List<AccordionMenuItem>();
        }

        public AcordionGroup(params AccordionMenuItem[] items)
        {
            Items.AddRange(items);
        }
    }
}
