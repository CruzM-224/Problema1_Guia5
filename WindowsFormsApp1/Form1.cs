using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbtngerente_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtnsubgerente_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtnsecretaria_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double paga, pagainicial;
            try
            {
                pagainicial = Convert.ToDouble(Salario.Text);
                if (rbtngerente.Checked == true)
                {
                    paga = pagainicial - pagainicial * 0.20;
                    MessageBox.Show("El salario de " + Nombre.Text + ", quien es gerente, es de $" + pagainicial + " con un descuento del 20%, haciendo su sueldo liquido de $" + paga);
                }
                else
                {
                    if (rbtnsubgerente.Checked == true)
                    {
                        paga = pagainicial - pagainicial * 0.15;
                        MessageBox.Show("El salario de " + Nombre.Text + ", quien es subgerente, es de $" + pagainicial + " con un descuento del 15%, haciendo su sueldo liquido de $" + paga);
                    }
                    else
                    {
                        if (rbtnsecretaria.Checked == true)
                        {
                            paga = pagainicial - pagainicial * 0.10;
                            MessageBox.Show("El salario de " + Nombre.Text + ", quien es secretaria, es de $" + pagainicial + " con un descuento del 10%, haciendo su sueldo liquido de $" + paga);
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe ingresar obligatoriamente un número entero en salario.");
            }
        }
    }
}
