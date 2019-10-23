using System;

namespace AJAXExample {

    public partial class AJAXExample : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

        }

        //For C#
        protected void btnSubmit_Click(object sender, EventArgs e) {
            System.Threading.Thread.Sleep(5000);
            lblMsg.Text = "You typed '" + txtName.Text + "' in above textbox";
        }

        //For Vb.net
        //Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs)
        //    Threading.Thread.Sleep(5000)
        //    lblMsg.Text = "You typed '" & txtName.Text & "' in above textbox"
        //End Sub
    }
}