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
    public partial class ContextualForm : Form
    {
        protected GUIContext Context;

        public ContextualForm(GUIContext Ctx)
        {
            Context = Ctx;
            OnContextInit();
        }

        public ContextualForm()
        {
        }

        public void SwitchForm(ContextualForm Target)
        {
            Hide();
            Target.Show();
        }

        protected virtual void OnContextInit()
        {
        }

        private void ContextualForm_Load(object sender, EventArgs e)
        {
        }
    }
}
