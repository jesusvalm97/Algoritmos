using System;
using System.Collections.Generic;
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

namespace DragDropFileWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            listBoxDragDrop.AllowDrop = true;
            listBoxDragDrop.DragOver += ListBoxDragDrop_DragOver;
            listBoxDragDrop.DragLeave += ListBoxDragDrop_DragLeave;
            listBoxDragDrop.Drop += ListBoxDragDrop_Drop;

            //-----------------------------------------------------
            listView.AllowDrop = true;
            listView.DragOver += ListView_DragOver;
            listView.DragLeave += ListView_DragLeave;
            listView.Drop += ListView_Drop;
        }

        private void ListView_Drop(object sender, DragEventArgs e)
        {
            var listView = sender as ListView;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (var file in files)
                {
                    listView.Items.Add(file);
                }
            }
        }

        private void ListView_DragLeave(object sender, DragEventArgs e)
        {
            var listview = sender as ListView;
            listview.Background = new SolidColorBrush(Color.FromRgb(226, 226, 226));
        }

        private void ListView_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.Copy;
                var listview = sender as ListView;
                listview.Background = new SolidColorBrush(Color.FromRgb(155, 155, 155));
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void ListBoxDragDrop_Drop(object sender, DragEventArgs e)
        {
            var listbox = sender as ListBox;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach(var file in files)
                {
                    listbox.Items.Add(file);
                }
            }
        }

        private void ListBoxDragDrop_DragLeave(object sender, DragEventArgs e)
        {
            var listbox = sender as ListBox;
            listbox.Background = new SolidColorBrush(Color.FromRgb(226, 226, 226));
        }

        private void ListBoxDragDrop_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.Copy;
                var listbox = sender as ListBox;
                listbox.Background = new SolidColorBrush(Color.FromRgb(155, 155, 155));
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
        }
    }
}
