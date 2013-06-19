using System.ComponentModel.Composition;
using System.Linq;
using System.Xml.Linq;
using MEFDemoApp.Contracts;

namespace MEFDemoApp
{
    [Export(typeof(IEmployeeDestionation))]
    public class EmployeeXmlDestionation : IEmployeeDestionation
    {
        public void Persist(Employee[] employees)
        {
            new XElement("Employees", employees.Select(e => new XElement("Employee", 
                                                                         new XElement("Id", e.Id), 
                                                                         new XElement("FirstName", e.FirstName), 
                                                                         new XElement("LastName", e.LastName), 
                                                                         new XElement("Salary", e.Salary))))
                .Save("Employees.xml");

        }
    }
}