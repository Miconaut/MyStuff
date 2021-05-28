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

namespace PlanovacZnamek
{
    public partial class PlanovacZnamek : Form
    {        
        public PlanovacZnamek()
        {
            InitializeComponent();

            ObnoveniZnamek();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MIKE\source\repos\C_Sharp\Moje\PlanovacZnamek1-2\PlanovacZnamek\Znamky2.mdf;Integrated Security=True");

        private void buttonPridat_Click(object sender, EventArgs e)
        {
            if (comboBoxPredmet.Text.Equals("") && comboBoxZnamka.Text.Equals("") && comboBoxVaha.Text.Equals(""))
            {
                MessageBox.Show("Vyplňte všechna pole pro přidání záznamu", "Prázdná pole", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxPredmet.Text.Equals("") && comboBoxZnamka.Text.Equals(""))
            {
                MessageBox.Show("Zadejte předmět a známku pro přidání záznamu", "Prázdný předmět a známka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxPredmet.Text.Equals("") && comboBoxVaha.Text.Equals(""))
            {
                MessageBox.Show("Zadejte předmět a váhu známky pro přidání záznamu", "Prázdný předmět a váha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxZnamka.Text.Equals("") && comboBoxVaha.Text.Equals(""))
            {
                MessageBox.Show("Zadejte známku a váhu známky pro přidání záznamu", "Prázdná známka a váha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxPredmet.Text.Equals(""))
            {
                MessageBox.Show("Zadejte předmět pro přidání záznamu", "Prázdný předmět", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxZnamka.Text.Equals(""))
            {
                MessageBox.Show("Zadejte známku pro přidání záznamu", "Prázdná známka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxVaha.Text.Equals(""))
            {
                MessageBox.Show("Zadejte váhu známky pro přidání záznamu", "Prázdná váha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if (textBoxPopis.Text.Equals(""))
            {
                DialogResult dialogResult = MessageBox.Show("Chcete pokračovat bez poznámky?", "Prázdná poznámka", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    PridaniZnamek();
                }
            }
            else
            {
                PridaniZnamek();
            }
        }

        private void buttonObnovit_Click(object sender, EventArgs e)
        {
            ObnoveniZnamek();

            MessageBox.Show("Obnoveno!", "Tabulka obnovena");
        }

        private void ObnoveniZnamek()
        {
            int index = 0;

            connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Znamky2", connection);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            dataGridView.DataSource = dataTable;

            foreach (DataGridViewRow r in dataGridView.Rows)
            {
                r.Cells[0].Value = index++;
            }

            //dataGridView.Columns["Id"].Visible = false;
            connection.Close();
        }

        private void PridaniZnamek()
        {
            int index = 0;

            connection.Open();
            while (true)
            {
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Znamky2(Id,Predmet,Znamka,Vaha,Datum,Popis) values('" + index + "','" + comboBoxPredmet.Text + "','" + comboBoxZnamka.Text + "','" + comboBoxVaha.Text + "','" + dateTimePickerDatum.Text + "','" + textBoxPopis.Text + "')", connection);
                    command.ExecuteNonQuery();
                    break;
                }
                catch (Exception)
                {
                    index++;
                }
            }

            connection.Close();

            ObnoveniZnamek();

            MessageBox.Show("Přidáno!", "Známka přidána", MessageBoxButtons.OK, MessageBoxIcon.Information);

            comboBoxPredmet.SelectedIndex = 0;
            comboBoxZnamka.SelectedIndex = 0;
            comboBoxVaha.SelectedIndex = 0;
            textBoxPopis.Clear();
        }

        private void buttonOdstranitRadek_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chcete odstranit vybraný řádek?", "Odstranit řádek", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int id = dataGridView.CurrentCell.RowIndex;

                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Znamky2 WHERE Id ='" + dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value.ToString() + "'", connection);               
                command.ExecuteNonQuery();
                connection.Close();

                ObnoveniZnamek();

                MessageBox.Show("Odstraněno!", "Známka odstraněna", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonOdstranitVse_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chcete odstranit vše?\n \nTuto akci nelze vzít zpět.", "Odstranit vše", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connection.Open();
                //var index = dataGridView.CurrentCell.RowIndex;
                //SqlCommand command = new SqlCommand("DELETE FROM Znamky WHERE '" + dataGridView.CurrentCell.RowIndex + "' = '" + index + "'", connection);
                SqlCommand command = new SqlCommand("DELETE FROM Znamky2", connection);
                command.ExecuteNonQuery();
                connection.Close();

                ObnoveniZnamek();

                MessageBox.Show("Odstraněno!", "Známky odstraněny", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonVypocitatPrumer_Click(object sender, EventArgs e)
        {
            string predmet = comboBoxPredmetPrumer.Text;

            double sum = 0;
            double dataCount = 0;

            foreach (DataGridViewRow r in dataGridView.Rows)
            {
                if (r.Cells[1].Value.ToString() == predmet)
                {
                    dataCount += Convert.ToInt32(r.Cells[2].Value);
                }
            }

            for (int i = 0; i <= dataGridView.Rows.Count - 1; i++)
            {
                if (dataGridView.Rows[i].Cells[0].Value.ToString() == predmet)
                {
                    double num1 = double.Parse(dataGridView.Rows[i].Cells[2].Value.ToString());
                    double num2 = double.Parse(dataGridView.Rows[i].Cells[3].Value.ToString());
                    double num = num1 * num2;

                    sum = sum + num;
                }                
            }

            double avg = sum / dataCount;
            textBoxPrumer.Text = avg.ToString("0.000");
        }
    }
}
