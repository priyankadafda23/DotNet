using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demo
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AdRotator1_AdCreated(object sender, AdCreatedEventArgs e)
        {
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            AdRotator1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string file_name = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
            //FileUpload1.SaveAs(Server.MapPath("~/images" + file_name));
            //Label1.Text = "File uploaded successfully!";

            if (FileUpload1.HasFile)
            {
                string path = Server.MapPath("~/images/");
                string filename = FileUpload1.FileName;
                FileUpload1.SaveAs(path + FileUpload1+filename);
                Label1.Text = "File uploaded successfully!";
            }
            else
            {
                Label1.Text = "Please select a file to upload.";
            }
        }
    }
}