using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using MEFDemoApp.Contracts;

namespace MEFDemoApp
{
    [Export(typeof(IEmployeeDestionation))]
    public class CsvEmployeeDestionation : IEmployeeDestionation
    {
        public void Persist(Employee[] employees)
        {
            var streamWriter = new StreamWriter("Employees.csv");
            employees.Select(e => string.Format("{0},{1},{2},{3}", e.Id, e.FirstName, e.LastName, e.Salary))
                     .ForEach(streamWriter.WriteLine);
            streamWriter.Close();
        }
    }
}