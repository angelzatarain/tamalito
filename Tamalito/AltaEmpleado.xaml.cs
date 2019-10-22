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
    /// Lógica de interacción para AltaEmpleado.xaml
    /// </summary>
    public partial class AltaEmpleado : Window
    {
        public AltaEmpleado()
        {
            InitializeComponent();
        }

        private void BtAlta_Click(object sender, RoutedEventArgs e)
        {
            int res, id;
            char sexo;
            if(rbHombre.IsChecked==true)
                sexo = 'H';
            else
            {
                if (rbMujer.IsChecked == true)
                    sexo = 'M';
                else
                    sexo = 'O';
            }
            id = 5;
            String fecha;

            fecha = "" + (cbAnio.SelectedIndex + 1960) + "-" + (cbMes.SelectedIndex + 1) + "-" + (cbDia.SelectedIndex + 1);
            Empleados emp = new Empleados(id, tbNombre.Text, tbApellidoPaterno.Text, tbApellidoMaterno.Text, fecha, sexo, tbDireccion.Text, "Gerente" , "" + id);
            res = emp.agregar(emp);
            if (res > 0){
                MessageBox.Show("Empleado dado de alta");
                AltaEmpleado main = new AltaEmpleado();
                main.Show();
                this.Close();
            }
            else
                MessageBox.Show("No se pudo dar de alta");
        }

        private void CbMes_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void CbAnio_Loaded(object sender, RoutedEventArgs e)
        {
            int i;
            for(i=1960; i<2002; i++)
                cbAnio.Items.Add(i);
        }

        private void CbDia_Loaded(object sender, RoutedEventArgs e)
        {
            int i;
            for (i = 1; i <32; i++)
                cbDia.Items.Add(i);
        }

        private void BtRegresar_Click(object sender, RoutedEventArgs e)
        {
            if (App.Current.Properties["usuarioActivo"].Equals("Gerente")) {
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
