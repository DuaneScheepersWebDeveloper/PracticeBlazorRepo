using BlazorBootstrap;
using TestingDynamicEditableTable.Data;
using TestingDynamicEditableTable.Data.GridData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddBlazorBootstrap();

builder.Services.AddScoped<ICarData, CarData>();
builder.Services.AddScoped<IYoutubeAnalyticsData, YoutubeData>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();



// private async Task LoadFiles(InputFileChangeEventArgs e)
// {
//     try
//     {
//         errors.Clear();
//         if (e.FileCount > maxAllowedFiles)
//         {
//             errors.Add($"Error: Attempting to upload {e.FileCount} files, but only {maxAllowedFiles} files are allowed");
//             return;
//         }

//         foreach (var file in e.GetMultipleFiles(maxAllowedFiles))
//         {
//             string newFileName = Path.ChangeExtension(
//                 Path.GetRandomFileName(),
//                 Path.GetExtension(file.Name));


//             string path = Path.Combine(
//                 config.GetValue<string>("FileStorage")!, "Uploaded", newFileName);

//             Directory.CreateDirectory(Path.Combine(
//                 config.GetValue<string>("FileStorage")!,
//                 "Uploaded"));
//             await using FileStream fs = new(path, FileMode.Create);
//             await file.OpenReadStream(maxFileSize).CopyToAsync(fs);

//         }
//     }
//     catch (Exception ex)
//     {
//         errors.Add($"Error: {ex.Message}");
//     }
// }
