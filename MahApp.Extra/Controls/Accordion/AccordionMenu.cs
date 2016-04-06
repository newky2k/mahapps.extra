using MahApps.Extra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MahApps.Extra.Controls
{
    public class AccordionMenu : ContentControl
    {

        public static readonly DependencyProperty ItemsProperty = DependencyProperty.Register(
            "Items",
            typeof(List<AccordionMenuItem>),
            typeof(AccordionMenu),
            new PropertyMetadata(ItemsPropertyChanged));


        /// <summary>
        /// The name of the ExpanderButton template part.
        /// </summary>
        private const string ListMenuName = "ListMenu";

        private ListView ListView;

        public List<AccordionMenuItem> Items
        {
            get
            {
                return this.GetValue(ItemsProperty) as List<AccordionMenuItem>;
            }

            set
            {

                this.SetValue(ItemsProperty, value);

            }
        }

        public AccordionMenu()
        {
            var items = new List<AccordionMenuItem>();

            this.Items = items;
        }

        private static void ItemsPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            var menu = dependencyObject as AccordionMenu;

           if (menu.ListView != null)
            {
                menu.ListView.ItemsSource = e.NewValue as List<AccordionItem>;
            }
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            ListView = this.GetTemplateChild(ListMenuName) as ListView;

            ListView.SelectionChanged += OnSelectionChanged;
            var items = this.GetValue(ItemsProperty) as List<AccordionMenuItem>;

            if (ListView != null)
            {
                ListView.ItemsSource = items;
            }

        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine("");
        }
    }
}
