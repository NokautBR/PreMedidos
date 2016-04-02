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
    /// Lógica interna para TelaPesagem.xaml
    /// </summary>
    public partial class TelaPesagem : Window
    {
        public TelaPesagem()
        {
            InitializeComponent();
        }

        private void TabPesagem_Loaded(object sender, RoutedEventArgs e)
        {
            var listaPesagem = new List<TempPesagem>();
            var grid = sender as DataGrid;
            grid.ItemsSource = listaPesagem;
        }
    }

    class TempPesagem
    {
        public String Embalagem { get; set; }
        public String PesoBruto { get; set; }
        public String PesoLiquido { get; set; }
        public String Resultado { get; set; }
    }
}
