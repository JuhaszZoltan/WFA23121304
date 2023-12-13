namespace WFA23121304
{
    partial class UscBeallitasok
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMinta = new Label();
            cbxBetutipus = new ComboBox();
            lblUI01 = new Label();
            nudBetumeret = new NumericUpDown();
            lblUI02 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudBetumeret).BeginInit();
            SuspendLayout();
            // 
            // lblMinta
            // 
            lblMinta.BackColor = Color.White;
            lblMinta.Location = new Point(76, 119);
            lblMinta.Name = "lblMinta";
            lblMinta.Size = new Size(529, 106);
            lblMinta.TabIndex = 0;
            lblMinta.Text = "Minta Szöveg";
            lblMinta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbxBetutipus
            // 
            cbxBetutipus.FormattingEnabled = true;
            cbxBetutipus.Items.AddRange(new object[] { "Showcard Gothic", "Times New Roman", "Consolas" });
            cbxBetutipus.Location = new Point(76, 313);
            cbxBetutipus.Name = "cbxBetutipus";
            cbxBetutipus.Size = new Size(357, 38);
            cbxBetutipus.TabIndex = 3;
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUI01.Location = new Point(76, 289);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(78, 21);
            lblUI01.TabIndex = 2;
            lblUI01.Text = "betűtípus:";
            // 
            // nudBetumeret
            // 
            nudBetumeret.Location = new Point(507, 315);
            nudBetumeret.Margin = new Padding(5, 6, 5, 6);
            nudBetumeret.Maximum = new decimal(new int[] { 72, 0, 0, 0 });
            nudBetumeret.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudBetumeret.Name = "nudBetumeret";
            nudBetumeret.Size = new Size(98, 36);
            nudBetumeret.TabIndex = 4;
            nudBetumeret.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUI02.Location = new Point(507, 289);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(85, 21);
            lblUI02.TabIndex = 5;
            lblUI02.Text = "betűméret:";
            // 
            // UscBeallitasok
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblUI02);
            Controls.Add(nudBetumeret);
            Controls.Add(cbxBetutipus);
            Controls.Add(lblUI01);
            Controls.Add(lblMinta);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "UscBeallitasok";
            Size = new Size(679, 500);
            ((System.ComponentModel.ISupportInitialize)nudBetumeret).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMinta;
        private ComboBox cbxBetutipus;
        private Label lblUI01;
        private NumericUpDown nudBetumeret;
        private Label lblUI02;
    }
}
