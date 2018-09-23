namespace Zircon.Services
{
    using AutoMapper;
    using Data;

    public abstract class BaseEfService
    {
        protected BaseEfService(
            ZirconDbContext dbContext,
            IMapper mapper)
        {
            this.DbContext = dbContext;
            this.Mapper = mapper;
        }

        protected ZirconDbContext DbContext { get; private set; }

        protected IMapper Mapper { get; private set; }
    }
}
