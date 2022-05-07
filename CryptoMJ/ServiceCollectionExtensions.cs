using Microsoft.Extensions.DependencyInjection;
namespace CryptoMJ
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCryptoMJ(this IServiceCollection services, CryptoBuilder builder) => AddMethod(services, builder);
        public static IServiceCollection AddCryptoMJ(this IServiceCollection services) => AddMethod(services, new CryptoBuilder());
        private static IServiceCollection AddMethod(IServiceCollection services, CryptoBuilder builder)
        {
            services.AddSingleton<ICrypto, Crypto>(x => (Crypto)builder.Build());
            return services;
        }
    }
}
