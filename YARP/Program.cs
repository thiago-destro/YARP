WebApplicationBuilder webAppBuilder = WebApplication.CreateBuilder(args);

//Adds a reverse proxy server according the the config file's session "ReverseProxy"
_ = webAppBuilder.Services.AddReverseProxy().
        LoadFromConfig(webAppBuilder.Configuration.GetSection("ReverseProxy"));

WebApplication webApp = webAppBuilder.Build();

//Maps the reverse proxy routes
webApp.MapReverseProxy();
webApp.Run();

