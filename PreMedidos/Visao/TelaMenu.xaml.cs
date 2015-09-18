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
    /// Lógica interna para TelaMenu.xaml
    /// </summary>
    public partial class TelaMenu : Window
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        private void btnPreMedidos_Click(object sender, RoutedEventArgs e)
        {
            Visao.TelaPreMedidos preMedidos = new TelaPreMedidos();
            preMedidos.Show();
            this.Close();
        }
    }
}
