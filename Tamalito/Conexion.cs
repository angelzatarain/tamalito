﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;


namespace Tamalito
{
    class Conexion
    {
        SqlCommand cmd;
        SqlDataReader rd;

        public static SqlConnection conectar()
        {
            SqlConnection cnn;
            try
            {
                cnn = new SqlConnection("Data Source=localhost;Initial Catalog=tamalito;Integrated Security=True");

                cnn.Open();
            }
            catch (Exception ex)
            {
                cnn = null;
                MessageBox.Show("no se pudo hacer la conexión" + ex);
            }
            return cnn;
        }

        public static Boolean comprabarPwd(int usuario, String contra)
        {
            Boolean res = false;
            SqlDataReader rd;
            SqlConnection con;
            try
            {
                con = Conexion.conectar();
                SqlCommand cmd = new SqlCommand(String.Format("select contrasenia from empleados where idEmpleado= {0}", usuario), con);
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    if (rd.GetString(0).Equals(contra))
                        res = true;
                    else
                        res = false;
                }
                else
                {
                    res = false;
                }
                con.Close();
                rd.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Ni entró: " + ex);
            }
            return res;

        }

        public static int comprobarEmpleo(int usuario)
        {
            int res = -1;
            SqlDataReader rd;
            SqlConnection con;
            try
            {
                con = Conexion.conectar();
                SqlCommand cmd = new SqlCommand(String.Format("select activo from empleados where idEmpleado= {0}", usuario), con);
                rd = cmd.ExecuteReader();
                if (rd.Read())
                    if (rd.GetByte(0).Equals(1))

                        res = 1;
                    else
                        res = 0;
                con.Close();
                rd.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("ERROR" + ex);
            }
            return res;
        }

    }
}
