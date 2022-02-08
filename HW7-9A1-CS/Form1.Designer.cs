namespace MyHomework
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRecalc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.NbTrials = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.NbIterations = new System.Windows.Forms.NumericUpDown();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NbTrials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbIterations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecalc
            // 
            this.btnRecalc.BackColor = System.Drawing.Color.Transparent;
            this.btnRecalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRecalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecalc.ForeColor = System.Drawing.Color.Black;
            this.btnRecalc.Location = new System.Drawing.Point(321, 28);
            this.btnRecalc.Name = "btnRecalc";
            this.btnRecalc.Size = new System.Drawing.Size(79, 42);
            this.btnRecalc.TabIndex = 4;
            this.btnRecalc.Text = "Recalc";
            this.btnRecalc.UseVisualStyleBackColor = false;
            this.btnRecalc.Click += new System.EventHandler(this.btnRecalc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(17, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "n (Trials)";
            // 
            // NbTrials
            // 
            this.NbTrials.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbTrials.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.NbTrials.Location = new System.Drawing.Point(83, 23);
            this.NbTrials.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NbTrials.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NbTrials.Name = "NbTrials";
            this.NbTrials.Size = new System.Drawing.Size(76, 23);
            this.NbTrials.TabIndex = 20;
            this.NbTrials.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NbTrials.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NbTrials.ValueChanged += new System.EventHandler(this.NbTrials_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(10, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "N. Iterations";
            // 
            // NbIterations
            // 
            this.NbIterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbIterations.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NbIterations.Location = new System.Drawing.Point(83, 52);
            this.NbIterations.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NbIterations.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NbIterations.Name = "NbIterations";
            this.NbIterations.Size = new System.Drawing.Size(76, 23);
            this.NbIterations.TabIndex = 22;
            this.NbIterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NbIterations.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NbIterations.ValueChanged += new System.EventHandler(this.NbIterations_ValueChanged);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Location = new System.Drawing.Point(19, 94);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(849, 483);
            this.MainPanel.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(487, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(381, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "You can move the chart inside the viewport or resize it using bottom-right corner" +
    "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(194, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "σ (Variance)  = 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(194, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "m (Mean) = 50:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(888, 598);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.NbIterations);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NbTrials);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRecalc);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Bernoulli Process";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NbTrials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbIterations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRecalc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NbTrials;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NbIterations;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

