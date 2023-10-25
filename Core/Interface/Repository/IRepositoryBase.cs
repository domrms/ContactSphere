namespace Core.Interface
{
    public interface IRepositoryBase<in TEntity> where TEntity : class
    {
        void Dispose();
    }
}
