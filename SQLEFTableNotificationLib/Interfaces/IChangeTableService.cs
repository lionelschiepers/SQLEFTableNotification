namespace SQLEFTableNotification.Interfaces
{
    public interface IChangeTableService<T>
    {
        Task<List<T>> GetRecords(string CommandText);
        List<T> GetRecordsSync(string CommandText);

        long GetRecordCountSync(string CommandText);

        Task<long> GetRecordCount(string CommandText);
    }
}
