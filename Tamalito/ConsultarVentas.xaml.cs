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
    /// Lógica de interacción para ConsultarVentas.xaml
    /// </summary>
    public partial class ConsultarVentas : Window
    {
        public ConsultarVentas()
        {
            InitializeComponent();
        }

        private void BtCancelar_Click(object sender, RoutedEventArgs e)
        {
            Dueño dueño;
            dueño = new Dueño();
            dueño.Show();
            this.Close();
        }

        private void CbAnio1_Loaded(object sender, RoutedEventArgs e)
        {
            int i;
            for (i = 2019; i < 2020; i++)
                cbAnio1.Items.Add(i);
        }

        private void CbAnio2_Loaded(object sender, RoutedEventArgs e)
        {
            int i;
            
            for (i = 2019; i < 2020; i++)
                cbAnio2.Items.Add(i);
        }

        private void CbMes1_Loaded(object sender, RoutedEventArgs e)
        {
            cbMes1.Items.Add("Enero");
            cbMes1.Items.Add("Febrero");
            cbMes1.Items.Add("Marzo");
            cbMes1.Items.Add("Abril");
            cbMes1.Items.Add("Mayo");
            cbMes1.Items.Add("Junio");
            cbMes1.Items.Add("Julio");
            cbMes1.Items.Add("Agosto");
            cbMes1.Items.Add("Septiembre");
            cbMes1.Items.Add("Octubre");
            cbMes1.Items.Add("Noviembre");
            cbMes1.Items.Add("Diciembre");
        }

        private void CbMes2_Loaded(object sender, RoutedEventArgs e)
        {
            cbMes2.Items.Add("Enero");
            cbMes2.Items.Add("Febrero");
            cbMes2.Items.Add("Marzo");
            cbMes2.Items.Add("Abril");
            cbMes2.Items.Add("Mayo");
            cbMes2.Items.Add("Junio");
            cbMes2.Items.Add("Julio");
            cbMes2.Items.Add("Agosto");
            cbMes2.Items.Add("Septiembre");
            cbMes2.Items.Add("Octubre");
            cbMes2.Items.Add("Noviembre");
            cbMes2.Items.Add("Diciembre");
        }

        private void CbDia1_Loaded(object sender, RoutedEventArgs e)
        {
            int i;
            for (i = 1; i < 32; i++)
                cbDia1.Items.Add(i);
        }

        private void CbDia2_Loaded(object sender, RoutedEventArgs e)
        {
            int i;
            for (i = 1; i < 32; i++)
                cbDia2.Items.Add(i);
        }

        private void BtConsultar_Click(object sender, RoutedEventArgs e)
        {
            //Debemos ver que la fecha de inicio sea antes que la fecha final; de lo contrario mandar un menaje de error
            StringBuilder fechaI = new StringBuilder();
            StringBuilder fechaF = new StringBuilder();
            fechaI.Append(cbAnio1.SelectedIndex.ToString()).Append(cbMes1.SelectedIndex.ToString()).Append(cbDia1.SelectedIndex.ToString());
            fechaF.Append(cbAnio2.SelectedIndex.ToString()).Append(cbMes2.SelectedIndex.ToString()).Append(cbDia2.SelectedIndex.ToString());
            //Comprobación de la fecha
            if (fechaI.ToString().CompareTo(fechaF.ToString()) < 0)
            {

            }
            else
                MessageBox.Show("Las fechas están mal");
        }
    }
}
