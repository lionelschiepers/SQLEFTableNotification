using SQLEFTableNotification.Models;

namespace SQLEFTableNotification.Delegates
{

    public delegate void ErrorEventHandler(object sender, Models.ErrorEventArgs e);
    public delegate void ChangedEventHandler<T>(object sender, RecordChangedEventArgs<T> e) where T : class, new();

}
