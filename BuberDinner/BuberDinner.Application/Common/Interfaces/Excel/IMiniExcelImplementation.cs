using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Application.Common.Excel;

public interface IMiniExcelImplementation
{
    FileStreamResult CreateExcelSpreadsheet();
}