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
    /// Lógica de interacción para Gerente.xaml
    /// </summary>
    public partial class Gerente : Window
    {
        public Gerente()
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

        private void BtAltaEmpleado_Click(object sender, RoutedEventArgs e)
        {
            AltaEmpleado altaEmpleado;
            altaEmpleado = new AltaEmpleado();
            altaEmpleado.Show();
            this.Close();
        }

        private void BtPromoverEmpleado_Click(object sender, RoutedEventArgs e)
        {
            PromoverEmpleado promoverEmpleado;
            promoverEmpleado = new PromoverEmpleado();
            promoverEmpleado.Show();
            this.Close();
        }

        private void BtBajaEmpleado_Click(object sender, RoutedEventArgs e)
        {
            BajaEmpleado bajaEmpleado;
            bajaEmpleado = new BajaEmpleado();
            bajaEmpleado.Show();
            this.Close();
        }

        private void BtAniadirInventario_Click(object sender, RoutedEventArgs e)
        {
            AniadirInventario aniadirInventario;
            aniadirInventario = new AniadirInventario();
            aniadirInventario.Show();
            this.Close();
        }
    }
}
