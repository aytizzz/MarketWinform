using MessagingToolkit.QRCode.Codec;
using System.Diagnostics.Eventing.Reader;

namespace satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        decimal totalp = 0;
        string[] code = { "101", "102", "103" };
        string[] name = { "Kurasan", "Coca-Cola", "Corek" };
        decimal[] price = { 0.75M, 2.40M, 0.7M };
        decimal totalprice = 0;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"
              Kod:101|Kurasan
              Kod:102|Coca-Cola
               Kod:103|Çörek

                 ");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void btnentr_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Mebleg daxil edin");
            }
            else if (totalprice == 0)
            {
                MessageBox.Show("Mehsul elave olunmayib");
            }
            else
            {
                decimal qiymet = decimal.Parse(textBox2.Text);

                if (qiymet < totalprice)
                {
                    label2.Visible = true;
                }
                else
                {
                    label2.Visible = false;
                    label8.Text = $" {qiymet.ToString()} AZN ";
                    decimal qaytarilan = qiymet - totalprice;
                    label7.Text = $" {qaytarilan.ToString()} AZN ";
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == code[0])
            {
                listBox1.Items.Add($"Kod:{code[0]} | Ad: {name[0]} | Qiymət: {price[0]} azn");
                totalprice += price[0];

            }
            else if (textBox1.Text == code[1])
            {
                listBox1.Items.Add($"Kod:{code[1]} | Ad: {name[1]} | Qiymət: {price[1]} azn");
                totalprice += price[1];
            }
            else if (textBox1.Text == code[2])
            {
                listBox1.Items.Add($"Kod:{code[2]} | Ad: {name[2]} | Qiymət: {price[2]} azn");
                totalprice += price[2];
            }
            else
            {
                MessageBox.Show("Mehsul tapilmadi");
            }
            label4.Text = $" {totalprice.ToString()} AZN ";
            decimal edv = totalprice / 100;
            decimal per = edv * 18;

            QRCodeEncoder enc = new QRCodeEncoder();
            pictureBox1.Image = enc.Encode(per.ToString());// qr a cevir menimset


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
