namespace WFA23121304
{
    partial class FrmMain
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
            mnuMain = new MenuStrip();
            tsmiFeluletek = new ToolStripMenuItem();
            tsmiSzovegszerkeszto = new ToolStripMenuItem();
            tsmiBeallitasok = new ToolStripMenuItem();
            pnlMain = new Panel();
            tsmiTeszt = new ToolStripMenuItem();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            mnuMain.Items.AddRange(new ToolStripItem[] { tsmiFeluletek, tsmiTeszt });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(724, 38);
            mnuMain.TabIndex = 0;
            mnuMain.Text = "menuStrip1";
            // 
            // tsmiFeluletek
            // 
            tsmiFeluletek.DropDownItems.AddRange(new ToolStripItem[] { tsmiSzovegszerkeszto, tsmiBeallitasok });
            tsmiFeluletek.Name = "tsmiFeluletek";
            tsmiFeluletek.Size = new Size(112, 34);
            tsmiFeluletek.Text = "Felületek";
            // 
            // tsmiSzovegszerkeszto
            // 
            tsmiSzovegszerkeszto.Name = "tsmiSzovegszerkeszto";
            tsmiSzovegszerkeszto.Size = new Size(255, 34);
            tsmiSzovegszerkeszto.Text = "szövegszerkesztő";
            // 
            // tsmiBeallitasok
            // 
            tsmiBeallitasok.Name = "tsmiBeallitasok";
            tsmiBeallitasok.Size = new Size(255, 34);
            tsmiBeallitasok.Text = "beállítások";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.RosyBrown;
            pnlMain.Location = new Point(12, 41);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(700, 500);
            pnlMain.TabIndex = 1;
            // 
            // tsmiTeszt
            // 
            tsmiTeszt.Name = "tsmiTeszt";
            tsmiTeszt.Size = new Size(73, 34);
            tsmiTeszt.Text = "Teszt";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 552);
            Controls.Add(pnlMain);
            Controls.Add(mnuMain);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = mnuMain;
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmMain";
            Text = "User Controls";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem tsmiFeluletek;
        private ToolStripMenuItem tsmiSzovegszerkeszto;
        private ToolStripMenuItem tsmiBeallitasok;
        private Panel pnlMain;
        private ToolStripMenuItem tsmiTeszt;
    }
}
