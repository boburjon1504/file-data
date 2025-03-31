using ImportExport.Api.Enums;
using ImportExport.Api.Interfaces;
using ImportExport.Api.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ImportExport.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController(IMediator mediator, ICSVService csvService) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> ImportDataFromFile(IFormFile file)
        {
            var res = await mediator.Send(file);

            return Ok(res);
        }

        [HttpGet]
        public async Task<IActionResult> ExportDataToFile([FromQuery] FileType type)
        {

            var stream = new MemoryStream();
            await csvService.ExportDataToFileAsync(stream);
            stream.Position = 0;

            return File(stream,"text/csv","generated-data.csv");
        }
    }
}
