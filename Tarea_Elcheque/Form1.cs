using ProyectoVectores.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_Elcheque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (int.TryParse(this.textBox1.Text, out int num))
                {
                    //TODO: asignar cada entero al vector 
                    this.label3.Text = NumLetras.getLetras(num);
                    this.textBox1.Text = "";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
