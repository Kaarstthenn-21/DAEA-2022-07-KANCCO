using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsNEGPerson np = new clsNEGPerson();
            dt = np.GetAll();
            dgDatos.DataSource = dt;
            dgDatos.Refresh();
        }

        private void dgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsNEGPerson np = new clsNEGPerson();
            string nombre = txtName.Text;
            dt = np.GetPerson(nombre);
            dgDatos.DataSource = dt;
            dgDatos.Refresh();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
