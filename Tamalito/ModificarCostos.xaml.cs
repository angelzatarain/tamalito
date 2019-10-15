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
    /// Lógica de interacción para ModificarCostos.xaml
    /// </summary>
    public partial class ModificarCostos : Window
    {
        public ModificarCostos()
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

        private void BtContinuar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = Conexion.conectar();
                SqlCommand cmd = new SqlCommand(String.Format("insert into producto (costo) values({0}) where idProducto={1}", int.Parse(tbNuevoPrecio.Text), int.Parse(tbIdProducto.Text)), con);
                if (cmd.ExecuteNonQuery() == -1)
                    MessageBox.Show("No se pudo cambiar el precio");
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error try catch");
            }
        }

        private void BtConsultar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = Conexion.conectar();
                SqlCommand cmd = new SqlCommand(String.Format("select costo from producto where idProducto={0}", int.Parse(tbIdProducto.Text)), con);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    lbPrecioActual1.Content = rd.GetString(0);
                }
                else
                {
                    MessageBox.Show("Error en Query");
                }
                rd.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error try catch");
            }
        }
    }
}
