﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace For_Exam
{
    public partial class No_8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Text == "Cola")
            {
                Image1.ImageUrl = "~//images//Cola.jpg";
            }
            else if (DropDownList1.SelectedItem.Text == "Pepsi")
            {
                Image1.ImageUrl = "~//images//Pepsi.jpg";
            }
            else if (DropDownList1.SelectedItem.Text == "Chips")
            {
                Image1.ImageUrl = "~//images//Chip.jpg";
            }
            else
            {
                lblPrice.Text = "Something went wrong please try again";
            }
            lblPrice.Text = "Price : " + DropDownList1.SelectedItem.Value;

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (DropDownList1.SelectedItem.Text == "Cola")
            {
                Image1.ImageUrl = "~//images//Cola.jpg";
            }
            else if (DropDownList1.SelectedItem.Text == "Pepsi")
            {
                Image1.ImageUrl = "~//images//Pepsi.jpg";
            }
            else if (DropDownList1.SelectedItem.Text == "Chips")
            {
                Image1.ImageUrl = "~//images//Chip.jpg";
            }
            else
            {
                lblPrice.Text = "Something went wrong please try again";
            }
            lblPrice.Text = "Price : " + DropDownList1.SelectedItem.Value;

        }

        protected void txtQuantity_TextChanged(object sender, EventArgs e)
        {

                int price = int.Parse(DropDownList1.SelectedItem.Value);
                int Qty = int.Parse(txtQuantity.Text);
                int TotalPrice = price * Qty;
                txtTotal.Text = TotalPrice.ToString();
            
      
        }
    }
}