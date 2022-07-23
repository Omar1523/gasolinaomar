using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Galones_a_Litros
{
    public partial class Form1 : Form
    {
        public double a = 10.5;
        public double precio = 293.6;
        public double valor;
        public double gal;
        public int contador = 0;
        public int id = 1;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double promedio = Convert.ToDouble(cantidad.Text);
            double gasolina = Convert.ToDouble(gasolinaprecio.Text);
            double paso = Convert.ToDouble(pase.Text);
            double prom;
            double rms;
        

            for (a = 0; a <= 21; a++)
            {
                gal = promedio / 3.7854;
                valor = gasolina / promedio;
                int n = dtgv.Rows.Add();
                valor = Math.Round(valor, 2);
                gal = Math.Round(gal, 2);
                dtgv.Rows[n].Cells[0].Value = id;
                dtgv.Rows[n].Cells[1].Value = promedio + " /100 Km";
                dtgv.Rows[n].Cells[2].Value = gal + " Gal";
                dtgv.Rows[n].Cells[3].Value = "DOP$ " + valor;
                promedio = promedio - paso;
                id++;
                cantidad.Text = "";
                gasolinaprecio.Text = "";
                pase.Text = "";
                promedio = gasolina + Math.Round(gal, 2) / 21;
                promedio = Math.Round(promedio, 2);
                txtpromedio.Text = Convert.ToString(promedio);
                rms = Math.Sqrt (Math.Pow(gasolina, 2) + Math.Pow(gasolina, 2) / 21);
                rms = Math.Round(rms, 2);
                txtpromediorms.Text = Convert.ToString(rms);




            }

        }


       

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            dtgv.Rows.Clear();
            cantidad.Text = "";
            gasolinaprecio.Text = "";
            pase.Text = "";
            txtpromedio.Text = "";
            txtpromediorms.Text = "";

               
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
