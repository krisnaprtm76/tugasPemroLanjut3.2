namespace Tugas3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var nama = textNama.Text;
            var pendidikan = comboPendidikan.Text;
            var pekerjaan = lstPekerjaan.Text;

            textPesan1.Text = string.Format("Hallo {0}", nama);
            textPesan2.Text = string.Format("Pendidikan Anda {0} ya?", pendidikan);
            textPesan3.Text = string.Format("Anda Seorang {0}, Hebat!!!", pekerjaan);
        }
    }
}