using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PDS2CS12
{
    public partial class formproduct : Form
    {
        DBconnect cn = new DBconnect();
        string[] strHead = { "ລະຫັດສິນຄ້າ", "ບາໂຄດ", "ຊື່ສີນຄ້າ", "ປະເພດສີນຄ້າ", "ຈຳນວນ" };
        int[] col = { 50, 100 ,150,150,150};

        public formproduct()
        {
            InitializeComponent();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void formproduct_Load(object sender, EventArgs e)
        {
            showData();
            for (int i = 0; i < strHead.Length; i++)
            {
                dgvProduct.Columns[i].HeaderText = strHead[i];
                dgvProduct.Columns[i].Width = col[i];
            }
            dgvProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            dgvProduct.EnableHeadersVisualStyles = false;

        }
        private void showData()
        {
            string sqlPro = "select * from tbproduct";
            cn.getData(sqlPro);
            dgvProduct.DataSource = cn.dt;
        }
    }
}
