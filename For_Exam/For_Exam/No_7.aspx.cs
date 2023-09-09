using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace For_Exam
{
    public partial class No_7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            // Check if the same data already exists
            string checkQuery = "SELECT COUNT(*) FROM EmployeeTable WHERE Employee_ID = @Employee_ID";
            using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
            {
                checkCmd.Parameters.AddWithValue("@Employee_ID", txtEmployeeID.Text);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
          
                    string updateQuery = "UPDATE EmployeeTable SET Name = @Name, Password = @Password, Address = @Address WHERE Employee_ID = @Employee_ID";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@Employee_ID", txtEmployeeID.Text);
                        updateCmd.Parameters.AddWithValue("@Name", txtName.Text);
                        updateCmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        updateCmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                        updateCmd.ExecuteNonQuery();
                    }

                    lblMsg.Text = "Record updated successfully";
                }
                else
                {
              
                    string insertQuery = "INSERT INTO EmployeeTable (Employee_ID, Name, Password, Address) VALUES (@Employee_ID, @Name, @Password, @Address)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@Employee_ID", txtEmployeeID.Text);
                        insertCmd.Parameters.AddWithValue("@Name", txtName.Text);
                        insertCmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        insertCmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                        insertCmd.ExecuteNonQuery();
                    }

                    lblMsg.Text = "Record saved successfully";
                }
            }

            con.Close();
            GridView1.DataBind();
        }


        protected void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {

                txtEmployeeID.Text = GridView1.Rows[0].Cells[0].Text;
                txtName.Text = GridView1.Rows[0].Cells[1].Text;
                txtPassword.Text = GridView1.Rows[0].Cells[2].Text;
                txtAddress.Text = GridView1.Rows[0].Cells[3].Text;
            }
            catch (Exception ex)
            {
                lblMsg.Text = "No data in database";
            }
            GridView1.DataBind();
        }

        

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
          

            // Check if the same data already exists
            string deleteQuery = "Delete EmployeeTable WHERE Employee_ID = @Employee_ID";
            using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, con))
            {
                deleteCmd.Parameters.AddWithValue("@Employee_ID", txtEmployeeID.Text);
                deleteCmd.ExecuteNonQuery();
            }
            lblMsg.Text = "Deleted successfully!!";

            GridView1.DataBind();
        }
        }
}