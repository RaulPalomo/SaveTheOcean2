using AC4.Persistence.Mapping;
using AC4.Persistence.Utils;
using SaveTheOcean2.Models;
using SaveTheOcean2.Persistence.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveTheOcean2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            IRescueDAO recordDAO = new RescueDAO(NpgsqlUtils.OpenConnection());
            List<Rescue> rescues = recordDAO.GetRescues();
            dataGridSelectAll.DataSource = rescues;
        }

        private void buttonSearchId_Click(object sender, EventArgs e)
        {
            if(textBoxId.Text == "")
            {
                errorId.SetError(textBoxId, "Please enter an ID");
            }
            else
            {
                try
                {
                    IRescueDAO recordDAO = new RescueDAO(NpgsqlUtils.OpenConnection());
                    List<Rescue> rescue =recordDAO.GetRescueById(textBoxId.Text);
                    dataGridSelectId.DataSource = rescue;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"The rescue with id {textBoxId.Text} doesn't exist");
                }
            }
        }
    }
}
