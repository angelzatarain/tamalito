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
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Tamalito
{
    /// <summary>
    /// Lógica de interacción para TomarOrden.xaml
    /// </summary>
    public partial class TomarOrden : Window
    {
        List<String> carrito = new List<String>();
        public TomarOrden()
        {
            InitializeComponent();
        }

        public int click(Button bt)
        {
            return Convert.ToInt32(bt.Tag);
        }

        private void Ventana_Loaded(object sender, RoutedEventArgs e)
        {
            //Traer todos los productos de la BD y guardarlos en una lista:
            try{
                SqlConnection con = Conexion.conectar();
                SqlCommand cmd = new SqlCommand(String.Format("select * from alumno where nombre like '%{0}%'", nombre), con);
                SqlDataReader rd = cmd.ExecuteReader();

                List<Producto> lis = new List<Producto>();
                Producto prod = null;

                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    prod = new Producto();
                    prod.claveUnica = rd.GetInt16(0);
                    lis.Add(prod);

                }
                con.Close();
            }catch (Exception ex){
                MessageBox.Show("Error: " + ex.Message);
            }
            
            int n = 10;
            grid.Columns = 4;
            if (n % 4 != 0)
                grid.Rows = (n / 4) + 1;
            else
                grid.Rows = (n / 4);

            List prod = new List(); //Hacer lista de productos
            for (int i = 0; i < n; i++)
            {

                Button bt = new Button();
                Uri resourceUri = new Uri(prod[i].getUrlImage(), UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;

                bt.Background = brush;
                grid.Children.Add(bt);


                bt.Tag = i;
                //AddEvent:
                bt.Click += delegate
                {
                    carrito.Add("" + this.click(bt));
                };
            }



        }
    }
}