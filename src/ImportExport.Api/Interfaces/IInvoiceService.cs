using ImportExport.Api.Entities;

namespace ImportExport.Api.Interfaces;

public interface IInvoiceService
{
    Task CreateAsync(Invoice invoice);

    Task<IList<Invoice>> GetAsync();
}
