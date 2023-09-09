using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace For_Exam
{
    public partial class No_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            if (Image1.ImageUrl == "~//images//blue.png")
            {
                Image1.ImageUrl = "~//images//red.png";

            }
            else
            {
                Image1.ImageUrl = "~//images//blue.png";

            }

        }


    }
}