using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Create a list of employees
                var employees = new List<Employee>
                {
                    new Employee { EmployeeId = 1, FirstName = "John", LastName = "Doe", HireDate = new DateTime(2020, 1, 15), Salary = 50000 },
                    new Employee { EmployeeId = 2, FirstName = "Jane", LastName = "Smith", HireDate = new DateTime(2019, 5, 8), Salary = 60000 },
                    new Employee { EmployeeId = 3, FirstName = "Bob", LastName = "Johnson", HireDate = new DateTime(2021, 8, 20), Salary = 55000 },
                };

                // Bind the list to a GridView
                GridView1.DataSource = employees;
                GridView1.DataBind();
            }
    }
}