namespace WFA23121304
{
    public partial class UscSzovegszerkeszto : UserControl
    {
        public FrmMain FrmMain { get; set; }

        public UscSzovegszerkeszto(FrmMain frmMain)
        {
            FrmMain = frmMain;
            InitializeComponent();
            this.Load += UscSzovegszerkeszto_Load;
            tbxSzoveg.TextChanged += TbxSzoveg_TextChanged;
            cbxIgazitas.SelectedIndexChanged += CbxIgazitas_SelectedIndexChanged;
            cbxSzin.SelectedIndexChanged += CbxSzin_SelectedIndexChanged;
            this.VisibleChanged += UscSzovegszerkeszto_VisibleChanged;
        }

        private void UscSzovegszerkeszto_VisibleChanged(object? sender, EventArgs e)
        {
            lblSzoveg.Font = new(
                    FrmMain.Betustilus,
                    FrmMain.Betumeret);
        }

        private void CbxSzin_SelectedIndexChanged(object? sender, EventArgs e)
        {
            switch (cbxSzin.Text)
            {
                case "kék":
                    lblSzoveg.ForeColor = Color.Blue;
                    break;
                case "zöld":
                    lblSzoveg.ForeColor = Color.Green;
                    break;
                case "piros":
                    lblSzoveg.ForeColor = Color.Red;
                    break;
                case "sárga":
                    lblSzoveg.ForeColor = Color.Yellow;
                    break;
            }
        }

        private void CbxIgazitas_SelectedIndexChanged(object? sender, EventArgs e)
        {
            switch (cbxIgazitas.Text)
            {
                case "jobb-közép":
                    lblSzoveg.TextAlign = ContentAlignment.MiddleRight;
                    break;
                case "közép-közép":
                    lblSzoveg.TextAlign = ContentAlignment.MiddleCenter;
                    break;
                case "bal-közép":
                    lblSzoveg.TextAlign = ContentAlignment.MiddleLeft;
                    break;
            }
        }

        private void UscSzovegszerkeszto_Load(object? sender, EventArgs e)
        {
            cbxIgazitas.Items.AddRange(new string[]{"jobb-közép", "közép-közép", "bal-közép"});
            cbxSzin.Items.AddRange(new string[] { "kék", "zöld", "piros", "sárga" });
        }

        private void TbxSzoveg_TextChanged(object? sender, EventArgs e)
        {
            lblSzoveg.Text = tbxSzoveg.Text;
        }
    }
}
