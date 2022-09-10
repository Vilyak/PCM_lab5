
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSize = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewFreeTerms = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewCoefficientsB = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewVector = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewCoefficientsA = new System.Windows.Forms.DataGridView();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreeTerms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoefficientsB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoefficientsA)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(3, 20);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(27, 15);
            this.labelSize.TabIndex = 3;
            this.labelSize.Text = "Size";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonSolve);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridViewFreeTerms);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewMatrix);
            this.panel1.Controls.Add(this.labelSize);
            this.panel1.Controls.Add(this.numericUpDownSize);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 289);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "free variables";
            // 
            // dataGridViewFreeTerms
            // 
            this.dataGridViewFreeTerms.AllowUserToAddRows = false;
            this.dataGridViewFreeTerms.AllowUserToDeleteRows = false;
            this.dataGridViewFreeTerms.AllowUserToResizeColumns = false;
            this.dataGridViewFreeTerms.AllowUserToResizeRows = false;
            this.dataGridViewFreeTerms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewFreeTerms.ColumnHeadersVisible = false;
            this.dataGridViewFreeTerms.Location = new System.Drawing.Point(432, 47);
            this.dataGridViewFreeTerms.Name = "dataGridViewFreeTerms";
            this.dataGridViewFreeTerms.RowHeadersVisible = false;
            this.dataGridViewFreeTerms.RowHeadersWidth = 20;
            this.dataGridViewFreeTerms.RowTemplate.Height = 20;
            this.dataGridViewFreeTerms.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFreeTerms.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewFreeTerms.Size = new System.Drawing.Size(73, 227);
            this.dataGridViewFreeTerms.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Matrix:";
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.AllowUserToAddRows = false;
            this.dataGridViewMatrix.AllowUserToDeleteRows = false;
            this.dataGridViewMatrix.AllowUserToResizeColumns = false;
            this.dataGridViewMatrix.AllowUserToResizeRows = false;
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMatrix.ColumnHeadersVisible = false;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(3, 47);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.RowHeadersVisible = false;
            this.dataGridViewMatrix.RowHeadersWidth = 20;
            this.dataGridViewMatrix.RowTemplate.Height = 20;
            this.dataGridViewMatrix.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(423, 227);
            this.dataGridViewMatrix.TabIndex = 8;
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.Location = new System.Drawing.Point(36, 18);
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(68, 23);
            this.numericUpDownSize.TabIndex = 2;
            this.numericUpDownSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSize.ValueChanged += new System.EventHandler(this.numericUpDownSize_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dataGridViewCoefficientsB);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dataGridViewVector);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dataGridViewCoefficientsA);
            this.panel2.Location = new System.Drawing.Point(548, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 289);
            this.panel2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "B";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridViewCoefficientsB
            // 
            this.dataGridViewCoefficientsB.AllowUserToAddRows = false;
            this.dataGridViewCoefficientsB.AllowUserToDeleteRows = false;
            this.dataGridViewCoefficientsB.AllowUserToResizeColumns = false;
            this.dataGridViewCoefficientsB.AllowUserToResizeRows = false;
            this.dataGridViewCoefficientsB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCoefficientsB.ColumnHeadersVisible = false;
            this.dataGridViewCoefficientsB.Enabled = false;
            this.dataGridViewCoefficientsB.Location = new System.Drawing.Point(134, 47);
            this.dataGridViewCoefficientsB.Name = "dataGridViewCoefficientsB";
            this.dataGridViewCoefficientsB.RowHeadersVisible = false;
            this.dataGridViewCoefficientsB.RowHeadersWidth = 20;
            this.dataGridViewCoefficientsB.RowTemplate.Height = 20;
            this.dataGridViewCoefficientsB.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCoefficientsB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewCoefficientsB.Size = new System.Drawing.Size(96, 227);
            this.dataGridViewCoefficientsB.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "undefined vector";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridViewVector
            // 
            this.dataGridViewVector.AllowUserToAddRows = false;
            this.dataGridViewVector.AllowUserToDeleteRows = false;
            this.dataGridViewVector.AllowUserToResizeColumns = false;
            this.dataGridViewVector.AllowUserToResizeRows = false;
            this.dataGridViewVector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewVector.ColumnHeadersVisible = false;
            this.dataGridViewVector.Enabled = false;
            this.dataGridViewVector.Location = new System.Drawing.Point(251, 47);
            this.dataGridViewVector.Name = "dataGridViewVector";
            this.dataGridViewVector.RowHeadersVisible = false;
            this.dataGridViewVector.RowHeadersWidth = 20;
            this.dataGridViewVector.RowTemplate.Height = 20;
            this.dataGridViewVector.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVector.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewVector.Size = new System.Drawing.Size(96, 227);
            this.dataGridViewVector.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "A";
            // 
            // dataGridViewCoefficientsA
            // 
            this.dataGridViewCoefficientsA.AllowUserToAddRows = false;
            this.dataGridViewCoefficientsA.AllowUserToDeleteRows = false;
            this.dataGridViewCoefficientsA.AllowUserToResizeColumns = false;
            this.dataGridViewCoefficientsA.AllowUserToResizeRows = false;
            this.dataGridViewCoefficientsA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCoefficientsA.ColumnHeadersVisible = false;
            this.dataGridViewCoefficientsA.Enabled = false;
            this.dataGridViewCoefficientsA.Location = new System.Drawing.Point(12, 47);
            this.dataGridViewCoefficientsA.Name = "dataGridViewCoefficientsA";
            this.dataGridViewCoefficientsA.RowHeadersVisible = false;
            this.dataGridViewCoefficientsA.RowHeadersWidth = 20;
            this.dataGridViewCoefficientsA.RowTemplate.Height = 20;
            this.dataGridViewCoefficientsA.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCoefficientsA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewCoefficientsA.Size = new System.Drawing.Size(96, 227);
            this.dataGridViewCoefficientsA.TabIndex = 12;
            // 
            // buttonSolve
            // 
            this.buttonSolve.Location = new System.Drawing.Point(110, 12);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(141, 30);
            this.buttonSolve.TabIndex = 16;
            this.buttonSolve.Text = "Solve";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 314);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreeTerms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoefficientsB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoefficientsA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewFreeTerms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewVector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewCoefficientsA;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewCoefficientsB;
    }
}

