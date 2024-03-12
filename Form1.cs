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
            //workerList2.RowAddedEvent += workList2_RowAddedEvent;
            //workerList2.RowRemovedEvent += workList2_RowRemovedEvent;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
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

            //workerList2.ddAddress.SelectedIndex = 0;
            //workerList2.ddRate.SelectedIndex = 0;
            //workerList2.ddExp.SelectedIndex = 0;
            workerList2.gvWorkerList1.BorderStyle = BorderStyle.None;
            foreach (DataGridViewColumn column in workerList2.gvWorkerList1.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.BackColor = Color.LightBlue;
                column.DefaultCellStyle.BackColor = Color.LightBlue;
                column.DefaultCellStyle.ForeColor = Color.Black;
                column.DividerWidth = 0;
            }
            for (int i = 0; i < 100; i++)
            {
                workerList2.gvWorkerList1.Rows.Add(new object[]
           {
                imageList1.Images[0]
                ,"Hello",
                "Hi",
                "HI"

           });
                tabControl1.SelectedIndex = 1;

            }
        }
        private void bunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {

            workerList2.gvWorkerList1.FirstDisplayedScrollingRowIndex = workerList2.gvWorkerList1.Rows[e.Value].Index;

        }
        private void workList2_RowAddedEvent(object sender, EventArgs e)
        {
            Vscroll.Maximum = workerList2.gvWorkerList1.RowCount - 1;
        }
        private void workList2_RowRemovedEvent(object sender, EventArgs e)
        {
            Vscroll.Maximum = workerList2.gvWorkerList1.RowCount - 1;
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
