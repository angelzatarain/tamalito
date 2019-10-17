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
    /// Lógica de interacción para PromoverEmpleado.xaml
    /// </summary>
    public partial class PromoverEmpleado : Window
    {
        public PromoverEmpleado()
        {
            InitializeComponent();
        }

        private void BtCancelar_Click(object sender, RoutedEventArgs e)
        {
            if (App.Current.Properties["usuarioActivo"].Equals("Gerente"))
            {
                Gerente main = new Gerente();
                main.Show();
                this.Close();
            }
            else
            {
                Dueño main = new Dueño();
                main.Show();
                this.Close();
            }
        }
    }
}
