
namespace Observer
{
    public class NewsPublisher : IObservable
    {
        private readonly List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(string news)
        {
            foreach (var observer in _observers)
            {
                observer.Update(news);
            }
        }

        public void PublishNews(string news)
        {
            Console.WriteLine("New news: " + news);
            NotifyObservers(news);
        }
    }
}
