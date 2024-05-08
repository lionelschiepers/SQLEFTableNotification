using SQLEFTableNotification.Delegates;

namespace SQLEFTableNotification.Interfaces
{
    public interface IDBNotificationService<T> where T : class, new()
    {
        event Delegates.ErrorEventHandler OnError;

        event ChangedEventHandler<T> OnChanged;

        Task StartNotify();
        Task StopNotify();
    }
}
