using ImportExport.Api.Entities;
using ImportExport.Api.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ImportExport.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController(IInvoiceService invoiceService) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateInvoice([FromBody] Invoice invoice)
        {
            await invoiceService.CreateAsync(invoice);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetInvoices()
        {
            var invoices = await invoiceService.GetAsync();
            return Ok(invoices);
        }

    }
}
