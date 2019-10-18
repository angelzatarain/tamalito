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
using System.Data.SqlClient;

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

        private void BtContinuar_Click(object sender, RoutedEventArgs e)
        {
            try{
                Empleados empleado = new Empleados();
                if (App.Current.Properties["idUsuarioActivo"].Equals(tbIdEmpleado.Text)) {
                    MessageBox.Show("No puedes modificar tu propio puesto");
                }
                else {
                    int res = empleado.modificarPuesto(int.Parse(tbIdEmpleado.Text), tbNombre.Text, tbApellidoPaterno.Text, tbApellidoMaterno.Text, cbPuesto.SelectedIndex.ToString());
                    if (res < 0)
                        MessageBox.Show("empleado no encontrado");
                    else
                        MessageBox.Show("se cambió el puesto del empleado");
                }
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
            catch (Exception){
                MessageBox.Show("Error");
            }
        }

        private void CbPuesto_Loaded_1(object sender, RoutedEventArgs e)
        {
            try
            {
                cbPuesto.Items.Add("Empleado");
                cbPuesto.Items.Add("Gerente");
                cbPuesto.Items.Add("Dueño");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
