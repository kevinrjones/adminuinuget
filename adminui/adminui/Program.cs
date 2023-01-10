using IdentityExpress.Manager.BusinessLogic.Configuration;
using IdentityExpress.Manager.UI.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAdminUI(options =>
{
    options.IdentityType = IdentityType.DefaultIdentity;
    options.MigrationOptions = MigrationOptions.All;
});

var app = builder.Build();

app.UseAdminUI();

app.Run();