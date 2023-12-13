using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA23121304
{
    public partial class UscBeallitasok : UserControl
    {
        public FrmMain FrmMain { get; set; }
        public UscBeallitasok(FrmMain frmMain)
        {
            FrmMain = frmMain;
            InitializeComponent();
            cbxBetutipus.SelectedIndexChanged += FontStyleChanged;
            nudBetumeret.ValueChanged += FontStyleChanged;
        }

        private void FontStyleChanged(object? sender, EventArgs e)
        {
            lblMinta.Font = new(
                cbxBetutipus.Text,
                (float)nudBetumeret.Value);

            FrmMain.Betustilus = cbxBetutipus.Text;
            FrmMain.Betumeret = (float)nudBetumeret.Value;
        }
    }
}
