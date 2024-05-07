using System;
using System.Data;
using AC4.Persistence.Mapping;
using SaveTheOcean2.Models;
using SaveTheOcean2.Persistence.DAO;
using Npgsql;
using SaveTheOcean2.Persistence;
using AC4.Persistence.Utils;
namespace SaveTheOcean2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Hide();
            dataGridView2.Hide();
            labelOptions.Hide();
            LabelResult.Hide();
            cbOptions.Hide();
            btnAccept.Hide();
            cbOfici.Hide();
            label2.Hide();
            label1.Hide();
            textBoxName.Hide();
            btnRescat.Hide();
            cbOfici.Items.Add("Vet");
            cbOfici.Items.Add("Tecnician");
            cbOptions.Items.Add("Rescue there");
            cbOptions.Items.Add("Bring the animal to the center");
            Helper.CreatePersonaXml();
            Rescue rescue = new Rescue();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRescat_Click(object sender, EventArgs e)
        {
            LabelResult.Hide();
            cbOptions.Text = "";
            if (textBoxName.Text == "")
            {
                errorName.SetError(textBoxName, "Please enter a name");
            }
            else if (cbOfici.SelectedIndex == -1)
            {
                errorOfici.SetError(cbOfici, "Please select an occupation");
            }
            else
            {
                errorOfici.Clear();
                errorName.Clear();
                Rescue rescue = new Rescue();
                dataGridView1.DataSource = new List<Rescue> { rescue };
                dataGridView2.DataSource = new List<AAnimal> { rescue.Animal };
                dataGridView1.Show();
                dataGridView2.Show();
                labelOptions.Show();
                cbOptions.Show();
                btnAccept.Show();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cbOptions.SelectedIndex == -1)
            {
                errorAction.SetError(cbOptions, "Please select an action");
            }
            else
            {
                errorAction.Clear();
                List<Rescue> rescues = (List<Rescue>)dataGridView1.DataSource;

                Rescue rescue = rescues[0];
                int x = 0;
                if (cbOptions.SelectedIndex == 1)
                {

                    if (rescue.Animal.SuperFamily == "Cetaci")
                    {
                        x = 50;
                    }
                    else if (rescue.Animal.SuperFamily == "Tortuga marina")
                    {
                        x = 15;
                    }
                    else
                    {
                        x = 5;
                    }
                }
                else if (cbOptions.SelectedIndex == 2)
                {

                    if (rescue.Animal.SuperFamily == "Cetaci")
                    {
                        x = 0;
                    }
                    else if (rescue.Animal.SuperFamily == "Tortuga marina")
                    {
                        x = 15;
                    }
                    else
                    {
                        x = 0;
                    }
                }
                Persona persona= new Persona(textBoxName.Text, cbOfici.Text);
                if (rescue.Animal.CalcGA(rescue.GA, x) < 30)
                {
                    LabelResult.Text = "The animal has been cured, you gain 50 xp";
                    persona.Xp += 50;
                }
                else
                {
                    LabelResult.Text = "The animal has not been cured, you lose 20 xp";
                    persona.Xp -= 20;
                }
                Helper.AppendPerson(persona);
                LabelResult.Show();
                IRescueDAO recordDAO = new RescueDAO(NpgsqlUtils.OpenConnection());
                recordDAO.AddRescue(rescue);
            }

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            label1.Show();
            label2.Show();
            textBoxName.Show();
            cbOfici.Show();
            btnRescat.Show();
            btnPlay.Hide();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultes_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
