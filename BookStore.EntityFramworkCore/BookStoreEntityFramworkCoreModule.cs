using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace BookStore.EntityFramworkCore;

[DependsOn(
    typeof(AbpEntityFrameworkCoreModule)
    )]
public class BookStoreEntityFramworkCoreModule: AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<BookStoreDbContext>(options=>{
            options.AddDefaultRepositories(true);
        });

        Configure<AbpDbContextOptions>(options =>{
            options.UseMySQL();
        });
    }
}
