using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security; //Add this


namespace For_Exam
{
    public partial class No_6_H1_ : System.Web.UI.Page
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

        protected void btnRandom_Click(object sender, EventArgs e)
        {
            msg.Text = "Your randomly generated password is : " + Membership.GeneratePassword(12, 4);
            msg.Visible = true;
        }
    }
}
