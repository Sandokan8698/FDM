namespace Data.Implementations.Repositories
{
    public class DomainContextRepository<TEntity> : Repository<TEntity> where TEntity : class
    {
        public DomainContextRepository(FDMContext context) : base(context)
        {
        }

        public FDMContext CnnContext
        {
            get { return Context as FDMContext; }
        }
    }
}
