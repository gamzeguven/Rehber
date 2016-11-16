//using Rehber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rehber
{
    public partial class PersonnelAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            using (SMEntities context = new SMEntities())
            {
                context.PERSONNELCATALOGs.ToList();
                PERSONNELCATALOG pc = new PERSONNELCATALOG();
                //pc.DepartmentID=txtBox1.text;
                context.PERSONNELCATALOGs.Add(pc);

                context.SaveChanges();               
            }
        }


        protected void PersonnelDetailsView_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {
       
            
        }
    }
}