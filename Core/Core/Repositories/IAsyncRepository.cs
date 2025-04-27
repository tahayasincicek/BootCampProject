namespace Core.Repositories
{
    public interface IAsyncRepository<T> : IRepository<T> where T : class
    {
        // Async repository, IRepository'den miras alıyor.
    }
}
