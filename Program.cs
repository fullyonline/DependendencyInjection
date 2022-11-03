using DependendencyInjection;

INotificationService notificationService = new ConsoleNotification();
User user = new User(notificationService);
user.Name = "Müller";
user.Name = "Meier";