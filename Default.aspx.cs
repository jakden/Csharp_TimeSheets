 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DropDownList1.Items.Add(new ListItem("From"));
        DropDownList2.Items.Add(new ListItem("To"));
        DropDownList3.Items.Add(new ListItem("From"));
        int input = 1;
        DateTime from1 = DateTime.Today;
        DateTime to1 = DateTime.Today;
        DateTime from2 = DateTime.Today;

        while (from1.Date == DateTime.Today)
        {  
            DropDownList1.Items.Add(new ListItem(from1.ToString("HH:mm"), from1.ToShortTimeString()));
            from1 = from1.AddMinutes(15 * input);
            DropDownList2.Items.Add(new ListItem(to1.ToString("HH:mm"), to1.ToShortTimeString()));
            to1 = to1.AddMinutes(15 * input);
            DropDownList3.Items.Add(new ListItem(from2.ToString("HH:mm"), from2.ToShortTimeString()));
            from2 = from2.AddMinutes(15 * input);
        }
    }
    protected void ButtonCalculate_Click(object sender, EventArgs e)
    {
        DateTime DDL2 = DateTime.Parse(DropDownList2.SelectedValue);
        DateTime DDL1 = DateTime.Parse(DropDownList1.SelectedValue);
        DateTime ToCompHours = DateTime.Parse("6:30");
        DateTime FromCompHours = DateTime.Parse("16:30");

        Label1.Text = "";
        Label2.Text = "";
        Label3.Text = "";
        LabelReg.Text = "";
        LabelComp.Text = "";

        //int result = DateTime.Compare(DDL1, DDL2);

        if ((DDL1 < ToCompHours) & (DDL2 > FromCompHours))//Comp time at both ends
        {
            Label2.Text = ToCompHours.Subtract(DDL1).ToString(); //finds comp hours before 6:30 WORKS
            Label3.Text = DDL2.Subtract(FromCompHours).ToString(); //finds comp hours after 16:30 WORKS
            LabelReg.Text = ("10:00:00");
            //LabelHolder.Text = (DateTime.Parse(Label2.Text)) + (DateTime.Parse(Label3.Text)).ToString(); //adds the two comp hours together
            //TimeSpan SubtractReg = DDL2.Subtract(DDL1); //finds the difference of from minus to
            DateTime To = DateTime.Parse(Label2.Text);//convert text to datetime of earlier time
            DateTime From = DateTime.Parse(Label3.Text);//convert text to datetime of later time

            LabelComp.Text = (To.TimeOfDay + From.TimeOfDay).ToString();

            //LabelComp.Text = To.Subtract(From).ToString();
            //LabelComp.Text = (TimeSpan.Parse(Label3.Text))+(TimeSpan.Parse(Label2.Text)).ToString(); 

            //DateTime Comp = (Convert.ToDateTime(LabelComp.Text)); //Makes Label into var
            //DateTime Holder = (Convert.ToDateTime(LabelHolder.Text)); //Makes label into var

            //LabelReg.Text = Holder.Subtract(Comp).ToString(); //Finds the difference between regular hours and comp hours
        }
        else if ((DDL1 <= ToCompHours) & (DDL2 >= FromCompHours))//comp time earlier then 6:30 and later than 16:30
        {
            LabelComp.Text = ToCompHours.Subtract(DDL1).ToString();//works
            LabelReg.Text = DDL2.Subtract(DateTime.Parse("6:30")).ToString();//works
        }
        else if ((DDL2 >= FromCompHours) & (DDL1 >= ToCompHours) & (DDL1 <= FromCompHours))//comp time later then 16:30
        {
            LabelReg.Text = FromCompHours.Subtract(DDL1).ToString();//works
            LabelComp.Text = DDL2.Subtract(DateTime.Parse("16:30")).ToString();//works
        }
        else if ((DDL2 >= FromCompHours) & (DDL1 >= FromCompHours))
        {
            LabelReg.Text = "00:00:00";//works
            LabelComp.Text = DDL2.Subtract(DDL1).ToString();//works
        }
        else if ((DDL1 <= ToCompHours) & (DDL2 <= ToCompHours))
        {
            LabelReg.Text = "00:00:00";//works
            LabelComp.Text = DDL2.Subtract(DDL1).ToString();//works
        }
        else
        {
            LabelReg.Text = DDL2.Subtract(DDL1).ToString();//works
            LabelComp.Text = "0:00:00";//works
        }
    }

    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
}