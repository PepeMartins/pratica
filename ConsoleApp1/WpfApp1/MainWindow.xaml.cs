using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<String> Lista = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists("lista.txt"))
            {
                var lista_arquivo = File.ReadAllLines("lista.txt");
                Lista = new ObservableCollection<string>(lista_arquivo);
            }
            this.listbox.ItemsSource = this.Lista;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Add_button_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists("lista.txt"))
            {
                File.Delete("lista.txt");
            }
            this.Lista.Add(this.item_textbox.Text);
            File.AppendAllLines("lista.txt", Lista.ToList());
            this.item_textbox.Text = string.Empty;
            this.item_textbox.Focus();
        }

        private void Listbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                Lista.RemoveAt(listbox.SelectedIndex);
                if (File.Exists("lista.txt"))
                {
                    File.Delete("lista.txt");
                }
                File.AppendAllLines("lista.txt", Lista.ToList());
            }

        }

        private void Item_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                Add_button_Click(null, null);
            }
        }
    }
}

