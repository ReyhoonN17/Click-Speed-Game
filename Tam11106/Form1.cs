namespace Tam11106
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Blue)
            {
                btn.Visible = false;
                label2.Text = (int.Parse(label2.Text) - 1).ToString();
            }
            else
            {
                MessageBox.Show(":( باختییییییی", "خاااااااک تو سرت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            if (label2.Text == "0")
            {
                timer1.Enabled = false;
                MessageBox.Show(":) بردییییییی", "عافرییین عشقممممممم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int num = 0;
            foreach (Button b in panel1.Controls)
            {
                if (rand.Next(0, 2) == 0)
                {
                    b.BackColor = Color.Blue;
                    num++;
                }
            }
            label2.Text = num.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = (int.Parse(label4.Text) + 1).ToString();
        }
    }
}