using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class testConeccion : Form
    {
        public testConeccion()
        {
            InitializeComponent();
        }

        private void testConeccion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDEmpresaDataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this.bDEmpresaDataSet.Categorias);

        }
    }
}
