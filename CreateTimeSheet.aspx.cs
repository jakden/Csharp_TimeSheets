using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;


public partial class CreateTimeSheet : System.Web.UI.Page
{



   /*  public static List<Student> GetStudents()
    {
        // Use a collection initializer to create the data source. Note that each element
        //  in the list contains an inner sequence of scores.
        List<Student> students = new List<Student>
        {
           new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 72, 81, 60}},
           new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
           new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {99, 89, 91, 95}},
           new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {72, 81, 65, 84}},
           new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {97, 89, 85, 82}} 
        }; */
    protected void Page_Load(object sender, EventArgs e)
    {
        //NEED TO ADD IN QUERYSTRING GRABBER
        

        // retrieves query string values
        string SessionID = Page.Request.QueryString["SessionID"];
        string Username = Page.Request.QueryString["User"];

        LabelQuerystring1.Text = SessionID;
        LabelQuerystring2.Text = Username;
        
        // CHANGE WHATS BELOW TO MATCH THE LOGIN MATCHING FORM

        //Datareader to see if the querystring exists in the database
                //========================================================SWITCHERS FOR DATABASE================================================================
                //HOME PC
                //SqlConnection connection = new SqlConnection(@"Data Source=Jakden-PC\SQLEXPRESS;Initial Catalog=DCMA;Integrated Security=True");
                //WORK PC
                //SqlConnection connection = new SqlConnection(@"Data Source=jdennis-pc\SQLEXPRESS;Initial Catalog=dcmaHCCC;Integrated Security=True");
                //LAPTOP
                SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DCMA;Integrated Security=True");
                //========================================================SWITCHERS FOR DATABASE================================================================
                connection.Open();
                string Sessionrdr = LabelQuerystring1.Text;
                string Userdr = LabelQuerystring2.Text;
                //string dummyun = TextboxUsername.Text;
                //string dummypw = TextboxPassword.Text;
       

                using (SqlCommand StrQuer = new SqlCommand("SELECT * FROM SessionID WHERE SessionID=@SessionID and Username=@Username", connection))
                {
                    //string Session = Page.Request.QueryString["SessionID"];
                    StrQuer.Parameters.AddWithValue("@SessionID", Sessionrdr);
                    StrQuer.Parameters.AddWithValue("@Username", Userdr);
                    //StrQuer.Parameters.AddWithValue("@Password", dummypw);

                    //LabelNoUsername.Text = (dummypw);
                    SqlDataReader dr = StrQuer.ExecuteReader();



                    if (dr.HasRows)
                    {

                    }
                    else
                    {
                        Response.Redirect("Login.aspx");
                    }


                }



        DayOfWeek Today = DateTime.Now.DayOfWeek;
        LabelDayName.Text = (String) Session["Login"];
        LabelTodayDate.Text = (DateTime.Now).ToString("MM/dd/yyyy");

        DateTime Cal = Convert.ToDateTime(LabelTodayDate.Text);

        if ((Today).ToString() == "Monday")
        {
            LabelMonday.Text = (Cal.AddDays(0)).ToString("MM/dd/yyyy");
            LabelTuesday.Text = (Cal.AddDays(1)).ToString("MM/dd/yyyy");
            LabelWednesday.Text = (Cal.AddDays(2)).ToString("MM/dd/yyyy");
            LabelThursday.Text = (Cal.AddDays(3)).ToString("MM/dd/yyyy");
            LabelFriday.Text = (Cal.AddDays(4)).ToString("MM/dd/yyyy");
            LabelSaturday.Text = (Cal.AddDays(5)).ToString("MM/dd/yyyy");
            LabelSunday.Text = (Cal.AddDays(6)).ToString("MM/dd/yyyy");
        }
        if ((Today).ToString() == "Tuesday")
        {
            LabelMonday.Text = (Cal.AddDays(-1)).ToString("MM/dd/yyyy");
            LabelTuesday.Text = (Cal.AddDays(0)).ToString("MM/dd/yyyy");
            LabelWednesday.Text = (Cal.AddDays(1)).ToString("MM/dd/yyyy");
            LabelThursday.Text = (Cal.AddDays(2)).ToString("MM/dd/yyyy");
            LabelFriday.Text = (Cal.AddDays(3)).ToString("MM/dd/yyyy");
            LabelSaturday.Text = (Cal.AddDays(4)).ToString("MM/dd/yyyy");
            LabelSunday.Text = (Cal.AddDays(5)).ToString("MM/dd/yyyy");
        }
        if ((Today).ToString() == "Wednesday")
        {
            LabelMonday.Text = (Cal.AddDays(-2)).ToString("MM/dd/yyyy");
            LabelTuesday.Text = (Cal.AddDays(-1)).ToString("MM/dd/yyyy");
            LabelWednesday.Text = (Cal.AddDays(0)).ToString("MM/dd/yyyy");
            LabelThursday.Text = (Cal.AddDays(1)).ToString("MM/dd/yyyy");
            LabelFriday.Text = (Cal.AddDays(2)).ToString("MM/dd/yyyy");
            LabelSaturday.Text = (Cal.AddDays(3)).ToString("MM/dd/yyyy");
            LabelSunday.Text = (Cal.AddDays(4)).ToString("MM/dd/yyyy");
        }
        if ((Today).ToString() == "Thursday")
        {
            LabelMonday.Text = (Cal.AddDays(-3)).ToString("MM/dd/yyyy");
            LabelTuesday.Text = (Cal.AddDays(-2)).ToString("MM/dd/yyyy");
            LabelWednesday.Text = (Cal.AddDays(-1)).ToString("MM/dd/yyyy");
            LabelThursday.Text = (Cal.AddDays(0)).ToString("MM/dd/yyyy");
            LabelFriday.Text = (Cal.AddDays(1)).ToString("MM/dd/yyyy");
            LabelSaturday.Text = (Cal.AddDays(2)).ToString("MM/dd/yyyy");
            LabelSunday.Text = (Cal.AddDays(3)).ToString("MM/dd/yyyy");
        }
        if ((Today).ToString() == "Friday")
        {
            LabelMonday.Text = (Cal.AddDays(-4)).ToString("MM/dd/yyyy");
            LabelTuesday.Text = (Cal.AddDays(-3)).ToString("MM/dd/yyyy");
            LabelWednesday.Text = (Cal.AddDays(-2)).ToString("MM/dd/yyyy");
            LabelThursday.Text = (Cal.AddDays(-1)).ToString("MM/dd/yyyy");
            LabelFriday.Text = (Cal.AddDays(0)).ToString("MM/dd/yyyy");
            LabelSaturday.Text = (Cal.AddDays(1)).ToString("MM/dd/yyyy");
            LabelSunday.Text = (Cal.AddDays(2)).ToString("MM/dd/yyyy");
        }
        if ((Today).ToString() == "Saturday")
        {
            LabelMonday.Text = (Cal.AddDays(-5)).ToString("MM/dd/yyyy");
            LabelTuesday.Text = (Cal.AddDays(-4)).ToString("MM/dd/yyyy");
            LabelWednesday.Text = (Cal.AddDays(-3)).ToString("MM/dd/yyyy");
            LabelThursday.Text = (Cal.AddDays(-2)).ToString("MM/dd/yyyy");
            LabelFriday.Text = (Cal.AddDays(-1)).ToString("MM/dd/yyyy");
            LabelSaturday.Text = (Cal.AddDays(0)).ToString("MM/dd/yyyy");
            LabelSunday.Text = (Cal.AddDays(1)).ToString("MM/dd/yyyy");
        }
        if ((Today).ToString() == "Sunday")
        {
            LabelMonday.Text = (Cal.AddDays(-6)).ToString("MM/dd/yyyy");
            LabelTuesday.Text = (Cal.AddDays(-5)).ToString("MM/dd/yyyy");
            LabelWednesday.Text = (Cal.AddDays(-4)).ToString("MM/dd/yyyy");
            LabelThursday.Text = (Cal.AddDays(-3)).ToString("MM/dd/yyyy");
            LabelFriday.Text = (Cal.AddDays(-2)).ToString("MM/dd/yyyy");
            LabelSaturday.Text = (Cal.AddDays(-1)).ToString("MM/dd/yyyy");
            LabelSunday.Text = (Cal.AddDays(0)).ToString("MM/dd/yyyy");

            
        }
        LabelStartDate.Text = LabelMonday.Text;
        LabelEndDate.Text = LabelSunday.Text;


        if (!Page.IsPostBack)
        {
          

            DDL_In_Monday.Items.Add(new ListItem("From"));
            DDL_OutBreak_Monday.Items.Add(new ListItem("----"));
            DDL_InBreak_Monday.Items.Add(new ListItem("----"));
            DDL_Out_Monday.Items.Add(new ListItem("To"));
  
            DDL_In_Tuesday.Items.Add(new ListItem("From"));
            DDL_OutBreak_Tuesday.Items.Add(new ListItem("----"));
            DDL_InBreak_Tuesday.Items.Add(new ListItem("----"));
            DDL_Out_Tuesday.Items.Add(new ListItem("To"));

            DDL_In_Wednesday.Items.Add(new ListItem("From"));
            DDL_OutBreak_Wednesday.Items.Add(new ListItem("----"));
            DDL_InBreak_Wednesday.Items.Add(new ListItem("----"));
            DDL_Out_Wednesday.Items.Add(new ListItem("To"));

            DDL_In_Thursday.Items.Add(new ListItem("From"));
            DDL_OutBreak_Thursday.Items.Add(new ListItem("----"));
            DDL_InBreak_Thursday.Items.Add(new ListItem("----"));
            DDL_Out_Thursday.Items.Add(new ListItem("To"));

            DDL_In_Friday.Items.Add(new ListItem("From"));
            DDL_OutBreak_Friday.Items.Add(new ListItem("----"));
            DDL_InBreak_Friday.Items.Add(new ListItem("----"));
            DDL_Out_Friday.Items.Add(new ListItem("To"));

            DDL_In_Saturday.Items.Add(new ListItem("From"));
            DDL_OutBreak_Saturday.Items.Add(new ListItem("----"));
            DDL_InBreak_Saturday.Items.Add(new ListItem("----"));
            DDL_Out_Saturday.Items.Add(new ListItem("To"));

            DDL_In_Sunday.Items.Add(new ListItem("From"));
            DDL_OutBreak_Sunday.Items.Add(new ListItem("----"));
            DDL_InBreak_Sunday.Items.Add(new ListItem("----"));
            DDL_Out_Sunday.Items.Add(new ListItem("To"));

            int input = 1;
            DateTime Mondayfrom1 = DateTime.Today;
            DateTime Mondayto1 = DateTime.Today;
            DateTime Mondayfrom2 = DateTime.Today;
            DateTime Mondayto2 = DateTime.Today;  // more to's and from's for each equation

            DateTime Tuesdayfrom1 = DateTime.Today;
            DateTime Tuesdayto1 = DateTime.Today;
            DateTime Tuesdayfrom2 = DateTime.Today;
            DateTime Tuesdayto2 = DateTime.Today;

            DateTime Wednesdayfrom1 = DateTime.Today;
            DateTime Wednesdayto1 = DateTime.Today;
            DateTime Wednesdayfrom2 = DateTime.Today;
            DateTime Wednesdayto2 = DateTime.Today; 

            DateTime Thursdayfrom1 = DateTime.Today;
            DateTime Thursdayto1 = DateTime.Today;
            DateTime Thursdayfrom2 = DateTime.Today;
            DateTime Thursdayto2 = DateTime.Today; 

            DateTime Fridayfrom1 = DateTime.Today;
            DateTime Fridayto1 = DateTime.Today;
            DateTime Fridayfrom2 = DateTime.Today;
            DateTime Fridayto2 = DateTime.Today; 

            DateTime Saturdayfrom1 = DateTime.Today;
            DateTime Saturdayto1 = DateTime.Today;
            DateTime Saturdayfrom2 = DateTime.Today;
            DateTime Saturdayto2 = DateTime.Today; 

            DateTime Sundayfrom1 = DateTime.Today;
            DateTime Sundayto1 = DateTime.Today;
            DateTime Sundayfrom2 = DateTime.Today;
            DateTime Sundayto2 = DateTime.Today; 


            while (Mondayfrom1.Date == DateTime.Today)
            {
                DDL_In_Monday.Items.Add(new ListItem(Mondayfrom1.ToString("HH:mm:ss"), Mondayfrom1.ToShortTimeString()));
                Mondayfrom1 = Mondayfrom1.AddMinutes(15 * input);
                DDL_OutBreak_Monday.Items.Add(new ListItem(Mondayto1.ToString("HH:mm:ss"), Mondayto1.ToShortTimeString()));
                Mondayto1 = Mondayto1.AddMinutes(15 * input);
                DDL_InBreak_Monday.Items.Add(new ListItem(Mondayfrom2.ToString("HH:mm:ss"), Mondayfrom2.ToShortTimeString()));
                Mondayfrom2 = Mondayfrom2.AddMinutes(15 * input);
                DDL_Out_Monday.Items.Add(new ListItem(Mondayto2.ToString("HH:mm:ss"), Mondayto2.ToShortTimeString()));
                Mondayto2 = Mondayto2.AddMinutes(15 * input);

                DDL_In_Tuesday.Items.Add(new ListItem(Tuesdayfrom1.ToString("HH:mm:ss"), Tuesdayfrom1.ToShortTimeString()));
                Tuesdayfrom1 = Tuesdayfrom1.AddMinutes(15 * input);
                DDL_OutBreak_Tuesday.Items.Add(new ListItem(Tuesdayto1.ToString("HH:mm:ss"), Tuesdayto1.ToShortTimeString()));
                Tuesdayto1 = Tuesdayto1.AddMinutes(15 * input);
                DDL_InBreak_Tuesday.Items.Add(new ListItem(Tuesdayfrom2.ToString("HH:mm:ss"), Tuesdayfrom2.ToShortTimeString()));
                Tuesdayfrom2 = Tuesdayfrom2.AddMinutes(15 * input);
                DDL_Out_Tuesday.Items.Add(new ListItem(Tuesdayto2.ToString("HH:mm:ss"), Tuesdayto2.ToShortTimeString()));
                Tuesdayto2 = Tuesdayto2.AddMinutes(15 * input);
        
                DDL_In_Wednesday.Items.Add(new ListItem(Wednesdayfrom1.ToString("HH:mm:ss"), Wednesdayfrom1.ToShortTimeString()));
                Wednesdayfrom1 = Wednesdayfrom1.AddMinutes(15 * input);
                DDL_OutBreak_Wednesday.Items.Add(new ListItem(Wednesdayto1.ToString("HH:mm:ss"), Wednesdayto1.ToShortTimeString()));
                Wednesdayto1 = Wednesdayto1.AddMinutes(15 * input);
                DDL_InBreak_Wednesday.Items.Add(new ListItem(Wednesdayfrom2.ToString("HH:mm:ss"), Wednesdayfrom2.ToShortTimeString()));
                Wednesdayfrom2 = Wednesdayfrom2.AddMinutes(15 * input);
                DDL_Out_Wednesday.Items.Add(new ListItem(Wednesdayto2.ToString("HH:mm:ss"), Wednesdayto2.ToShortTimeString()));
                Wednesdayto2 = Wednesdayto2.AddMinutes(15 * input);

                DDL_In_Thursday.Items.Add(new ListItem(Thursdayfrom1.ToString("HH:mm:ss"), Thursdayfrom1.ToShortTimeString()));
                Thursdayfrom1 = Thursdayfrom1.AddMinutes(15 * input);
                DDL_OutBreak_Thursday.Items.Add(new ListItem(Thursdayto1.ToString("HH:mm:ss"), Thursdayto1.ToShortTimeString()));
                Thursdayto1 = Thursdayto1.AddMinutes(15 * input);
                DDL_InBreak_Thursday.Items.Add(new ListItem(Thursdayfrom2.ToString("HH:mm:ss"), Thursdayfrom2.ToShortTimeString()));
                Thursdayfrom2 = Thursdayfrom2.AddMinutes(15 * input);
                DDL_Out_Thursday.Items.Add(new ListItem(Thursdayto2.ToString("HH:mm:ss"), Thursdayto2.ToShortTimeString()));
                Thursdayto2 = Thursdayto2.AddMinutes(15 * input);

                DDL_In_Friday.Items.Add(new ListItem(Fridayfrom1.ToString("HH:mm:ss"), Fridayfrom1.ToShortTimeString()));
                Fridayfrom1 = Fridayfrom1.AddMinutes(15 * input);
                DDL_OutBreak_Friday.Items.Add(new ListItem(Fridayto1.ToString("HH:mm:ss"), Fridayto1.ToShortTimeString()));
                Fridayto1 = Fridayto1.AddMinutes(15 * input);
                DDL_InBreak_Friday.Items.Add(new ListItem(Fridayfrom2.ToString("HH:mm:ss"), Fridayfrom2.ToShortTimeString()));
                Fridayfrom2 = Fridayfrom2.AddMinutes(15 * input);
                DDL_Out_Friday.Items.Add(new ListItem(Fridayto2.ToString("HH:mm:ss"), Fridayto2.ToShortTimeString()));
                Fridayto2 = Fridayto2.AddMinutes(15 * input);

                DDL_In_Saturday.Items.Add(new ListItem(Saturdayfrom1.ToString("HH:mm:ss"), Saturdayfrom1.ToShortTimeString()));
                Saturdayfrom1 = Saturdayfrom1.AddMinutes(15 * input);
                DDL_OutBreak_Saturday.Items.Add(new ListItem(Saturdayto1.ToString("HH:mm:ss"), Saturdayto1.ToShortTimeString()));
                Saturdayto1 = Saturdayto1.AddMinutes(15 * input);
                DDL_InBreak_Saturday.Items.Add(new ListItem(Saturdayfrom2.ToString("HH:mm:ss"), Saturdayfrom2.ToShortTimeString()));
                Saturdayfrom2 = Saturdayfrom2.AddMinutes(15 * input);
                DDL_Out_Saturday.Items.Add(new ListItem(Saturdayto2.ToString("HH:mm:ss"), Saturdayto2.ToShortTimeString()));
                Saturdayto2 = Saturdayto2.AddMinutes(15 * input);

                DDL_In_Sunday.Items.Add(new ListItem(Sundayfrom1.ToString("HH:mm:ss"), Sundayfrom1.ToShortTimeString()));
                Sundayfrom1 = Sundayfrom1.AddMinutes(15 * input);
                DDL_OutBreak_Sunday.Items.Add(new ListItem(Sundayto1.ToString("HH:mm:ss"), Sundayto1.ToShortTimeString()));
                Sundayto1 = Sundayto1.AddMinutes(15 * input);
                DDL_InBreak_Sunday.Items.Add(new ListItem(Sundayfrom2.ToString("HH:mm:ss"), Sundayfrom2.ToShortTimeString()));
                Sundayfrom2 = Sundayfrom2.AddMinutes(15 * input);
                DDL_Out_Sunday.Items.Add(new ListItem(Sundayto2.ToString("HH:mm:ss"), Sundayto2.ToShortTimeString()));
                Sundayto2 = Sundayto2.AddMinutes(15 * input); 
            }
        }
    }
    protected void ButtonCalculate_Click(object sender, EventArgs e)
    {
        //DropDownList2.Items.Clear();
        //DropDownList2.SelectedValue = null;

        //DropDownList3.Items.Clear();
        //DropDownList3.SelectedValue = null;
        LabelErrorMonday.Text = "";

        //-----------------MONDAY
        if (DDL_OutBreak_Monday.SelectedValue == "----")
        {
            DDL_OutBreak_Monday.SelectedValue = DateTime.Parse("00:00:00").ToShortTimeString();
            //DDL_Out_Monday.Enabled = true;
        }
        if (DDL_InBreak_Monday.SelectedValue == "----")
        {
            DDL_InBreak_Monday.SelectedValue = DateTime.Parse("00:00:00").ToShortTimeString();
        }
        if (DDL_Out_Monday.SelectedValue == "To")
        {
            LabelErrorMonday.Text = "Error: Monday end time must be selected";
        }
        if (DDL_In_Monday.SelectedValue == "From")
        {
            LabelErrorMonday.Text = "Error: Monday start time must be selected";
        }
        else if ((DDL_In_Monday.SelectedValue != "From") & (DDL_Out_Monday.SelectedValue != "To"))
        {
            LabelErrorMonday.Text = "";
        }
        //---------------TUESDAY
        if (DDL_OutBreak_Tuesday.SelectedValue == "----")
        {
            DDL_OutBreak_Tuesday.SelectedValue = DateTime.Parse("00:00:00").ToShortTimeString();
        }

        if (DDL_InBreak_Tuesday.SelectedValue == "----")
        {
            DDL_InBreak_Tuesday.SelectedValue = DateTime.Parse("00:00:00").ToShortTimeString();
        }
        if (DDL_Out_Tuesday.SelectedValue == "To")
        {
            LabelErrorTuesday.Text = " Error: Tuesday end time must be selected";
        }
        if (DDL_In_Tuesday.SelectedValue == "From")
        {
            LabelErrorTuesday.Text = " Error: Tuesday start time must be selected";
        }
        else if ((DDL_In_Tuesday.SelectedValue != "From") & (DDL_Out_Tuesday.SelectedValue != "To"))
        {
            LabelErrorTuesday.Text = "";
        }
        //--------------WEDNESDAY
        if (DDL_OutBreak_Wednesday.SelectedValue == "----")
        {
            DDL_OutBreak_Wednesday.SelectedValue = DateTime.Parse("00:00:00").ToShortTimeString();
        }

        if (DDL_InBreak_Wednesday.SelectedValue == "----")
        {
            DDL_InBreak_Wednesday.SelectedValue = DateTime.Parse("00:00:00").ToShortTimeString();
        }
        if (DDL_Out_Wednesday.SelectedValue == "To")
        {
            LabelErrorWednesday.Text = " Error: Wednesday end time must be selected";
        }
        if (DDL_In_Wednesday.SelectedValue == "From")
        {
            LabelErrorWednesday.Text = " Error: Wednesday start time must be selected";
        }
        else if ((DDL_In_Wednesday.SelectedValue != "From") & (DDL_Out_Wednesday.SelectedValue != "To"))
        {
            LabelErrorWednesday.Text = "";
        }
        //--------------THURSDAY
        if (DDL_OutBreak_Thursday.SelectedValue == "----")
        {
            DDL_OutBreak_Thursday.SelectedValue = DateTime.Parse("00:00:00").ToShortTimeString();
        }

        if (DDL_InBreak_Thursday.SelectedValue == "----")
        {
            DDL_InBreak_Thursday.SelectedValue = DateTime.Parse("00:00:00").ToShortTimeString();
        }
        if (DDL_Out_Thursday.SelectedValue == "To")
        {
            LabelErrorThursday.Text = " Error: Thursday end time must be selected";
        }
        if (DDL_In_Thursday.SelectedValue == "From")
        {
            LabelErrorThursday.Text = " Error: Thursday start time must be selected";
        }
        else if ((DDL_In_Thursday.SelectedValue != "From") & (DDL_Out_Thursday.SelectedValue != "To"))
        {
            LabelErrorThursday.Text = "";
        }
        //--------------FRIDAY
        if (DDL_OutBreak_Friday.SelectedValue == "----")
        {
            DDL_OutBreak_Friday.SelectedValue = DateTime.Parse("00:00:00").ToShortTimeString();
        }

        if (DDL_InBreak_Friday.SelectedValue == "----")
        {
            DDL_InBreak_Friday.SelectedValue = DateTime.Parse("00:00:00").ToShortTimeString();
        }
        if (DDL_Out_Friday.SelectedValue == "To")
        {
            LabelErrorFriday.Text = " Error: Friday end time must be selected";
        }
        if (DDL_In_Friday.SelectedValue == "From")
        {
            LabelErrorFriday.Text = " Error: Friday start time must be selected";
        }
        else if ((DDL_In_Friday.SelectedValue != "From") & (DDL_Out_Friday.SelectedValue != "To"))
        {
            LabelErrorFriday.Text = "";
        }
        //--------------SATURDAY
        if (DDL_OutBreak_Saturday.SelectedValue == "----")
        {
            DDL_OutBreak_Saturday.SelectedValue = DateTime.Parse("00:00:00").ToShortTimeString();
        }

        if (DDL_InBreak_Saturday.SelectedValue == "----")
        {
            DDL_InBreak_Saturday.SelectedValue = DateTime.Parse("00:00:00").ToShortTimeString();
        }
        if (DDL_Out_Saturday.SelectedValue == "To")
        {
            LabelErrorSaturday.Text = " Error: Saturday end time must be selected";
        }
        if (DDL_In_Saturday.SelectedValue == "From")
        {
            LabelErrorSaturday.Text = " Error: Saturday start time must be selected";
        }
        else if ((DDL_In_Saturday.SelectedValue != "From") & (DDL_Out_Saturday.SelectedValue != "To"))
        {
            LabelErrorSaturday.Text = "";
        }
        //--------------SUNDAY
        if (DDL_OutBreak_Sunday.SelectedValue == "----")
        {
            DDL_OutBreak_Sunday.SelectedValue = DateTime.Parse("00:00:00").ToShortTimeString();
        }

        if (DDL_InBreak_Sunday.SelectedValue == "----")
        {
            DDL_InBreak_Sunday.SelectedValue = DateTime.Parse("00:00:00").ToShortTimeString();
        }
        if (DDL_Out_Sunday.SelectedValue == "To")
        {
            LabelErrorSunday.Text = " Error: Sunday end time must be selected";
        }
        if (DDL_In_Sunday.SelectedValue == "From")
        {
            LabelErrorSunday.Text = " Error: Sunday start time must be selected";
        }
        else if ((DDL_In_Sunday.SelectedValue != "From") & (DDL_Out_Sunday.SelectedValue != "To"))
        {
            LabelErrorSunday.Text = "";
        }


        if ((DDL_In_Monday.SelectedValue != "From") & (DDL_Out_Monday.SelectedValue != "To"))
        {
            DateTime MondayDDL1 = DateTime.Parse(DDL_In_Monday.SelectedValue);
            DateTime MondayDDL3 = DateTime.Parse(DDL_InBreak_Monday.SelectedValue);
            DateTime MondayDDL2 = DateTime.Parse(DDL_OutBreak_Monday.SelectedValue);
            DateTime MondayDDL4 = DateTime.Parse(DDL_Out_Monday.SelectedValue);


            //DDL1 = DateTime.Parse(DDL_In_Tuesday.SelectedValue);// END POINT---------------------------END POINT





            String BreakStart = DDL_OutBreak_Monday.SelectedValue;
            String BreakEnd = DDL_InBreak_Monday.SelectedValue;

            DateTime BreakStartDT = DateTime.Parse(BreakStart);
            DateTime BreakEndDT = DateTime.Parse(BreakEnd);


            DateTime FromCompHours = DateTime.Parse("6:30:00");
            DateTime ToCompHours = DateTime.Parse("16:30:00");

            
            LabelCALLhrsBEFORE.Text = "";
            LabelCALLhrsAFTER.Text = "";
            LabelMondayREG.Text = "";
            LabelMondayCALL.Text = "";
            LabelTuesdayREG.Text = "";
            LabelTuesdayCALL.Text = "";
            LabelWednesdayREG.Text = "";

            
            //NEED TO ADD if MONDAY DDL1 is greater than POSSIBLE equal to MONDAY DDL4 then 
            if ((MondayDDL1 <= FromCompHours) & (MondayDDL4 >= ToCompHours))//Comp time at both ends
            {
                LabelCALLhrsBEFORE.Text = FromCompHours.Subtract(MondayDDL1).ToString(); //finds comp hours before 6:30 WORKS
                LabelCALLhrsAFTER.Text = MondayDDL4.Subtract(ToCompHours).ToString(); //finds comp hours after 16:30 WORKS
                LabelMondayREG.Text = ("10:00:00");
                DateTime To = DateTime.Parse(LabelCALLhrsBEFORE.Text);//convert text to datetime of earlier time
                DateTime From = DateTime.Parse(LabelCALLhrsAFTER.Text);//convert text to datetime of later time

                LabelMondayCALL.Text = (To.TimeOfDay + From.TimeOfDay).ToString();
               

                if ((BreakStartDT != DateTime.Parse("00:00:00")) & (BreakEndDT != DateTime.Parse("00:00:00")))
                {

                    if ((MondayDDL2 <= FromCompHours) & (MondayDDL3 <= FromCompHours)) //Start before 6:30 end after 16:30 w/ break before 6:30
                    {
                        LabelMondayCALL.Text = TimeSpan.Parse(LabelMondayCALL.Text).Subtract(MondayDDL3.Subtract(MondayDDL2)).ToString();
                    }
                    if ((ToCompHours >= MondayDDL2) & (MondayDDL2 >= FromCompHours) & (ToCompHours >= MondayDDL3) & (MondayDDL3 >= FromCompHours)) //Start before 6:30 end after 16:30 /w break between 6:30 and 16:30
                    {
                        LabelMondayREG.Text = TimeSpan.Parse(LabelMondayREG.Text).Subtract(MondayDDL3.Subtract(MondayDDL2)).ToString();
                    }
                    if ((MondayDDL2 >= ToCompHours) & (MondayDDL3 >= ToCompHours))  //Start before 6:30 end after 16:30 /w break after 16:30
                    {
                        LabelMondayCALL.Text = TimeSpan.Parse(LabelMondayCALL.Text).Subtract(MondayDDL3.Subtract(MondayDDL2)).ToString();
                    }
                    if ((MondayDDL2 <= FromCompHours) & (MondayDDL3 >= FromCompHours) & (MondayDDL3 <= ToCompHours))
                    {
                        LabelMondayCALL.Text = TimeSpan.Parse(LabelMondayCALL.Text).Subtract(FromCompHours.Subtract(MondayDDL2)).ToString();
                        LabelMondayREG.Text = TimeSpan.Parse(LabelMondayREG.Text).Subtract(MondayDDL3.Subtract(FromCompHours)).ToString();
                    }
                    if ((MondayDDL2 <= ToCompHours) & (MondayDDL2 >= FromCompHours) & (MondayDDL3 >= ToCompHours))
                    {
                        LabelMondayCALL.Text = TimeSpan.Parse(LabelMondayCALL.Text).Subtract(ToCompHours.Subtract(MondayDDL2)).ToString();
                        LabelMondayREG.Text = TimeSpan.Parse(LabelMondayREG.Text).Subtract(MondayDDL3.Subtract(ToCompHours)).ToString();
                    }
                }
            }
            else if ((MondayDDL1 <= FromCompHours) & (MondayDDL4 >= ToCompHours))//comp time earlier then 6:30 and later than 16:30
            {
                LabelMondayCALL.Text = FromCompHours.Subtract(MondayDDL1).ToString();//works
                LabelMondayREG.Text = MondayDDL4.Subtract(DateTime.Parse("6:30:00")).ToString();//works ---------NEED TO WORK ON TIME SPLITS

                String StartBreak = DDL_OutBreak_Monday.SelectedValue;
                String EndBreak = DDL_InBreak_Monday.SelectedValue;

            }
            else if ((MondayDDL1 <= FromCompHours) & (MondayDDL4 >= FromCompHours) & (MondayDDL4 <= ToCompHours))
            {
                LabelMondayREG.Text = FromCompHours.Subtract(MondayDDL1).ToString();
                LabelMondayCALL.Text = MondayDDL4.Subtract(DateTime.Parse("6:30:00")).ToString();

                if ((BreakStartDT != DateTime.Parse("00:00:00")) & (BreakEndDT != DateTime.Parse("00:00:00")))
                {
                    if ((MondayDDL2 <= FromCompHours) & (MondayDDL3 <= FromCompHours))
                    {
                        LabelMondayREG.Text = (MondayDDL2.Subtract(MondayDDL1)).Add(FromCompHours.Subtract(MondayDDL3)).ToString();
                    }
                    if ((MondayDDL2 <= FromCompHours) & (MondayDDL3 >= FromCompHours))
                    {
                        LabelMondayREG.Text = (MondayDDL2.Subtract(MondayDDL1)).ToString();
                        LabelMondayCALL.Text = (MondayDDL4.Subtract(MondayDDL3)).ToString();
                    }
                    if ((MondayDDL2 >= FromCompHours) & (MondayDDL3 >= FromCompHours))
                    {
                        LabelMondayREG.Text = FromCompHours.Subtract(MondayDDL1).ToString();
                        LabelMondayCALL.Text = (MondayDDL2.Subtract(FromCompHours)).Add(MondayDDL4.Subtract(MondayDDL3)).ToString();
                    }
                }

            }
            else if ((MondayDDL4 >= ToCompHours) & (MondayDDL1 >= FromCompHours) & (MondayDDL1 <= ToCompHours)) //Start time between 6:30 and 16:30 end time above 16:30 --- comp time before, in between and after 16:30
            {
                LabelMondayREG.Text = ToCompHours.Subtract(MondayDDL1).ToString();//works
                LabelMondayCALL.Text = MondayDDL4.Subtract(DateTime.Parse("16:30:00")).ToString();//works


                if ((BreakStartDT != DateTime.Parse("00:00:00")) & (BreakEndDT != DateTime.Parse("00:00:00"))) //works with break for reg comp and regcomp----------------------
                {
                    if ((MondayDDL2 <= ToCompHours) & (MondayDDL3 <= ToCompHours)) // Comp time starting and ending after 16:30
                    {
                        LabelMondayREG.Text = (MondayDDL2.Subtract(MondayDDL1)).Add(ToCompHours.Subtract(MondayDDL3)).ToString();
                    }
                    if ((MondayDDL2 <= ToCompHours) & (MondayDDL3 >= ToCompHours)) //Comp time starting before 16:30 and ending after 16:30
                    {
                        LabelMondayREG.Text = (MondayDDL2.Subtract(MondayDDL1)).ToString();
                        LabelMondayCALL.Text = (MondayDDL4.Subtract(MondayDDL3)).ToString();
                    }
                    if ((MondayDDL2 >= ToCompHours) & (MondayDDL3 >= ToCompHours)) //Comp time starting and ending after 16:30
                    {
                        LabelMondayREG.Text = ToCompHours.Subtract(MondayDDL1).ToString();
                        LabelMondayCALL.Text = (MondayDDL2.Subtract(ToCompHours)).Add(MondayDDL4.Subtract(MondayDDL3)).ToString();
                    }
                }
            }

            else if ((MondayDDL4 >= ToCompHours) & (MondayDDL1 >= ToCompHours))//comp time later than 16:30
            {
                LabelMondayREG.Text = "00:00:00";//works
                LabelMondayCALL.Text = MondayDDL4.Subtract(MondayDDL1).ToString();//works

                if ((BreakStart != "00:00:00") & (BreakEnd != "00:00:00"))
                {
                    LabelMondayREG.Text = "00:00:00";

                    String CompTimeBreakHours = (BreakEndDT.Subtract(BreakStartDT)).ToString();
                    LabelMondayCALL.Text = ((DateTime.Parse(LabelMondayCALL.Text)) - (DateTime.Parse(CompTimeBreakHours))).ToString();
                }
            }
            else if ((MondayDDL1 <= FromCompHours) & (MondayDDL4 <= FromCompHours)) //comp time earlier than 6:30
            {
                LabelMondayREG.Text = "00:00:00";//works
                LabelMondayCALL.Text = MondayDDL4.Subtract(MondayDDL1).ToString();//works

                if ((BreakStart != "00:00:00") & (BreakEnd != "00:00:00"))
                {
                    LabelMondayREG.Text = "00:00:00";

                    String CompTimeBreakHours = (BreakEndDT.Subtract(BreakStartDT)).ToString();
                    LabelMondayCALL.Text = ((DateTime.Parse(LabelMondayCALL.Text)) - (DateTime.Parse(CompTimeBreakHours))).ToString();
                }
            }
            else if ((MondayDDL4 <= ToCompHours) & (MondayDDL1 >= FromCompHours)) //all hours are between 6:30 and 16:30 or all reg hours
            {
                LabelMondayREG.Text = MondayDDL4.Subtract(MondayDDL1).ToString();//works
                LabelMondayCALL.Text = "00:00:00";//works

                if ((BreakStart != "00:00:00") & (BreakEnd != "00:00:00") & (MondayDDL2 >= MondayDDL1) & (MondayDDL4 >= MondayDDL3))
                {
                    TimeSpan BreakTime = MondayDDL3.Subtract(MondayDDL2);
                    DateTime RegTime = DateTime.Parse(LabelMondayREG.Text);
                    LabelMondayREG.Text = (RegTime - BreakTime).ToString("HH:mm:ss");
                }
            }
            else
            {
                LabelMondayCALL.Text = "Error";
                LabelMondayREG.Text = "Error";

            }
            //add LabelTodayDat.Text
            //===================================================================================================ENABLE TO USE SQL
            //HOME
            //SqlConnection connection = new SqlConnection(@"Data Source=Jakden-PC\SQLEXPRESS;Initial Catalog=DCMA;Integrated Security=True");
            //LAPTOP
            SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DCMA;Integrated Security=True");
            SqlCommand sql_week_insert_cmd = new SqlCommand("INSERT INTO Week (Input_Date, Monday_In, Monday_Out_Break, Monday_In_Break, Monday_Out, LabelMondayREG, LabelMondayCALL, Tuesday_In, Tuesday_Out_Break, Tuesday_In_Break, Tuesday_Out, Wednesday_In, Wednesday_Out_Break, Wednesday_In_Break, Wednesday_Out, Thursday_In, Thursday_Out_Break, Thursday_In_Break, Thursday_Out, Friday_In, Friday_Out_Break, Friday_In_Break, Friday_Out, Saturday_In, Saturday_Out_Break, Saturday_In_Break, Saturday_Out, Sunday_In, Sunday_Out_Break, Sunday_In_Break, Sunday_Out, Week_ID) VALUES (@Input_Date, @Monday_In, @Monday_Out_Break, @Monday_In_Break, @Monday_Out, @Monday_Label_REG, @Monday_Label_CALL, @Tuesday_In, @Tuesday_Out_Break, @Tuesday_In_Break, @Tuesday_Out, @Wednesday_In, @Wednesday_Out_Break, @Wednesday_In_Break, @Wednesday_Out, @Thursday_In, @Thursday_Out_Break, @Thursday_In_Break, @Thursday_Out, @Friday_In, @Friday_Out_Break, @Friday_In_Break, @Friday_Out, @Saturday_In, @Saturday_Out_Break, @Saturday_In_Break, @Saturday_Out, @Sunday_In, @Sunday_Out_Break, @Sunday_In_Break, @Sunday_Out, NEWID())", connection);
            //Monday
            sql_week_insert_cmd.Parameters.AddWithValue("@Monday_In", DDL_In_Monday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Monday_Out_Break", DDL_OutBreak_Monday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Monday_In_Break", DDL_InBreak_Monday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Monday_Out", DDL_Out_Monday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Monday_Label_REG", DDL_Out_Monday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Monday_Label_CALL", DDL_Out_Monday.SelectedValue);
            //Tuesday
            sql_week_insert_cmd.Parameters.AddWithValue("@Tuesday_In", DDL_In_Tuesday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Tuesday_Out_Break", DDL_OutBreak_Tuesday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Tuesday_In_Break", DDL_InBreak_Tuesday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Tuesday_Out", DDL_Out_Tuesday.SelectedValue);
            //Wednesday
            sql_week_insert_cmd.Parameters.AddWithValue("@Wednesday_In", DDL_In_Wednesday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Wednesday_Out_Break", DDL_OutBreak_Wednesday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Wednesday_In_Break", DDL_InBreak_Wednesday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Wednesday_Out", DDL_Out_Wednesday.SelectedValue);
            //Thursday
            sql_week_insert_cmd.Parameters.AddWithValue("@Thursday_In", DDL_In_Thursday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Thursday_Out_Break", DDL_OutBreak_Thursday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Thursday_In_Break", DDL_InBreak_Thursday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Thursday_Out", DDL_Out_Thursday.SelectedValue); 
            //Friday
            sql_week_insert_cmd.Parameters.AddWithValue("@Friday_In", DDL_In_Friday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Friday_Out_Break", DDL_OutBreak_Friday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Friday_In_Break", DDL_InBreak_Friday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Friday_Out", DDL_Out_Friday.SelectedValue);
            //Saturday
            sql_week_insert_cmd.Parameters.AddWithValue("@Saturday_In", DDL_In_Saturday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Saturday_Out_Break", DDL_OutBreak_Saturday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Saturday_In_Break", DDL_InBreak_Saturday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Saturday_Out", DDL_Out_Saturday.SelectedValue);
            //Sunday
            sql_week_insert_cmd.Parameters.AddWithValue("@Sunday_In", DDL_In_Sunday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Sunday_Out_Break", DDL_OutBreak_Sunday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Sunday_In_Break", DDL_InBreak_Sunday.SelectedValue);
            sql_week_insert_cmd.Parameters.AddWithValue("@Sunday_Out", DDL_Out_Sunday.SelectedValue);

            sql_week_insert_cmd.Parameters.AddWithValue("@Input_Date", DateTime.Now);


            connection.Open();
            sql_week_insert_cmd.ExecuteNonQuery();
            connection.Close();

            /*
            SqlCommand sql_monday_in_cmd = new SqlCommand("INSERT INTO Week (Monday_In, Week_ID) VALUES (@Monday_In, NEWID())", connection);
            sql_monday_in_cmd.Parameters.AddWithValue("@Monday_In", DDL_In_Monday.SelectedValue);

            SqlCommand sql_monday_out_break_cmd = new SqlCommand("INSERT INTO Week (Monday_Out_Break, Week_ID) VALUES (@Monday_Out_Break, NEWID())", connection);
            sql_monday_out_break_cmd.Parameters.AddWithValue("@Monday_Out_Break", DDL_OutBreak_Monday.SelectedValue);


            


            connection.Open();
            sql_monday_in_cmd.ExecuteNonQuery();
            sql_monday_out_break_cmd.ExecuteNonQuery();
            connection.Close();
             */
            //======================================================================================================================
             
            

            /* SqlConnection connection = new SqlConnection(Data Source=JAKDEN-PC\SQLEXPRESS;Initial Catalog=DCMA;Integrated Security=True");
             //("Data Source=Jakden-PC; Initial Catalog=DCMA; Integrated Security=TRUE")
             connection.Open();

             try
             {
            
                 LabelFridayCALL.Text = "CONNECTED";
            
             }
             catch (Exception)
             {
                 LabelFridayREG.Text = "Not Connected";
             } */


            /*
            using (var conn = new SqlConnection(@"Server = JAKDEN-PC\SQLEXPRESS; uid=jakden; pwd=password; database= DCMA;"))
            using (var cmd = new SqlCommand(conn))
            {
                conn.Open();
                cmd.CommandText = "INSERT INTO Weeks (Monday_In) VALUES (@Mon_In)";
                cmd.Parameters.AddWithValue("@Mon_In", LabelMondayREG.Text);
            
            } */






        }
    }
   /* protected void CalendarStartDate_SelectionChanged(object sender, EventArgs e)//add calendar dates to each day 
    {
        DateTime StartMonday = FirstDayOfWeek.Monday;
        //LabelStartDate.Text = (CalendarStartDate.SelectedDate).ToString("MM/dd/yyyy");
        DateTime Cal = (CalendarStartDate.SelectedDate);
        LabelMonday.Text = (Cal.AddDays(0)).ToString("MM/dd/yyyy");
        LabelTuesday.Text = (Cal.AddDays(1)).ToString("MM/dd/yyyy");
        LabelWednesday.Text = (Cal.AddDays(2)).ToString("MM/dd/yyyy");
        LabelThursday.Text = (Cal.AddDays(3)).ToString("MM/dd/yyyy");
        LabelFriday.Text = (Cal.AddDays(4)).ToString("MM/dd/yyyy");
        LabelSaturday.Text = (Cal.AddDays(5)).ToString("MM/dd/yyyy");
        LabelSunday.Text = (Cal.AddDays(6)).ToString("MM/dd/yyyy");

    }*/


    protected void  SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DDL_In_Monday_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }
}

   /* List<DropDownList> lstDDL = new List<DropDownList>() { DropDownList1, DropDownList2 };
    foreach (DropDownList ddl in lstDDL)
    {
     ddl.Items.Add("Stuff");
    }
*/


