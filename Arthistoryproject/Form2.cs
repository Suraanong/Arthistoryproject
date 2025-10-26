using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arthistoryproject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();

            // แสดง Form3
            f3.Show();

            // ซ่อน Form2 (หรือใช้ Close() ถ้าไม่ต้องกลับมา)
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();

            // แสดง Form3
            f3.Show();

            // ซ่อน Form2 (หรือใช้ Close() ถ้าไม่ต้องกลับมา)
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            // แสดงหน้า Form1
            f1.Show();

            // ปิดหน้า Form2 ปัจจุบัน
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
