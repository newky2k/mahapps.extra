using MahApps.Extra.Data;
using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            Uri oUri = new Uri("pack://application:,,,/" + "WpfApplication1" + "; component/" + "Assets/box.png", UriKind.RelativeOrAbsolute);


            var rsNanme = "WpfApplication1.Assets.box.png";
            var asm = this.GetType().Assembly.GetManifestResourceStream(rsNanme);

            var its = new List<AccordionMenuItem>()
            {
                new AccordionMenuItem() {Title = "Menu Item 1", Icon =  BitmapFrame.Create(asm) },
                 new AccordionMenuItem() {Title = "Menu Item 2", Icon =  BitmapFrame.Create(asm) },

            };

            lstView.ItemsSource = its;


            var its2 = new List<AccordionMenuItem>()
            {
                new AccordionMenuItem() {Title = "Menu Item 1", Icon =  BitmapFrame.Create(asm) },
                 new AccordionMenuItem() {Title = "Menu Item 2", Icon =  BitmapFrame.Create(asm) },

            };

            lstDide.Items = its2;

        }
    }


}
