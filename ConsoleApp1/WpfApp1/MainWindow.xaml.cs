using System;
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
            Lista.Add("pão");
            Lista.Add("biscoito");
            Lista.Add("ração");
            this.listbox.ItemsSource = this.Lista;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Add_button_Click(object sender, RoutedEventArgs e)
        {
            this.Lista.Add(this.item_textbox.Text);
        }
       

    }
}
