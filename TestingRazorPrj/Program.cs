//1.used to create webserver (load the kestrel webserver in the memory)
//2. will also load launchsetting.json and appsettings.json file
//3. this method will return an obj(webapplication builder)
//4. using this return type we can configure many things
////1.add services
////2.dependency injection
////3.
using TestingRazorPrj;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);
// list of features that project support

// separate object is created for every request
//builder.Services.AddTransient();
//builder.Services.AddTransient<IMyInter, MyMathCls>();//where IMyInter is interface and IMathcls is class name

//single object is created for every user
//builder.Services.AddScoped();

//1 object is used by all the user
//builder.Services.AddSingleton();
builder.Services.AddTransient<IMyinter, MyMathCls>();
// seperate object is created for every request
//builder.Services.AddTransient();

// single object is created for each user
//builder.Services.AddScoped();

// 1 object is used  by all the user    
//builder.Services.AddSingleton();



// Add services to the container.
// we can add many services to the poject like authuntication ,cookies etc
builder.Services.AddRazorPages();
builder.Services.AddLogging(c => { c.AddConsole(); c.AddDebug(); });
builder.Services.AddRazorPages(c =>
{
    c.Conventions.AddPageRoute("/india", "abc");
    c.Conventions.AddPageRoute("/addcontact", "xyz");
    c.Conventions.AddPageRoute("/viewcontact", "pqr");
    c.Conventions.AddPageRoute("/deletecontact", "mno");

});

//services declared will be loaded to the kestrel web server
//it is like giving info to the kestrel about the services used in the project
var app = builder.Build();
//app.UseStatusCodePages();//display the status code when user enters wrong url
//app.UseStatusCodePagesWithRedirects("ErrorPage");//instead of status code we can give customised message(page not found)->url will change
app.UseStatusCodePagesWithReExecute("/ErrorPage");//msg will be shown in one page without changing the url

//----------code to be execucted in development environment---------

//using app object we an define the rules
// Configure the HTTP request pipeline.


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");//when runtime error occurs ,it handles the errors
                                      // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//order of the services to be executed
//---whether client side pages can excute or not----
//app.UseHttpsRedirection();
app.UseStaticFiles();//u can use client pages
//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("<div> Hello World from the middleware 2 </div>");
//    await next.Invoke();//next middle ware will be executed
//    await context.Response.WriteAsync("<div> Returning from the middleware 2 </div>");
    
//});
//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("<div> india </div>");
//    await next.Invoke();//next middle ware will be executed
//    await context.Response.WriteAsync("<div>japan </div>");
//});
//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("<div> swiz</div>");
//    await next.Invoke();//next middle ware will be executed
//    await context.Response.WriteAsync("<div> US</div>");

//});



//if pages are not present--run this code
//app.MapGet("/a",()=>"Helloworld");
//customised path can be given
app.UseRouting();

app.UseAuthorization();
//---whether Razor pages can excute or not----

app.MapRazorPages();

//it is the last rule,after this no rule is counted
app.Run();//after run method u cannot give any rules
