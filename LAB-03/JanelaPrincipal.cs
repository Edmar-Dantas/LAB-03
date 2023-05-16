using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_03
{
    public partial class JanelaPrincipal : Form
    {
        public JanelaPrincipal()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            openFileDialogBuscar.Filter =
                "Arquivos bmp| *.bmp | Arquivos jpg |*.jpg";
            if (openFileDialogBuscar.ShowDialog() == DialogResult.OK)
            {
                BoxScreenImg.ImageLocation = openFileDialogBuscar.FileName;
            };
        }
    }
}
