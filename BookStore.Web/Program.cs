namespace BookStore.Web;
public class Program
{
    public async static Task<int> Main(string[] args)
    {
        try
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Host.UseAutofac();
            //builder.Services.AddSingleton<IUserService, UserService>();
            await builder.AddApplicationAsync<BookStoreWebModule>();
            var app = builder.Build();
            await app.InitializeApplicationAsync();
            await app.RunAsync();
            return 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return 1;
        }
        finally
        {
        }
    }
}
