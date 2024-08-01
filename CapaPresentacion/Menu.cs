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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusStrip1.Items[1].Text = "Fecha/Hora: " + DateTime.Now.ToString();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hará salir de la Aplicación!n Seguro que desea hacerlo?",
                "Mensaje de SIDEPE", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.Exe");
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MantCargo mantcargoo = new MantCargo();
           // mantcargoo.ShowDialog();
        }

        private void editorDeTextosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\notepad.exe");
        }

        private void navegadorWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files(x86)\Microsoft\Edge\Application\msedge.exe");
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  MantEmpleado mantempleadoo = new MantEmpleado();
           // mantempleadoo.ShowDialog();
          
        }

        private void naveToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  MantNave buscarnave = new MantNave();
          //  buscarnave.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   AcercaDeSIDEPE acercadesidepe = new AcercaDeSIDEPE();
           // acercadesidepe.ShowDialog();
        }
    }
}
