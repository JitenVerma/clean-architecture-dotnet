using Microsoft.AspNetCore.Mvc;
namespace BuberDinner.Contracts.Excel;

public record CreateExcelResponse(
    FileStreamResult File);