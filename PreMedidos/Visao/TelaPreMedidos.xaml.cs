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
using System.Windows.Shapes;

namespace PreMedidos.Visao
{
    /// <summary>
    /// Lógica interna para TelaPreMedidos.xaml
    /// </summary>
    public partial class TelaPreMedidos : Window
    {
        public TelaPreMedidos()
        {
            InitializeComponent();
        }

        private void TabExames_Loaded(object sender, RoutedEventArgs e)
        {
            var listExame = new List<TempExame>();
            var temp = new TempExame();
            temp.Tipo = new ComboBox();
            temp.Tipo.Items.Add("Prévia");
            temp.Tipo.Items.Add("Auto Serviço");
            temp.Tipo.Items.Add("Exame Final");
            listExame.Add(temp);
            var grid = sender as DataGrid;
            grid.ItemsSource = listExame;
        }

    }

    class TempExame
    {
        public ComboBox Tipo { get; set; }
        public ComboBox Produto { get; set; }
        public ComboBox Marca { get; set; }
        public String Valor { get; set; }
        public ComboBox Dimensao { get; set; }
        public String PEmbalagem { get; set; }
        public ComboBox TEmbalagem { get; set; }
        public ComboBox Portaria { get; set; }
        public String Lote { get; set; }
        public String Amostra { get; set; }
        public String Resultado { get; set; }
        public String Coletar { get; set; }
        public String Termo { get; set; }
    }
}
