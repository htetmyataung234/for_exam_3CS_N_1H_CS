using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Building_ASP.NET_Pages.For_Exam
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            msg.Visible = false;
            Page.Validate();
            if (Page.IsValid)
            {
                msg.Text = "Logged in succefully";
                msg.Visible = true;
            }
            else
            {
                if (!CompareValidator1.IsValid)
                {
                    msg.Text = "Passwords dosent match";


                }
                else if (!RegularExpressionValidator1.IsValid)
                {
                    msg.Text = "Plase enter valid email";

                }
                else
                {
                    msg.Text = "Please enter valid email and enter same passwords for both field";


                }
                msg.Visible = true;
            }

        }
    }
}
