namespace WFA23121304
{
    partial class UscSzovegszerkeszto
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
            lblUI01 = new Label();
            tbxSzoveg = new TextBox();
            lblSzoveg = new Label();
            lblUI02 = new Label();
            cbxIgazitas = new ComboBox();
            lblUI03 = new Label();
            cbxSzin = new ComboBox();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(150, 109);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(86, 30);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "szöveg:";
            // 
            // tbxSzoveg
            // 
            tbxSzoveg.Location = new Point(242, 106);
            tbxSzoveg.Name = "tbxSzoveg";
            tbxSzoveg.Size = new Size(319, 36);
            tbxSzoveg.TabIndex = 0;
            // 
            // lblSzoveg
            // 
            lblSzoveg.BackColor = Color.White;
            lblSzoveg.Location = new Point(150, 177);
            lblSzoveg.Name = "lblSzoveg";
            lblSzoveg.Size = new Size(411, 118);
            lblSzoveg.TabIndex = 2;
            lblSzoveg.Text = "###placeholder###";
            lblSzoveg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUI02.Location = new Point(150, 317);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(65, 21);
            lblUI02.TabIndex = 0;
            lblUI02.Text = "igazítás:";
            // 
            // cbxIgazitas
            // 
            cbxIgazitas.FormattingEnabled = true;
            cbxIgazitas.Location = new Point(150, 341);
            cbxIgazitas.Name = "cbxIgazitas";
            cbxIgazitas.Size = new Size(196, 38);
            cbxIgazitas.TabIndex = 1;
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUI03.Location = new Point(365, 317);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(40, 21);
            lblUI03.TabIndex = 0;
            lblUI03.Text = "szín:";
            // 
            // cbxSzin
            // 
            cbxSzin.FormattingEnabled = true;
            cbxSzin.Location = new Point(365, 341);
            cbxSzin.Name = "cbxSzin";
            cbxSzin.Size = new Size(196, 38);
            cbxSzin.TabIndex = 2;
            // 
            // UscSzovegszerkeszto
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbxSzin);
            Controls.Add(cbxIgazitas);
            Controls.Add(lblSzoveg);
            Controls.Add(lblUI03);
            Controls.Add(tbxSzoveg);
            Controls.Add(lblUI02);
            Controls.Add(lblUI01);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "UscSzovegszerkeszto";
            Size = new Size(700, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private TextBox tbxSzoveg;
        private Label lblSzoveg;
        private Label lblUI02;
        private ComboBox cbxIgazitas;
        private Label lblUI03;
        private ComboBox cbxSzin;
    }
}
