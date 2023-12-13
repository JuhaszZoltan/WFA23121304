namespace WFA23121304
{
    public partial class FrmMain : Form
    {
        public UscSzovegszerkeszto UscSzovegSzerk { get; set; }
        public UscBeallitasok UscBeallitasok { get; set; }

        public string Betustilus { get; set; } = "Segoe UI";
        public float Betumeret { get; set; } = 16f;

        public FrmMain()
        {
            UscSzovegSzerk = new(this);
            UscBeallitasok = new(this);
            InitializeComponent();
            this.Load += UsrLoad_Load;
            tsmiSzovegszerkeszto.Click += UsrLoad_Load;
            tsmiBeallitasok.Click += TsmiBeallitasok_Click;
            tsmiTeszt.Click += TsmiTeszt_Click;
        }

        private void TsmiTeszt_Click(object? sender, EventArgs e)
        {
            string txt = $"style: {Betustilus}; size: {Betumeret}";
            MessageBox.Show(txt);
        }

        private void TsmiBeallitasok_Click(object? sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(UscBeallitasok);
            UscBeallitasok.Select();
        }

        private void UsrLoad_Load(object? sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(UscSzovegSzerk);
            UscSzovegSzerk.Select();
        }
    }
}
