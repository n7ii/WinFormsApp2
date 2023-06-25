using PDS2CS12;
using System.Data.SqlTypes;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        DBconnect con = new DBconnect();
        string[] strHead = { "ລະຫັດປະເພດ", "ຊື່ປະເພດສີນຄ້າ" };
        int[] col = { 100, 200 };
        public Form1()
        {
            InitializeComponent();
        }
        private void showData()
        {
            con.getData("select * from tbcategory");
            dgvCat.DataSource = con.dt;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ຊື່ພະເພດສິນຄ້າ_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btedit.Enabled = false;
            btdete.Enabled = false;
            btsave.Enabled = true;
            showData();
            for (int i = 0; i < strHead.Length; i++)
            {
                dgvCat.Columns[i].HeaderText = strHead[i];
                dgvCat.Columns[i].Width = col[i];
            }
            dgvCat.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            dgvCat.EnableHeadersVisualStyles = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSave = "insert into tbcategory(catname) values(N'" + txtname.Text + "')";
                con.exeCuteData(sqlSave);
                MessageBox.Show("ບັນທຶກແລ້ວ");
                showData();
                txtid.Clear();
                txtid.Clear();
                txtid.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btedit.Enabled = true;
                btdete.Enabled = true;
                btsave.Enabled = false;
                DataGridViewRow row = this.dgvCat.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txtname.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }//end of CellClick

        private void btdete_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlDel = "delete from tbcategory where catid=" + txtid.Text;
                if (MessageBox.Show("ທ່ານຕ້ອງການລຶບຂໍ້ມຼນນີ້ ແທ້ ຫຼື ບໍ່?", "ຢືນຢັນ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    con.exeCuteData(sqlDel);
                    showData();
                    txtid.Clear();
                    txtname.Clear();
                    txtname.Focus();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlUp = "update tbcategory set catname =N'"+txtname.Text+"' where catid="+txtid.Text;
                if (MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂຂໍ້ມຼນນີ້ ແທ້ ຫຼື ບໍ່?", "ຢືນຢັນ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    con.exeCuteData(sqlUp);
                    showData();
                    txtid.Clear();
                    txtname.Clear();
                    txtname.Focus();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}