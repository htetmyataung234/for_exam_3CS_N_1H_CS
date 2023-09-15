using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace For_Exam
{
    public partial class No3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack != true)
            {
                ArrayList item = new ArrayList();
            }
            lblMessage.Text = "";
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (ListBox1.Items.Contains(DropDownList1.SelectedItem))
            { 
                lblMessage.Text = "Item already exist";
            }
            else
            {
                ListBox1.Items.Add(DropDownList1.SelectedItem.Text);
                lblMessage.Text = "";
            }
            
        }

        protected void btnFill_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in DropDownList1.Items)
            {
                ListBox1.Items.Add(item);
            }
            lblMessage.Text = "";
        }

        protected void btnSort_Click(object sender, EventArgs e)
        {
            ArrayList Items = new ArrayList();
            foreach (ListItem item in ListBox1.Items)
            {
                Items.Add(item.Text);
            }
            Items.Sort();
            ListBox1.Items.Clear();
            foreach (String item in Items)
            {
                ListBox1.Items.Add(item);
            }
            lblMessage.Text = "";
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            lblMessage.Text = "";
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Sorry we can't force close a webpage with Just Pure Asp.net in c# ^^";
        }
       
    }
}