var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles(); // Hỗ trợ index.html
app.UseStaticFiles();  // Cho phép chạy các file html, css, js trong thư mục wwwroot

app.Run();