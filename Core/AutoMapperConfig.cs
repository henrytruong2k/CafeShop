using AutoMapper;

namespace CafeShop.Core;

public sealed class AutoMapperConfig
{
    private static readonly Lazy<IMapper> _instance = new((CreateMapper));

    private AutoMapperConfig() { }

    public static IMapper Instance => _instance.Value;

    private static IMapper CreateMapper()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<MappingProfile>();
        });

        return config.CreateMapper();
    }
}