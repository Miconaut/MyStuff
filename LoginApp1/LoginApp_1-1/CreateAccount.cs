using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp_1_1
{
    public partial class CreateAccount : ContextualForm
    {
        public CreateAccount(GUIContext Ctx) : base(Ctx)
        {           
        }

        protected override void OnContextInit()
        {
            InitializeComponent();
        }

        private void Signin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = labelCreate;
        }

        private void textBoxFN_Enter(object sender, EventArgs e)
        {
            String fname = textBoxFN.Text;
            if (fname.Trim().Equals("First name"))
            {
                textBoxFN.Text = "";
                textBoxFN.ForeColor = Color.Black;
            }
        }

        private void textBoxFN_Leave(object sender, EventArgs e)
        {
            String fname = textBoxFN.Text;
            if (fname.Trim().Equals("First name") || fname.Trim().Equals(""))
            {
                textBoxFN.Text = "First name";
                textBoxFN.ForeColor = Color.Gray;
            }
        }


        private void textBoxLN_Enter(object sender, EventArgs e)
        {
            String lName = textBoxLN.Text;
            if (lName.Trim().Equals("Last name"))
            {
                textBoxLN.Text = "";
                textBoxLN.ForeColor = Color.Black;
            }
        }


        private void textBoxLN_Leave(object sender, EventArgs e)
        {
            String lName = textBoxLN.Text;
            if (lName.Trim().Equals("Last name") || lName.Trim().Equals(""))
            {
                textBoxLN.Text = "Last name";
                textBoxLN.ForeColor = Color.Gray;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.Trim().Equals("Email address"))
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.Trim().Equals("Email address") || email.Trim().Equals(""))
            {
                textBoxEmail.Text = "Email address";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void textBoxUsn_Enter(object sender, EventArgs e)
        {
            String username = textBoxUsn.Text;
            if (username.Trim().Equals("Username"))
            {
                textBoxUsn.Text = "";
                textBoxUsn.ForeColor = Color.Black;
            }
        }

        private void textBoxUsn_Leave(object sender, EventArgs e)
        {
            String username = textBoxUsn.Text;
            if (username.Trim().Equals("Username") || username.Trim().Equals(""))
            {
                textBoxUsn.Text = "Username";
                textBoxUsn.ForeColor = Color.Gray;
            }
        }

        private void textBoxPass_Enter(object sender, EventArgs e)
        {
            String password = textBoxPass.Text;
            if (password.Trim().Equals("Password"))
            {
                textBoxPass.Text = "";
                textBoxPass.UseSystemPasswordChar = true;
                textBoxPass.ForeColor = Color.Black;
            }
        }

        private void textBoxPass_Leave(object sender, EventArgs e)
        {
            String password = textBoxPass.Text;
            if (password.Trim().Equals("Password") || password.Trim().Equals(""))
            {
                textBoxPass.Text = "Password";
                textBoxPass.UseSystemPasswordChar = false;
                textBoxPass.ForeColor = Color.Gray;
            }

        }

        private void textBoxPassCon_Enter(object sender, EventArgs e)
        {
            String passwordCon = textBoxPassCon.Text;
            if (passwordCon.Trim().Equals("Confirm password"))
            {
                textBoxPassCon.Text = "";
                textBoxPassCon.UseSystemPasswordChar = true;
                textBoxPassCon.ForeColor = Color.Black;
            }
        }

        private void textBoxPassCon_Leave(object sender, EventArgs e)
        {
            String cpasswordCon = textBoxPassCon.Text;
            if (cpasswordCon.Trim().Equals("Confirm password") ||
                cpasswordCon.Trim().Equals("Password") ||
                cpasswordCon.Trim().Equals(""))
            {
                textBoxPassCon.Text = "Confirm password";
                textBoxPassCon.UseSystemPasswordChar = false;
                textBoxPassCon.ForeColor = Color.Gray;
            }
        }

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.LightSteelBlue;
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.FromName("Highlight");
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void labelLogIn_MouseEnter(object sender, EventArgs e)
        {
            labelBackSignIn.ForeColor = Color.LightSteelBlue;
        }

        private void labelLogIn_MouseLeave(object sender, EventArgs e)
        {
            labelBackSignIn.ForeColor = Color.FromName("Highlight");
        }

        private void labelLogIn_Click(object sender, EventArgs e)
        {
            SwitchForm(Context.SignInForm);
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`firstname`, `lastname`, `emailaddress`, `username`, `password`) VALUES (@fn, @ln, @email, @usn, @pass)", db.GetConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textBoxFN.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = textBoxLN.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUsn.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPass.Text;

            db.OpenConnection();

            if (!CheckTextBoxesValues())
            {
                if (textBoxPass.Text.Equals(textBoxPassCon.Text))
                {
                    if (checkUsername())
                    {
                        MessageBox.Show("This username already exists, select s different one", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your account has been created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            SwitchForm(Context.SignInForm);
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong confirmation cassword", "Password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter your informations first", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            db.CloseConnection();
        }

        public Boolean checkUsername()
        {
            DB db = new DB();

            String username = textBoxUsn.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn", db.GetConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean CheckTextBoxesValues()
        {
            String fN = textBoxFN.Text;
            String lN = textBoxLN.Text;
            String email = textBoxEmail.Text;
            String username = textBoxUsn.Text;
            String password = textBoxPass.Text;

            if (fN.Equals("First name") || lN.Equals("Last name") || email.Equals("Email address") || username.Equals("Username") || password.Equals("Password"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}