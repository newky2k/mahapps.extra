using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MahApps.Extra.Data
{
    public class AccordionMenuItem
    {
        /// <summary>
        /// Gets or sets the icon path, can be overloaded
        /// </summary>
        /// <value>
        /// The icon path.
        /// </value>
        public virtual ImageSource Icon { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

    }
}
