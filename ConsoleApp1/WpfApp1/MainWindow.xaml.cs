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
using Microsoft.Win32;
namespace WpfApp1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        String arquivo = "lista.txt";

        public ObservableCollection<String> Lista = new ObservableCollection<string>();
        public ObservableCollection<String> ListaPesquisa = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists(arquivo))
            {
                var lista_arquivo = File.ReadAllLines(arquivo);
                Lista = new ObservableCollection<string>(lista_arquivo);
            }
            this.listbox.ItemsSource = this.Lista;
            status.Content = arquivo;
        }



        private void Add_button_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(arquivo))
            {
                File.Delete(arquivo);
            }
            this.Lista.Add(this.item_textbox.Text);
            File.AppendAllLines(arquivo, Lista.ToList());
            this.item_textbox.Text = string.Empty;
            this.item_textbox.Focus();
        }

        private void Listbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                Lista.RemoveAt(listbox.SelectedIndex);
                if (File.Exists(arquivo))
                {
                    File.Delete(arquivo);
                }
                File.AppendAllLines(arquivo, Lista.ToList());
            }

        }

        private void Item_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Add_button_Click(null, null);
            }
        }

        private void Menu_abrir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == true)
            {
                var lista_arquivo = File.ReadAllLines(file.FileName);
                Lista = new ObservableCollection<string>(lista_arquivo);
                this.listbox.ItemsSource = this.Lista;
                arquivo = file.FileName;
                status.Content = arquivo;

            }
        }

        private void Menu_salvar_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            if (file.ShowDialog() == true)
            {
                File.AppendAllLines(file.FileName, Lista.ToList());
                arquivo = file.FileName;
                status.Content = arquivo;

            }
        }

        private void Mudar_status_Click(object sender, RoutedEventArgs e)
        {
            if (listbox.SelectedItem == null) return;
            var index = listbox.SelectedIndex;
            var tarefa = listbox.SelectedItem.ToString();

            if (tarefa.Contains("[Ok]"))
                tarefa = tarefa.Replace("[Ok]", "");
            else
                tarefa = "[Ok]" + tarefa;


            Lista[index] = tarefa;
            if (File.Exists(arquivo))
            {
                File.Delete(arquivo);
            }
            File.AppendAllLines(arquivo, Lista.ToList());
        }

        private void Mostrar_somente_prontos_Checked(object sender, RoutedEventArgs e)
        {
            var filtro = Lista.Where(tarefa => tarefa.Contains("[Ok]")==true).ToList();
            ListaPesquisa = new ObservableCollection<string>(filtro);
            listbox.ItemsSource = ListaPesquisa;
        }
        private void Mostrar_somente_prontos_Unchecked(object sender, RoutedEventArgs e)
        {
            listbox.ItemsSource = Lista;
        }


        private void Mostrar_somente_nao_prontas_Checked(object sender, RoutedEventArgs e)
        {
            var filtro = Lista.Where(tarefa => tarefa.Contains("[Ok]")!=true).ToList();
            ListaPesquisa = new ObservableCollection<string>(filtro);
            listbox.ItemsSource = ListaPesquisa;

        }

        private void Mostrar_somente_nao_prontas_Unchecked(object sender, RoutedEventArgs e)
        {
            listbox.ItemsSource = Lista;
        }
    }
}

