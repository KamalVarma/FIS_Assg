using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assg4._1
{
    public partial class Event : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "Select", "car", "truck", "plane", "bus" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "car")
            {
                Label1.Text = "Rs 3,50,00,000";
            }
            else if (DropDownList1.Text == "truck")
            {
                Label1.Text = "Rs 60,00,000";
            }
            else if (DropDownList1.Text == "plane")
            {
                Label1.Text = "Rs 6,00,00,000";
            }
            else if (DropDownList1.Text == "bus")
            {
                Label1.Text = "Rs 80,00,000";
            }
            else
                Label1.Text = "";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Images/" + str + ".jpg";
        }
    }
}