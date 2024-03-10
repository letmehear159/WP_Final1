using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void pbExit_MouseHover(object sender, EventArgs e)
        {
        }

        private void pbExit_Move(object sender, EventArgs e)
        {


        }

        private void pbExit_MouseMove(object sender, MouseEventArgs e)
        {
            pbExit.BackColor = Color.Green;
        }

        private void pbExit_MouseLeave(object sender, EventArgs e)
        {
            pbExit.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            workerList2.dropDownOccupation.SelectedIndex = 0;
            workerList2.ddAddress.SelectedIndex = 0;
            workerList2.ddRate.SelectedIndex = 0;
            workerList2.ddExp.SelectedIndex = 0;
            workerList2.gvWorkerList.Rows.Add(new object[]
            {
                "String",3
            });
            workerList2.gvWorkerList.Rows.Add(new object[]
           {
                "String",3
           });
            workerList2.gvWorkerList.Rows.Add(new object[]
           {
                "String",3
           });
            workerList2.gvWorkerList.Rows.Add(new object[]
           {
                "String",3
           });
            workerList2.gvWorkerList.Rows.Add(new object[]
           {
                "String",3
           });
        }
    }
}
