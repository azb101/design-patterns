namespace UnitOfWork_and_Repository.Initial
{
    public interface IPersonDataContext
    {
        IDBContext NewContext();
    }
}