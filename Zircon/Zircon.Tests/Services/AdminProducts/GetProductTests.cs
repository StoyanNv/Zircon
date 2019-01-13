using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zircon.Data;
using Zircon.Tests.Mocks;

namespace Zircon.Tests.Services.AdminProducts
{
    [TestClass]
    public class GetProductTests
    {
        private ZirconDbContext dbContext;
        private IMapper mapper;

        [TestInitialize]
        public void InitializeTests()
        {
            this.dbContext = MockDbContext.GetContext();
            this.mapper = MockAutoMapper.GetMapper();
        }
        //[TestMethod]
        //GetProductAsync_
    }
}