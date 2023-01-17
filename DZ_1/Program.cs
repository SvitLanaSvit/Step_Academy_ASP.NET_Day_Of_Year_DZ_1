using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/numberOfDay", (context)=>{ 
   
    StringBuilder sb = new StringBuilder();
    string currentDayOfYear = DateTime.Now.DayOfYear.ToString();
    sb.AppendLine($"<div>Day of year: {currentDayOfYear}");
    return context.Response.WriteAsync(sb.ToString());
});

app.Run();
