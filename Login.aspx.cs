using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;


using System.Data;


public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)

    {

        Session["Login"] = "Hi my name is Jake";
        /* ********Gathers information from a querystring********
        LabelCurrentDateTime.Text = (DateTime.Now).ToLongDateString();
        LabelReviewerID.Text = Request.QueryString["AccountID"];
        LabelCurrentPage.Text = "RateBooks.aspx?FN=" + (Request.QueryString["FN"]) +
        "&LN=" + (Request.QueryString["LN"]) + "" + "&AccountID=" + (Request.QueryString["AccountID"]);
        //string LabelCurrentPage = HttpContext.Current.Request.Url.AbsoluteUri; */
}
    protected void ButtonLogin_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(TextboxUsername.Text))
        {
            LabelNoUsername.Text = ("Please enter a username");
        }
        if (String.IsNullOrEmpty(TextboxPassword.Text))
        {
            LabelNoPassword.Text = ("Please enter a password");
        }
        if (!String.IsNullOrEmpty(TextboxUsername.Text))
        {
            LabelNoUsername.Text = ("");
        }
        if (!String.IsNullOrEmpty(TextboxPassword.Text))
        {
            LabelNoPassword.Text = ("");
        }
        if (!String.IsNullOrEmpty(TextboxPassword.Text) && (!String.IsNullOrEmpty(TextboxUsername.Text)))
        {
            try
            {
                //========================================================SWITCHERS FOR DATABASE================================================================
                //HOME PC
                //SqlConnection connection = new SqlConnection(@"Data Source=Jakden-PC\SQLEXPRESS;Initial Catalog=DCMA;Integrated Security=True");
                //WORK PC
                //SqlConnection connection = new SqlConnection(@"Data Source=jdennis-pc\SQLEXPRESS;Initial Catalog=dcmaHCCC;Integrated Security=True");
                //LAPTOP
                SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DCMA;Integrated Security=True");
                //(local)\SQLEXPRESS (Jakden-Laptop\Jake Dennis)
                //========================================================SWITCHERS FOR DATABASE================================================================
                connection.Open();

                string dummyun = TextboxUsername.Text;
                string dummypw = TextboxPassword.Text;

                using (SqlCommand StrQuer = new SqlCommand("SELECT * FROM Login WHERE Username=@Username AND Password=@Password", connection))
                {

                    StrQuer.Parameters.AddWithValue("@Username", dummyun);
                    StrQuer.Parameters.AddWithValue("@Password", dummypw);

                    //LabelNoUsername.Text = (dummypw);
                    SqlDataReader dr = StrQuer.ExecuteReader();





                    if (dr.HasRows)
                    {

                        
                        //if Username already exists update username
                        //else 

                        //========================================================SWITCHERS FOR DATABASE================================================================
                        //HOME
                        //SqlConnection conn = new SqlConnection(@"Data Source=Jakden-PC\SQLEXPRESS;Initial Catalog=DCMA;Integrated Security=True");
                        //WORK                       
                        //SqlConnection conn = new SqlConnection(@"Data Source=jdennis-pc\SQLEXPRESS;Initial Catalog=dcmaHCCC;Integrated Security=True");
                        //LAPTOP
                        //SqlConnection conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DCMA;Integrated Security=True");
                        //========================================================SWITCHERS FOR DATABASE================================================================
                        //create session ID
                        connection.Close();
                        SqlCommand sql_sessionid_insert_cmd = new SqlCommand("INSERT INTO SessionID (Username, SessionID) VALUES (@Username, NEWID())", connection);
                        // WORKS +++++++++ "INSERT INTO SessionID (Username, SessionID) VALUES (@Username, NEWID())"
                        // TEST ++++++++++ "INSERT INTO SessionID (Sername, SessionID) VALUES (@Username, @SessionID)";
                        {
                           // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                            // ALSO DELETE LAST USER AND ON ACCOUNT CREATION CREATE 1 SESSION TO ADD TO POOL
                            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                            sql_sessionid_insert_cmd.Parameters.AddWithValue("@Username", dummyun);
                            connection.Open();
                            sql_sessionid_insert_cmd.ExecuteNonQuery();
                            connection.Close();




                            //string dummyun = TextboxUsername.Text;
                            //========================================================SWITCHERS FOR DATABASE================================================================
                            // HOME PC
                            //SqlConnection conn = new SqlConnection(@"Data Source=Jakden-PC\SQLEXPRESS;Initial Catalog=DCMA;Integrated Security=True");
                            // WORK PC
                            //SqlConnection conn = new SqlConnection(@"Data Source=jdennis-pc\SQLEXPRESS;Initial Catalog=dcmaHCCC;Integrated Security=True");
                            //LAPTOP
                            SqlConnection conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DCMA;Integrated Security=True");
                            //========================================================SWITCHERS FOR DATABASE================================================================
                            SqlCommand CreateQS = new SqlCommand("SELECT TOP 1 SessionID FROM SessionID ORDER BY Username DESC", conn);
                            //SqlCommand CreateQS = new SqlCommand("SELECT TOP 1 SessionID FROM SessionID ORDER BY UserID DESC", conn);
                            //SqlCommand CreateQS = new SqlCommand("SELECT TOP 1 * FROM SessionID ORDER BY ID DESC", conn);
                            {
                                conn.Open();
                                // SqlDataReader reader = CreateQS.ExecuteReader();

                                //DataTable datatable = new DataTable();

                                //datatable.Load(reader);

                                // while (reader.Read())
                                //CreateQS.Parameters.AddWithValue("@Password", LabelServerError.Text);

                                LabelQuerystring.Text = CreateQS.ExecuteScalar().ToString();
                                conn.Close();


                                Response.Redirect("CreateTimeSheet.aspx?SessionID=" + LabelQuerystring.Text + "&User=" + dummyun + "");

                            }

                        }




                    }

                    else
                    {
                        LabelServerError.Text = ("Invalid Username and/or Password");
                    }

                }
            }


            catch
            {
                LabelServerError.Text = ("Error no connection to the server");
            }

            finally
            {
                
            }
        }
    }
    protected void ButtonCreateUser_Click(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(TextBoxNewPassword.Text) && (!String.IsNullOrEmpty(TextBoxNewUsername.Text)))
        {
            //========================================================SWITCHERS FOR DATABASE================================================================
            //HOME PC
            //SqlConnection connection = new SqlConnection(@"Data Source=Jakden-PC\SQLEXPRESS;Initial Catalog=DCMA;Integrated Security=True");
            //WORK PC
            //SqlConnection connection = new SqlConnection(@"Data Source=jdennis-pc\SQLEXPRESS;Initial Catalog=dcmaHCCC;Integrated Security=True");
            //LAPTOP
            SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DCMA;Integrated Security=True");
            //========================================================SWITCHERS FOR DATABASE================================================================

            SqlCommand cmd = new SqlCommand("select * from Login where Username = @Username", connection);
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Username";
            param.Value = TextBoxNewUsername.Text;
            cmd.Parameters.Add(param);

            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            
            if (reader.HasRows)
            {
                LabelDuplicateUser.Text = ("Username already exists");  
            }
            else 

            {
            SqlCommand sql_week_insert_cmd = new SqlCommand("INSERT INTO Login (Username, Password, UserID) VALUES (@Username, @Password, NEWID())", connection);
            
            sql_week_insert_cmd.Parameters.AddWithValue("@Username", TextBoxNewUsername.Text);
            sql_week_insert_cmd.Parameters.AddWithValue("@Password", TextBoxNewPassword.Text);
            connection.Close();
            connection.Open();
            sql_week_insert_cmd.ExecuteNonQuery();
            
            }
            connection.Close();
        }
    }
    
}
    //SqlCommand cmd = new SqlCommand("Username,Password From Login WHERE Username='" + TextboxUsername.Text + "' and Password='" + TextboxPassword.Text + "'", connection);

    //This turns the login information into a querystring
    // Check for valid open database connection before query database


    

