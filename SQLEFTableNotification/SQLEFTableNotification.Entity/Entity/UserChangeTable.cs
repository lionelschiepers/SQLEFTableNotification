namespace SQLEFTableNotification.Entity.Entity
{
    public class UserChangeTable : ChangeTable, IEntityPk
    {
        public int Id { get; set; }
    }

    public class ChangeTableVersionCount
    {
        public long VersionCount { get; set; }
    }
}
