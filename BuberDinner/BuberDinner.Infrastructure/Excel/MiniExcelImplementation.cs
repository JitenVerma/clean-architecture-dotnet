using BuberDinner.Application.Common.Excel;
using MiniExcelLibs;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Infrastructure.Excel;


public class MiniExcelImplementation : IMiniExcelImplementation
{
    public FileStreamResult CreateExcelSpreadsheet()
    {
        // string path = @"C:\Users\jiten\Documents\software-projects\clean-architecture-dotnet\BuberDinner\temp.xlsx";
        // var values = new List<Dictionary<string, object>>()
        // {
        //     new Dictionary<string,object>{{ "Column1", "MiniExcel" }, { "Column2", 1 } },
        //     new Dictionary<string,object>{{ "Column1", "Github" }, { "Column2", 2 } }
        // };
        // MiniExcel.SaveAs(path, values);

        var values = new[] {
        new { Column1 = "MiniExcel", Column2 = 1 },
        new { Column1 = "Github", Column2 = 2}
        };

        var memoryStream = new MemoryStream();
        memoryStream.SaveAs(values);
        memoryStream.Seek(0, SeekOrigin.Begin);
        return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
        {
            FileDownloadName = "demo.xlsx"
        };
    }
}