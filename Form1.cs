using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                                            //Nombre del servidor                   //Nombre Base        //En caso de usuario y contraseña
            string conectar = "Data Source= A-006-4291\\SQLEXPRESS; Initial Catalog = primeraBase; Integrated Security = True; ";
                            //Ponemos el query que deseamos realizar o mostrar
            string query = "select * from[primeraBase].[dbo].[Table_1]";
            
            SqlConnection con = new SqlConnection(conectar);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //el dataGridView1 es donde se va a mostrar la tabla
            dataGridView1.DataSource = dt;
            
        }
    }
}
