
namespace Observer
{
    public class EmailNotificationService : IObserver
    {
        public void Update(string news)
        {
            Console.WriteLine("Sending email notification: " + news);
            // Business logic to send email
        }
    }
}
