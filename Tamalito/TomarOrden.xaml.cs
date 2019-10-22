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
        //ATRIBUTOS O VARIBALES GLOBALES:
        List<ObjSelec> carrito = new List<ObjSelec>();
        int precioTamal;
        int precioAtole;
        int subTotal = 0;
        int total = 0;

        //DICCIONARIOS PARA SABER SI LOS BOTONES SE ENCUNETRAN ACTIVOS:
        Dictionary<String, Boolean> botonesActivos = new Dictionary<String, Boolean>()
        {
            ["verde"] = false,
            ["rojo"] = false,
            ["mole"] = false,
            ["dulce"] = false,
            ["arroz"] = false,
            ["vainilla"] = false,
            ["fresa"] = false,
            ["chocolate"] = false
        };
        //DICCIONARIOS PARA SABER LA CANTIDAD SELECCIONADA DE CADA PRODUCTO:
        Dictionary<String, int> cantSeleccionada = new Dictionary<String, int>()
        {
            ["verde"] = 0,
            ["rojo"] = 0,
            ["mole"] = 0,
            ["dulce"] = 0,
            ["arroz"] = 0,
            ["vainilla"] = 0,
            ["fresa"] = 0,
            ["chocolate"] = 0
        };

        //MÉTODO CONSTRUCTOR QUE INICIALIZA LOS COMPONENETES:
        public TomarOrden()
        {
            InitializeComponent();
        }

        //MÉTODO PARA INICIALIZAR TODOS LOS COMPONENTES NECESARIOS AL CARGAR LA VENTANA:
        private void Ventana_Loaded(object sender, RoutedEventArgs e)
        {
            //RELLENAR LOS COMBOBOXES DE LA CANTIDAD DE PRODUCTOS:
            for (int i = 1; i <= 10; i++){
                cbVerde.Items.Add(" " + i);
                cbRojo.Items.Add(" " + i);
                cbMole.Items.Add(" " + i);
                cbDulce.Items.Add(" " + i);
                cbArroz.Items.Add(" " + i);
                cbVainilla.Items.Add(" " + i);
                cbFresa.Items.Add(" " + i);
                cbChocolate.Items.Add(" " + i);
            } 
            //INDICAR EL SELECTED INDEX DE CADA COMBO BOX:
            cbVerde.SelectedIndex = 0;
            cbRojo.SelectedIndex = 0;
            cbMole.SelectedIndex = 0;
            cbDulce.SelectedIndex = 0;
            cbArroz.SelectedIndex = 0;
            cbVainilla.SelectedIndex = 0;
            cbFresa.SelectedIndex = 0;
            cbChocolate.SelectedIndex = 0;

            //OBTENER PRECIOS DE LA BASE DE DATOS;
            SqlConnection con = Conexion.conectar();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 costo FROM productos WHERE categoria='tamal'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            precioTamal = rd.GetInt32(0);
            rd.Close();

            SqlCommand cmd2 = new SqlCommand("SELECT TOP 1 costo FROM productos WHERE categoria='atole'", con);
            SqlDataReader rd2 = cmd.ExecuteReader();
            rd2.Read();
            precioAtole = rd2.GetInt32(0);
            rd2.Close();

            con.Close();
        }

        //MÉTODO PARA ACTUALIZAR LA LISTA
        public void actualizaLista()
        {
            dgRecibo.ItemsSource = null;
            carrito.Clear();
            total = 0;
            foreach (var item in botonesActivos)
            {
                if (item.Value)
                {
                    if ( (item.Key).Equals("verde") || (item.Key).Equals("rojo") || (item.Key).Equals("mole") || (item.Key).Equals("dulce"))
                        subTotal = cantSeleccionada[item.Key] * precioTamal;
                    else
                        subTotal = cantSeleccionada[item.Key] * precioAtole;

                    ObjSelec ob = new ObjSelec();
                    ob.producto = (item.Key).ToString();
                    ob.cantidad = cantSeleccionada[item.Key];
                    ob.costo = subTotal;
                    carrito.Add( ob);

                    total += subTotal;
                }
            }
            dgRecibo.ItemsSource = carrito;
            lbTotal.Content = "$ " + total;
        }

        //MÉTODO DEL BOTÓN REGRESAR:
        private void BtRegresar_Click(object sender, RoutedEventArgs e)
        {
            if (App.Current.Properties["usuarioActivo"].Equals("Empleado")) {
                Empleado main = new Empleado();
                main.Show();
                this.Close();
            }
            else{
                if (App.Current.Properties["usuarioActivo"].Equals("Gerente")) {
                    Gerente main = new Gerente();
                    main.Show();
                    this.Close();
                }
                else {
                    Dueño main = new Dueño();
                    main.Show();
                    this.Close();
                }
            }
        }

        //MÉTODOS PARA ACTUALIZAR LAS CANTIDADES ANTE UN CAMBIO EN LOS COMBOBOXES:
        private void CbVerde_SelectionChanged(object sender, SelectionChangedEventArgs e){
            cantSeleccionada["verde"] = int.Parse(cbVerde.SelectedItem.ToString());
            actualizaLista();
        }
        private void CbRojo_SelectionChanged(object sender, RoutedEventArgs e){
            cantSeleccionada["rojo"] = int.Parse(cbRojo.SelectedItem.ToString());
            actualizaLista();
        }
        private void CbMole_SelectionChanged(object sender, RoutedEventArgs e){
            cantSeleccionada["mole"] = int.Parse(cbMole.SelectedItem.ToString());
            actualizaLista();
        }
        private void CbDulce_SelectionChanged(object sender, RoutedEventArgs e){
            cantSeleccionada["dulce"] = int.Parse(cbDulce.SelectedItem.ToString());
            actualizaLista();
        }
        private void CbArroz_SelectionChanged(object sender, SelectionChangedEventArgs e){
            cantSeleccionada["arroz"] = int.Parse(cbArroz.SelectedItem.ToString());
            actualizaLista();
        }
        private void CbVainilla_SelectionChanged(object sender, RoutedEventArgs e){
            cantSeleccionada["vainilla"] = int.Parse(cbVainilla.SelectedItem.ToString());
            actualizaLista();
        }
        private void CbFresa_SelectionChanged(object sender, RoutedEventArgs e){
            cantSeleccionada["fresa"] = int.Parse(cbFresa.SelectedItem.ToString());
            actualizaLista();
        }
        private void CbChocolate_SelectionChanged(object sender, RoutedEventArgs e){
            cantSeleccionada["chocolate"] = int.Parse(cbChocolate.SelectedItem.ToString());
            actualizaLista();
        }


        //MÉTODOS PARA AGREGAR O QUITAR PRODUCTOS A LA LISTA AL PRESIONAR EL BOTON DE CADA PRODUCTO:
        private void BtVerde_Click(object sender, RoutedEventArgs e){
            if (!botonesActivos["verde"])
            {
                botonesActivos["verde"] = true;
                btVerde.BorderBrush = Brushes.Green;

            }
            else
            {
                botonesActivos["verde"] = false;
                btVerde.BorderBrush = null;
                
            }
            actualizaLista();
        }
        private void BtRojo_Click(object sender, RoutedEventArgs e)
        {
            if (!botonesActivos["rojo"])
            {
                botonesActivos["rojo"] = true;
                btRojo.BorderBrush = Brushes.Green;

            }
            else
            {
                botonesActivos["rojo"] = false;
                btRojo.BorderBrush = null;

            }
            actualizaLista();
        }
        private void BtMole_Click(object sender, RoutedEventArgs e)
        {
            if (!botonesActivos["mole"])
            {
                botonesActivos["mole"] = true;
                btMole.BorderBrush = Brushes.Green;

            }
            else
            {
                botonesActivos["mole"] = false;
                btMole.BorderBrush = null;

            }
            actualizaLista();
        }
        private void BtDulce_Click(object sender, RoutedEventArgs e)
        {
            if (!botonesActivos["dulce"])
            {
                botonesActivos["dulce"] = true;
                btDulce.BorderBrush = Brushes.Green;

            }
            else
            {
                botonesActivos["dulce"] = false;
                btDulce.BorderBrush = null;

            }
            actualizaLista();
        }

        private void BtVainilla_Click(object sender, RoutedEventArgs e)
        {
            if (!botonesActivos["vainilla"])
            {
                botonesActivos["vainilla"] = true;
                btVainilla.BorderBrush = Brushes.Green;

            }
            else
            {
                botonesActivos["vainilla"] = false;
                btVainilla.BorderBrush = null;

            }
            actualizaLista();
        }
        private void BtFresa_Click(object sender, RoutedEventArgs e)
        {
            if (!botonesActivos["fresa"])
            {
                botonesActivos["fresa"] = true;
                btFresa.BorderBrush = Brushes.Green;

            }
            else
            {
                botonesActivos["fresa"] = false;
                btFresa.BorderBrush = null;

            }
            actualizaLista();
        }
        private void BtChocolate_Click(object sender, RoutedEventArgs e)
        {
            if (!botonesActivos["chocolate"])
            {
                botonesActivos["chocolate"] = true;
                btChocolate.BorderBrush = Brushes.Green;

            }
            else
            {
                botonesActivos["chocolate"] = false;
                btChocolate.BorderBrush = null;

            }
            actualizaLista();
        }

        private void BtArroz_Click(object sender, RoutedEventArgs e)
        {
            if (!botonesActivos["arroz"])
            {
                botonesActivos["arroz"] = true;
                btArroz.BorderBrush = Brushes.Green;

            }
            else
            {
                botonesActivos["arroz"] = false;
                btArroz.BorderBrush = null;

            }
            actualizaLista();
        }

        private void BtConfirmar_Click(object sender, RoutedEventArgs e)
        {
            //SE GUARDA EL ID DEL EMPLEADO ACTUAL EN UNA VARIABLE:
            int idEmpleado = int.Parse ( App.Current.Properties["idUsuarioActivo"].ToString() );
            //SE GENERA UNA NUEVA CONEXÓN:
            SqlConnection con = Conexion.conectar();
            SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO pedidos(idEmpleado) VALUES({0});", idEmpleado), con);
            if( cmd.ExecuteNonQuery() > -1){
                SqlCommand cmd2 = new SqlCommand("SELECT TOP 1 * FROM pedidos ORDER BY idPedido DESC;", con);
                SqlDataReader rd = cmd2.ExecuteReader();
                int idPed = -1;
                if (rd.Read())
                    idPed = rd.GetInt32(0);
                rd.Close();

                //for each carrito
                SqlCommand cmd3, cmd4;
                SqlDataReader rd3;
                int res4 = 0;
                int idProd = -1;
                foreach (var item in carrito){
                    cmd3 = new SqlCommand(String.Format("SELECT idProducto FROM productos WHERE nombre='{0}';",item.producto), con);
                    rd3 = cmd3.ExecuteReader();
                    if(rd3.Read())
                        idProd = rd3.GetInt32(0);
                    rd3.Close();
                    cmd4 = new SqlCommand(String.Format("INSERT INTO pedidosProductos(idPedido, idProducto, cantidad) VALUES({0}, {1}, {2});", idPed, idProd, cantSeleccionada[item.producto]), con);
                    res4 = cmd4.ExecuteNonQuery();
                    if (res4 == -1){
                        break;  
                    }

                }
                if (res4 > -1)
                {
                    MessageBox.Show("Pedido realizado con éxito.");
                    TomarOrden main = new TomarOrden();
                    main.Show();
                    this.Close();
                }

                else
                    MessageBox.Show("Error para realizar pedido.");
                


            }
            else
            {
                MessageBox.Show("Error");
            }

            con.Close();

        }
    }

    //CLASE AUXILIAR PARA CREAR LA LISTA DE PRODUCTOS TEMPORAL QUE PROBABLEMENTE SERÁ COMPRADA:
    public class ObjSelec{
        public String producto { get; set; }
        public int cantidad { get; set; }
        public int costo { get; set; }
    }

}