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
            for (i = 2000; i <= DateTime.Today.Year; i++)
                cbAnio1.Items.Add(i);
        }

        private void CbAnio2_Loaded(object sender, RoutedEventArgs e)
        {
            int i;
            
            for (i = 2000; i <= DateTime.Today.Year; i++)
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
            //CambiosJC
            Boolean res = false;
            if ((cbAnio1.SelectedIndex + 2000) > (cbAnio2.SelectedIndex + 2000))
                MessageBox.Show("Error en los años");
            else
                if ((cbAnio1.SelectedIndex + 2000) == (cbAnio2.SelectedIndex + 2000))
                    if ((cbMes1.SelectedIndex + 1) > (cbAnio2.SelectedIndex + 1))
                        MessageBox.Show("Error en los meses");
                    else
                        if ((cbMes1.SelectedIndex + 1) == (cbMes2.SelectedIndex + 1))
                        {
                            if ((cbDia1.SelectedIndex + 1) >= (cbDia2.SelectedIndex + 1))
                                MessageBox.Show("Error en los días");
                            else
                                res = true;
                        }
                        else
                            res = true;
                else
                    res = true;
            
            //Comprobación de la fecha
            if (res)
            {
                String fechaIni, fechaFin;
                fechaIni = "" + (cbAnio1.SelectedIndex + 2000) + "-" + (cbMes1.SelectedIndex + 1) + "-" + (cbDia1.SelectedIndex + 1) + "";
                fechaFin = "" + (cbAnio2.SelectedIndex + 2000) + "-" + (cbMes2.SelectedIndex + 1) + "-" + (cbDia2.SelectedIndex + 1) + "";
                try
                {
                    SqlConnection con = Conexion.conectar();
                    SqlCommand cmd = new SqlCommand(String.Format("select pedidosProductos.idPedido, pedidosProductos.idProducto, pedidos.fecha, pedidosProductos.cantidad*productos.costo as Ganancia from productos," +
                        " pedidosProductos, pedidos where productos.idProducto = pedidosProductos.idProducto and pedidosProductos.idPedido = pedidos.idPedido and fecha between '{0}' and '{1}'", fechaIni, fechaFin), con);
                    SqlDataReader rd;
                    rd = cmd.ExecuteReader();
                    int total = 0;
                    List<Venta> lis = new List<Venta>();
                    int i = 1;
                    while (rd.Read())
                    {
                        Venta ven;
                        ven = new Venta();
                        ven.numPed = rd.GetInt32(0);
                        ven.numProd = rd.GetInt32(1);
                        ven.fechaPed = rd.GetDateTime(2);
                        ven.ganancia = rd.GetInt32(3);
                        total = total + ven.ganancia;
                        lis.Add(ven);
                        i++;
                    }
                    dgVentas.ItemsSource = lis;
                    txTotal.Text = ""+total;
                    rd.Close();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            else
                MessageBox.Show("Las fechas están mal");
        }
    }
}
