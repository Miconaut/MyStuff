using Drawing3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp_1_1
{
    public class GUIContext
    {
        public SignIn SignInForm;
        public Drawing DrawingForm;
        public CreateAccount CreateAccountForm;

        public GUIContext()
        {
            SignInForm = new SignIn(this);
            DrawingForm = new Drawing(this);
            CreateAccountForm = new CreateAccount(this);
        }

        public Form GetContextInitForm()
        {
            return SignInForm;
        }
    }
}
