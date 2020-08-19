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


        public event EventHandler<AccordionMenuItem> SelectedItemChanged;

        
        /// <summary>
        /// The name of the ExpanderButton template part.
        /// </summary>
        private const string ListMenuName = "ListMenu";

        private ListView List;

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

        /// <summary>
        /// Gets or sets the parent accordion item.
        /// </summary>
        /// <value>
        /// The parent accordion item.
        /// </value>
        internal AccordionItem ParentAccordionItem { get; set; }

        public AccordionMenu()
        {
            var items = new List<AccordionMenuItem>();

            this.Items = items;
        }

        private static void ItemsPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            var menu = dependencyObject as AccordionMenu;

           if (menu.List != null)
            {
                menu.List.ItemsSource = e.NewValue as List<AccordionItem>;
            }
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            List = this.GetTemplateChild(ListMenuName) as ListView;

           

            if (List != null)
            {
                List.SelectionChanged += OnSelectionChanged;
                var items = this.GetValue(ItemsProperty) as List<AccordionMenuItem>;
                List.ItemsSource = items;
            }

        }

        /// <summary>
        /// Gets or sets the index of the selected.
        /// </summary>
        /// <value>The index of the selected.</value>
        public int SelectedIndex
        {
            get
            {
                if (List != null)
                {
                    return List.SelectedIndex;
                }

                return -1;
            }
            set
            {
                if (List != null)
                {
                    List.SelectedIndex = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the selected item.
        /// </summary>
        /// <value>The selected item.</value>
        public object SelectedItem
        {
            get
            {
                if (List != null)
                {
                    return List.SelectedItem;
                }

                return -1;
            }
            set
            {
                if (List != null)
                {
                    List.SelectedItem = value;
                }
            }
        }
        /// <summary>
        /// Clears the selection.
        /// </summary>
        public void ClearSelection()
        {
            if (List != null)
            {
                List.SelectedItem = null;
            }
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.SelectedItemChanged != null)
            {
                AccordionMenuItem selectedItem = (e.AddedItems.Count > 0) ? (AccordionMenuItem)e.AddedItems[0] : null;

                this.SelectedItemChanged(this, selectedItem);
            }
            

        }
    }
}
