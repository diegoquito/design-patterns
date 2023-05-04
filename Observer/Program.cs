

using Observer;

var publisher = new NewsPublisher();
var emailObserver = new EmailNotificationService();

publisher.AddObserver(emailObserver);

publisher.PublishNews("New feature added to the system");
