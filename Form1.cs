using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDownSize_ValueChanged(object sender, EventArgs e)
        {
            changeSizeMatrix();
        }

        public void changeSizeMatrix()
        {
            int size = (int)numericUpDownSize.Value;

            dataGridViewMatrix.RowCount = size;
            dataGridViewMatrix.ColumnCount = size;
            
            dataGridViewFreeTerms.RowCount = size;
            dataGridViewFreeTerms.ColumnCount = 1;

            dataGridViewCoefficientsA.RowCount = size;
            dataGridViewCoefficientsA.ColumnCount = 1;

            dataGridViewCoefficientsB.RowCount = size;
            dataGridViewCoefficientsB.ColumnCount = 1;

            dataGridViewVector.RowCount = size;
            dataGridViewVector.ColumnCount = 1;
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            int size = (int)numericUpDownSize.Value;

            double[,] Matrix = new double[size, 3];
            double [] FreeTerms = new double[size];
                    
            double [] A = new double[size];
            double [] B = new double[size];
            double [] X = new double[size];

            for (int i = 0; i < size; i++)
            {
                if (i > 0)
                    Matrix[i, 0] = double.Parse(dataGridViewMatrix[i - 1, i].Value.ToString());
                
                Matrix[i , 1] = double.Parse(dataGridViewMatrix[i , i].Value.ToString());

                if (i < size - 1)
                    Matrix[i, 2] = double.Parse(dataGridViewMatrix[i + 1, i].Value.ToString());

                FreeTerms[i] = double.Parse(dataGridViewFreeTerms[0, i].Value.ToString());
            }

            int n = size - 1;

            A[0] = -Matrix[0, 2] / Matrix[0, 1];
            B[0] = FreeTerms[0] / Matrix[0, 1];

            for (int i = 1; i < n; i++)
            {
                A[i] = -Matrix[i, 2] / (Matrix[i, 1] + Matrix[i, 0] * A[i - 1]);
                B[i] = (FreeTerms[i] - Matrix[i, 0] * B[i - 1]) / (Matrix[i, 1] + Matrix[i, 0] * A[i - 1]);
            }
     
            X[n] = (FreeTerms[n] - Matrix[n, 0] * B[n - 1]) / (Matrix[n, 1] + Matrix[n, 0] * A[n - 1]);

            for (int i = n-1; i >= 0; i--)
            {
                X[i] = A[i] * X[i + 1] + B[i];    
            }

            for (int i = 0; i < n; i++)
            {
                dataGridViewCoefficientsA.Rows[i].Cells[0].Value = string.Format("{0:f2}", A[i]);
                dataGridViewCoefficientsB.Rows[i].Cells[0].Value = string.Format("{0:f2}", B[i]);
                dataGridViewVector.Rows[i].Cells[0].Value = string.Format("{0:f2}", X[i]);
            }

            dataGridViewVector.Rows[n].Cells[0].Value = string.Format("{0:f2}", X[n]);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
