using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Application.Services.Excel;

public record CreateExcelResult(
    FileStreamResult File);