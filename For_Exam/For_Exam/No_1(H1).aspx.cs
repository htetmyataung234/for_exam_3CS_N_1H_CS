using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace For_Exam
{
    public partial class No_1_H1_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            if (ImageButton1.ImageUrl == "~//images//blue.png")
            {
                ImageButton1.ImageUrl = "~//images//red.png";
                Image2.Visible = false;

            }
            else
            {
                ImageButton1.ImageUrl = "~//images//blue.png";
                Image2.Visible = false;
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (ImageButton1.ImageUrl == "~//images//blue.png")
            {
                Image2.Visible = true;
                Image2.ImageUrl = "~//images//blue.png";

            }
            else
            {
                Image2.Visible = true;
                Image2.ImageUrl = "~//images//red.png";
            }
        }
    }
}