
namespace TemplateMethod
{
    public class SalesReport : ReportTemplate
    {
        protected override void GenerateHeader()
        {
            Console.WriteLine("Sales Report Header");
        }

        protected override void GenerateBody()
        {
            Console.WriteLine("Sales Report Body");
        }

        protected override void GenerateFooter()
        {
            Console.WriteLine("Sales Report Footer");
        }
    }
}
