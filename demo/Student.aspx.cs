using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demo
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnNext1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }
        protected void btnPrevious_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }
        protected void btnNext2_Click(object sender, EventArgs e)
        {
            lblName.Text = txtName.Text;
            lblGender.Text = rblGender.SelectedValue;
            lblAddress.Text = txtAddress.Text;
            lblDegree.Text = ddlDegree.SelectedValue;

            lblEmail.Text = txtEmail.Text;
            lblContact.Text = txtContact.Text;

            MultiView1.ActiveViewIndex = 2;
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

    }
}