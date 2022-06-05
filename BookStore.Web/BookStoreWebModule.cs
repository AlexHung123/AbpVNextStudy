using BookStore.Application;
using BookStore.EntityFramworkCore;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace BookStore.Web;

[DependsOn(
    typeof(AbpAspNetCoreMvcModule),
    typeof(AbpAutofacModule),
    typeof(BookStoreApplicationModule)
    )] 
public class BookStoreWebModule:AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var servives = context.Services;
        servives.AddSingleton<IUserService, UserService>();
        servives.AddControllersWithViews();
    }

    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        var app = context.GetApplicationBuilder();
        var env = context.GetEnvironment();

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthentication();

        app.UseAuthorization();
        app.UseConfiguredEndpoints();
    }
}
