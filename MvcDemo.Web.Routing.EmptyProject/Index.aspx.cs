using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Routing;
using MvcDemo.Web.Routing.EmptyProject.Model;
using MvcDemo.Web.Routing.EmptyProject.Repository;

namespace MvcDemo.Web.Routing.EmptyProject
{
    public partial class Index : System.Web.UI.Page
    {
        private EmployeeRepository employeeRepository;

        public EmployeeRepository EmployeeRepository
        {
            get { return null == employeeRepository ? employeeRepository=new EmployeeRepository() : employeeRepository; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                return;
            }

            string employeeId = this.RouteData.Values["id"] as string;
            if (employeeId == "*" || string.IsNullOrEmpty(employeeId))
            {
                this.GridViewEmployees.DataSource = this.EmployeeRepository.GetEmployees();
                this.GridViewEmployees.DataBind();
                this.DetailsViewEmployee.Visible = false;
            }
            else
            {
                this.DetailsViewEmployee.DataSource = this.EmployeeRepository.GetEmployees(employeeId);
                this.DetailsViewEmployee.DataBind();
                this.GridViewEmployees.Visible = false;
            }
        }
    }
}