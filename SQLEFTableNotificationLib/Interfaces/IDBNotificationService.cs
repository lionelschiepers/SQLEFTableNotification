using SQLEFTableNotification.Delegates;

namespace SQLEFTableNotification.Interfaces
{
    public interface IDBNotificationService<T> where T : class, new()
    {
        event Delegates.ErrorEventHandler OnError;

        event ChangedEventHandler<T> OnChanged;

        //event StatusEventHandler OnStatusChanged;

        // SetFilterExpression(Expression<Func<T, bool>> expression);
        Task StartNotify();
        Task StopNotify();
    }
}
