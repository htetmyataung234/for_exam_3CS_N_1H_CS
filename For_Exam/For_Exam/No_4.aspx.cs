using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO; //file နဲ့  save ခြင်ရင် ဒါထည့်
using System.Data;
using System.Data.SqlClient;//SQL database နဲ့  save ခြင်ရင် ဒါထည့်
namespace For_Exam
{
    public partial class No_4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {   
            
            string connection = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string Query = "INSERT INTO Data(Name,Password,Gender,Address) VALUES (@Name,@Password,@Gender,@Address)";
            using (SqlCommand com = new SqlCommand(Query,con))
            {
                com.Parameters.Add("@Name",txtName.Text);
                com.Parameters.Add("@Password",txtPassword.Text);
                if (rdoMale.Checked == true) 
                {
                    com.Parameters.Add("@Gender", rdoMale.Text);
                }
                if (rdoFemale.Checked == true)
                {
                    com.Parameters.Add("@Gender", rdoMale.Text);
                }
                com.Parameters.Add("@Address", dropAddress.SelectedItem.Text);
                com.ExecuteNonQuery();
            }
            lblMessage.Text = "Saved to database successfully";

        }
    }
}