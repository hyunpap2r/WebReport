using BlazorApp1.Server.Interface;
using BlazorApp1.Server.Models;
using BlazorApp1.Server.Service;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.Shared;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add services to the container.
builder.Services.AddDbContext<PlanActualContext>(options =>
        options.UseNpgsql("Host=localhost;Database=Plan_Actual;Username=testgroup;Password=guswhd23"));
builder.Services.AddTransient<IGPlanActualTemp, PlanActualTempService>();
builder.Services.AddTransient<IGInvPickRequest, InvPickRequestService>();
builder.Services.AddTransient<IGlogin, LoginService>();


builder.Services.AddScoped<DialogService>();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
