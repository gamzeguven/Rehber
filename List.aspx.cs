using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rehber
{
    public partial class List : System.Web.UI.Page
    {
        SMEntities entity = new SMEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var source = (from p in entity.PERSONNELCATALOGs
                          
                          join d in entity.DEPARTMENTs on p.DepartmentID equals d.DepartmentID
                          join t in entity.TITLEs on p.TitleID equals t.TitleID
                          select new { p.RegisterID, p.Name, p.Surname, d.DepartmentName, t.Title, p.PhoneNumber }).ToList();
    
            GridView1.DataSource = source;
            GridView1.DataBind();

            


        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;

            this.GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            TableCell cell = GridView1.Rows[e.RowIndex].Cells[1];

            using (SMEntities db = new SMEntities())
            {
                var personToDelete = db.PERSONNELCATALOGs.Find(Convert.ToInt32(cell.Text));

                if (personToDelete != null)
                {
                    db.PERSONNELCATALOGs.Remove(personToDelete);
                    db.SaveChanges();
                    GridView1.DataBind();
                    Response.Redirect("List.aspx");
                }
                
            }
        }


        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            //GridView gv = (GridView)sender;
            //GridViewRow gvr = (GridViewRow)gv.Rows[e.RowIndex];

            // PERSONNELCATALOG pc = new PERSONNELCATALOG();
            ////  pc.Name = e.NewValues["Name"].ToString();
            using (var context = new SMEntities())
            {
                //int gvr = Convert.ToInt32(GridView1.Rows[e.RowIndex].Cells[1].ToString());

                //    int str = Convert.ToInt32(e.NewValues["RegisterID"].ToString());
                var cust =
             (from c in context.PERSONNELCATALOGs where c.RegisterID == 7 select c).First();
                cust.Name = "Orhan";
                context.SaveChanges();
                GridView1.DataBind();
                Response.Redirect("List.aspx");
            }
        }
            //Retrieve the table from the session object.
           


            //Update the values.
            //GridViewRow row = GridView1.Rows[e.RowIndex];
            //GridView1.Rows[row.DataItemIndex]["Name"] = ((TextBox)(row.Cells[1].Controls[0])).Text;
            //GridView1.Rows[row.DataItemIndex]["Surname"] = ((TextBox)(row.Cells[2].Controls[0])).Text;
            //pc.Rows[row.DataItemIndex]["Phone"] = ((TextBox)(row.Cells[3].Controls[0])).Text;
            
            //Reset the edit index.
            //.EditIndex = -1;
            
            //Bind data to the GridView control.
           // DataBind();


            
 
        

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //Set the edit index.
            GridView1.EditIndex = e.NewEditIndex;
            //Bind data to the GridView control.
            DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Reset the edit index.
            GridView1.EditIndex = -1;
            //Bind data to the GridView control.
            DataBind();
        }

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
     ////       GridView gv = (GridView)sender;
     ////       GridViewRow gvr = (GridViewRow)gv.Rows[e.RowIndex];

     ////       // PERSONNELCATALOG pc = new PERSONNELCATALOG();
     ////       ////  pc.Name = e.NewValues["Name"].ToString();
     ////       using (var context = new SMEntities())
     ////       {
     ////           int str = Convert.ToInt32(e.NewValues["RegisterID"].ToString());
     ////           var cust =
     ////(from c in context.PERSONNELCATALOGs
     //// where c.RegisterID == str
     //// select c).First();
     ////           cust.Name = e.NewValues["Name"].ToString();
     ////           context.SaveChanges();

     ////       }
        }

    }
}