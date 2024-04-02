using Crud33.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud3.VISTA.ClienteVista
{
    public partial class ListarClientesTotal : Form
    {
        public ListarClientesTotal()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();

        private void ListarClientesTotal_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=bss.ListarClienteTotalBss();
        }
    }
}
