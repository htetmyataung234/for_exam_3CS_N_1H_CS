using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Building_ASP.NET_Pages.For_Exam
{
    public partial class save : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string output = "Username : " + TextBox1.Text + "\n" + "Password : " + TextBox2.Text + "\n";
            if (m.Checked)
            {
                output = output + "Gender   : " + m.Text;
            }
            else if (fm.Checked)5
            {
                output = output + "Gender   : " + fm.Text + "\n";
            }
            File.WriteAllText(Server.MapPath("~\\For Exam\\output.txt"), write);
            msg.Text = "Saved information with output.txt file.";
        }
    }
}