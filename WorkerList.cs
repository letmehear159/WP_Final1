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
    public partial class WorkerList : UserControl
    {
        public event EventHandler RowAddedEvent;
        public event EventHandler RowRemovedEvent;
        public WorkerList()
        {
            InitializeComponent();
        }

        private void bunifuDropdown3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonDataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            OnRowAddedEvent(EventArgs.Empty);
        }

        private void kryptonDataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            OnRowRemovedEvent(EventArgs.Empty);
        }

        protected virtual void OnRowAddedEvent(EventArgs e)
        {
            RowAddedEvent?.Invoke(this, e);
        }
        protected virtual void OnRowRemovedEvent(EventArgs e)
        {
            RowRemovedEvent?.Invoke(this, e);
        }

        private void kryptonDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                //if (gvWorkerList.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                //{
                //    // Lấy đối tượng DataGridViewButtonCell từ ô hiện tại
                //    DataGridViewButtonCell buttonCell = gvWorkerList.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;

                //    // Kiểm tra thuộc tính của buttonCell
                //    if (buttonCell != null)
                //    {
                //        // Ví dụ: Thiết lập text cho nút
                //        // Ví dụ: Thiết lập màu nền cho nút
                //        buttonCell.Style.BackColor = Color.Red;

                //        // Ví dụ: Thiết lập màu văn bản cho nút
                //        buttonCell.Style.ForeColor = Color.White;
                //    }
                //}
            }
            if (e.ColumnIndex == 2)
            {
            }

        }
    }
}
