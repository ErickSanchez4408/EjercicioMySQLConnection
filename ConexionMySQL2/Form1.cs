using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionMySQL2
{
    public partial class Form1 : Form
    {
        private MySqlConnection conexion;




        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHost.Text))
            {
                MessageBox.Show("El Host es campo obligatorio");
                return;
            }
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("El User es campo obligatorio");
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("El Password es campo obligatorio");
                return;
            }

            try
            {
                conexion = new MySqlConnection();
                conexion.ConnectionString =
                    "server =" + txtHost.Text + ";"
                    + "user id = "+ txtUser.Text + ";"
                    + "password = "+ txtPassword.Text + ";";
                conexion.Open();
                MessageBox.Show("LA CONEXION SE REALIZO CORRECTAMENTE");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Hubo un error al Conectar: " + ex.Message);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
