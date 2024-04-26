using BuberDinner.Application.Services.Excel;
using BuberDinner.Contracts.Excel;
using Microsoft.AspNetCore.Mvc;
using MiniExcelLibs;

namespace BuberDinner.Api.Controllers;

[ApiController]
[Route("excel")]
public class ExcelController : ControllerBase
{

    private readonly ICreateExcelService _createExcelService;

    public ExcelController(ICreateExcelService createExcelService)
    {
        _createExcelService = createExcelService;
    }

    [HttpGet("create-excel")]
    public IActionResult CreateExcel()
    {
        
        var createExcelResult = _createExcelService.CreateExcel();
        var response = new CreateExcelResponse(
            createExcelResult.File
        );

        return Ok(response.File);
    }

    [HttpGet("download-excel")]
    public IActionResult DownloadExcel()
    {
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