using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtnEtn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CarSalonEntities d;

            try
            {
                InitializeComponent();

                RegForm rf = new RegForm();
                DialogResult res = rf.ShowDialog(this);

                if (res == DialogResult.Cancel)
                    throw new Exception("Войдите в учетную запись");

                string log = rf.login_t.Text;
                string pass = rf.pass_t.Text;

                if (log.Length == 0 || pass.Length == 0)
                    throw new Exception("Некорректный ввод");

                System.Data.SqlClient.SqlConnectionStringBuilder c = new System.Data.SqlClient.SqlConnectionStringBuilder
                {
                    DataSource = "DESKTOP-5E4TI3A\\SQLEXPRESS",
                    InitialCatalog = "CarSalon",
                    Password = pass,
                    UserID = pass
                };

                d = new CarSalonEntities(c.ConnectionString);

                this.Fill();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Fill()
        {
            this.ConTable.DataSource = DBConnection.Entities.Contracts.ToList();
        }

        private void ConTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            Contract c = this.ConTable.Rows[e.RowIndex].DataBoundItem as Contract;
            Form2 f = new Form2(c);
            f.ShowDialog();
            this.Fill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contract c = new Contract { ConDate = DateTime.Today };
            Form2 f = new Form2(c);
            f.ShowDialog();
            this.Fill();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            List<Contract> l = DBConnection.Entities.Contracts.ToList();
            List<Contract> li = new List<Contract>();

            foreach (Contract c in l)
            {
                if (c.Car1.Mark == mark_t.Text)
                    li.Add(c);
            }

            this.ConTable.DataSource = li;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            this.Fill();
        }
    }
}
