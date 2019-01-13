namespace Zircon.Tests.Mocks
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using System;

    public static class MockDbContext
    {
        public static ZirconDbContext GetContext()
        {
            var options = new DbContextOptionsBuilder<ZirconDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            return new ZirconDbContext(options);
        }
    }
}