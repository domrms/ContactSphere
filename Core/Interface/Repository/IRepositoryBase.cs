namespace Core.Interface.Repository
{
    public interface IRepositoryBase<in TEntity> where TEntity : class
    {
        void Dispose();
    }
}
