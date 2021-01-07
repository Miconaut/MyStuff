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
    public partial class MainForm : ContextualForm
    {
        public MainForm(GUIContext Ctx) : base(Ctx)
        {
        }

        protected override void OnContextInit()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            SwitchForm(Context.SignInForm);
        }
    }
}
