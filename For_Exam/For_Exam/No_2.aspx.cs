using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace For_Exam
{
    public partial class No_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSendR_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex != -1)
            {
                ListBox2.Items.Add(ListBox1.SelectedItem.Text);
                ListBox1.Items.Remove(ListBox1.SelectedItem);
      
            }
            lblMessage.Visible = false;
        }

        protected void btnSendL_Click(object sender, EventArgs e)
        {
            if (ListBox2.SelectedIndex != -1)
            {
                ListBox1.Items.Add(ListBox2.SelectedItem.Text);
                ListBox2.Items.Remove(ListBox2.SelectedItem);
                lblMessage.Visible = false;
            }
        }

        protected void btnSendAllR_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in ListBox1.Items.Cast<ListItem>().ToList())
            {
                ListBox2.Items.Add(item);
                ListBox1.Items.Remove(item);
            }
            lblMessage.Visible = false;
        }

        protected void btnSendAllL_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in ListBox2.Items.Cast<ListItem>().ToList())
            {
                ListBox1.Items.Add(item);
                ListBox2.Items.Remove(item);
                
            }
            lblMessage.Visible = false;
        }

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMessage.Text = ListBox2.SelectedItem.Text;
        }
    }
}
