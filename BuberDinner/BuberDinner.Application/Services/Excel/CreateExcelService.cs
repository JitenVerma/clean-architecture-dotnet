using BuberDinner.Application.Common.Excel;

namespace BuberDinner.Application.Services.Excel;

public class CreateExcelService : ICreateExcelService
{
    private readonly IMiniExcelImplementation _miniExcelImplementation;

    public CreateExcelService(IMiniExcelImplementation miniExcelImplementation)
    {
        _miniExcelImplementation = miniExcelImplementation;
    }
    public CreateExcelResult CreateExcel()
    {

        var file = _miniExcelImplementation.CreateExcelSpreadsheet();
        
        return new CreateExcelResult(
            file
        );
    }
}