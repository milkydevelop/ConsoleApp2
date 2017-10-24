using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    #region Jakieś gówna
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        #endregion
        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c, x1, x2, pwk;
            a = (double)numericUpDown1.Value;
            b = (double)numericUpDown2.Value;
            c = (double)numericUpDown3.Value;

            pwk = Math.Sqrt(b * b - 4 * a * c);

            x1 = (-b - pwk) / (2 * a);
            x2 = (-b + pwk) / (2 * a);

            if (pwk > 0)
            {
                MessageBox.Show("Pierwiastkami równania kwadratowego to: x1 = " + x1 + ", x2 = " + x2);
            }
            else if (pwk == 0)
            {
                MessageBox.Show("równanie ma jedno miejsce zerowe x = " + x1);
            }
            else
            {
                MessageBox.Show("Nie da się, delta wynosi -" + pwk*pwk);
            }
            
                chart1.Series.Clear(); // trzeba dodać osie XY i poprawić formatowanie
                var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = "Series1",
                    Color = System.Drawing.Color.Green,
                    IsVisibleInLegend = false,
                    IsXValueIndexed = true,
                    ChartType = SeriesChartType.Line
                };

                this.chart1.Series.Add(series1);

                for (int x = -10; x < 10; x++) //tutaj jest januszowato, trzeba jakoś zakres sprytniej zrobić
                {
                    series1.Points.AddXY(x, Funkcja(x));
                }
                chart1.Invalidate();
            }
        public double Funkcja(double x)
        {
            double a, b, c;
            a = (double)numericUpDown1.Value;
            b = (double)numericUpDown2.Value;
            c = (double)numericUpDown3.Value;
            double funkcja1 = c + (b * x) + (a * x * x);
            return funkcja1;
        }


        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
