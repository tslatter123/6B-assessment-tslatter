using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SixBAssessmentTSlatter.Client;
using SixBAssessmentTSlatter.Client.Interfaces.Services;
using SixBAssessmentTSlatter.Client.Interfaces.Mappers;
using SixBAssessmentTSlatter.Client.Mappers;
using SixBAssessmentTSlatter.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("SixBAssessmentTSlatter.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

builder.Services.AddSingleton<IBookingService, BookingService>();

builder.Services.AddSingleton<IBookingMapper, BookingMapper>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("SixBAssessmentTSlatter.ServerAPI"));

builder.Services.AddApiAuthorization();

await builder.Build().RunAsync();
