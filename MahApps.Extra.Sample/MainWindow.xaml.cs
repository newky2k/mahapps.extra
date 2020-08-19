using MahApps.Extra.Data;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MahApps.Extra.Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow, INotifyPropertyChanged
    {
        public ObservableCollection<AccordionMenuItem> firstMenu;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public ObservableCollection<AccordionMenuItem> FirstMenu
        {
            get
            {
                return firstMenu;
            }
            set
            {
                firstMenu = value; PropertyChanged(this, new PropertyChangedEventArgs("FirstMenu"));
            }
        }


        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

            Uri oUri = new Uri("pack://application:,,,/" + "MahApps.Extra.Sample" + "; component/" + "Assets/box.png", UriKind.RelativeOrAbsolute);


            var rsNanme = "MahApps.Extra.Sample.Assets.box.png";
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



            var its3 = new List<AccordionMenuItem>()
            {
                new AccordionMenuItem() {Title = "Menu Item 3", Icon =  BitmapFrame.Create(asm) },
                 new AccordionMenuItem() {Title = "Menu Item 4", Icon =  BitmapFrame.Create(asm) },

            };

            lstDide2.Items = its3;

            lstDide.SelectedItemChanged += LstDide_SelectedItemChanged;
            lstDide2.SelectedItemChanged += LstDide_SelectedItemChanged;
        }

        private void LstDide_SelectedItemChanged(object sender, AccordionMenuItem e)
        {
            if (e != null)
            {
                if (sender == lstDide)
                {
                    lstDide2.ClearSelection();
                }
                else
                {
                    lstDide.ClearSelection();
                }
            }

        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
