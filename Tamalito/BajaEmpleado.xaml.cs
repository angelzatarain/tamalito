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
    /// Lógica de interacción para BajaEmpleado.xaml
    /// </summary>
    public partial class BajaEmpleado : Window
    {
        public BajaEmpleado()
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

        private void BtContinuar_Click(object sender, RoutedEventArgs e)
        {
            try {
                Empleados empleado = new Empleados();
                int res = empleado.eliminar(int.Parse(tbIdEmpleado.Text), tbNombre.Text, tbApellidoPaterno.Text, tbApellidoMaterno.Text);
                if (res < 0)
                    MessageBox.Show("empleado no encontrado");
                else
                    MessageBox.Show("se dió de baja al empleado");
                if (App.Current.Properties["idUsuarioActivo"].Equals(tbIdEmpleado.Text))
                {
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Close();
                }
                else
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
            catch (Exception) {
                MessageBox.Show("Error");
            }
        }

        private void TbApellidoMaterno_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
