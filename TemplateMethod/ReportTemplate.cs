
namespace TemplateMethod
{
    public abstract class ReportTemplate
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating report...");
            GenerateHeader();
            GenerateBody();
            GenerateFooter();
            Console.WriteLine("Report generated successfully!");
        }

        protected abstract void GenerateHeader();
        protected abstract void GenerateBody();
        protected abstract void GenerateFooter();
    }
}
