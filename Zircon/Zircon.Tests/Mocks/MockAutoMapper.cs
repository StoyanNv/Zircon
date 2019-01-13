using AutoMapper;
using Zircon.Services.Mapping;

namespace Zircon.Tests.Mocks
{
    public static class MockAutoMapper
    {
        static MockAutoMapper()
        {
            Mapper.Initialize(config => config.AddProfile<AutoMapperProfile>());
        }

        public static IMapper GetMapper() => Mapper.Instance;
    }
}