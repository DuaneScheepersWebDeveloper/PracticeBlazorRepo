namespace TestingDynamicEditableTable.Data
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
    }
}
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