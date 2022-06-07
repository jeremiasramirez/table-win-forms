namespace table
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.captureNum = new System.Windows.Forms.NumericUpDown();
            this.calcular = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.ListBox();
            this.msjresult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureNum)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.calcular);
            this.panel1.Controls.Add(this.captureNum);
            this.panel1.Location = new System.Drawing.Point(64, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 470);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.msjresult);
            this.panel2.Controls.Add(this.results);
            this.panel2.Location = new System.Drawing.Point(93, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 352);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label1.Size = new System.Drawing.Size(219, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "TABLA DE MULTIPLICAR";
            // 
            // captureNum
            // 
            this.captureNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captureNum.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captureNum.Location = new System.Drawing.Point(118, 47);
            this.captureNum.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.captureNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.captureNum.Name = "captureNum";
            this.captureNum.Size = new System.Drawing.Size(90, 30);
            this.captureNum.TabIndex = 1;
            this.captureNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.captureNum.ValueChanged += new System.EventHandler(this.captureNum_ValueChanged);
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.calcular.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.calcular.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.calcular.Location = new System.Drawing.Point(239, 39);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(125, 53);
            this.calcular.TabIndex = 2;
            this.calcular.Text = "CALCULAR";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // results
            // 
            this.results.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.results.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.results.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.FormattingEnabled = true;
            this.results.ItemHeight = 23;
            this.results.Location = new System.Drawing.Point(82, 16);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(199, 324);
            this.results.TabIndex = 0;
            this.results.SelectedIndexChanged += new System.EventHandler(this.results_SelectedIndexChanged);
            // 
            // msjresult
            // 
            this.msjresult.AutoSize = true;
            this.msjresult.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.msjresult.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msjresult.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.msjresult.Location = new System.Drawing.Point(85, 16);
            this.msjresult.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.msjresult.Name = "msjresult";
            this.msjresult.Padding = new System.Windows.Forms.Padding(58, 2, 32, 2);
            this.msjresult.Size = new System.Drawing.Size(175, 27);
            this.msjresult.TabIndex = 1;
            this.msjresult.Text = "RESULTS";
            this.msjresult.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(567, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Tabla";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.NumericUpDown captureNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox results;
        private System.Windows.Forms.Label msjresult;
    }
}

