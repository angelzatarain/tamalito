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

namespace Tamalito
{
    /// <summary>
    /// Lógica de interacción para Empleado.xaml
    /// </summary>
    public partial class Empleado : Window
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void BtCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            IniciarSesion ini;
            ini = new IniciarSesion();
            ini.Show();
            this.Close();

        }

        private void BtTomarOrden_Click(object sender, RoutedEventArgs e)
        {
            TomarOrden tomarOrden;
            tomarOrden = new TomarOrden();
            tomarOrden.Show();
            this.Close();
        }
    }
}
