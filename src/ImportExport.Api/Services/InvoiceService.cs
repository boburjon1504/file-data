using ImportExport.Api.Entities;
using ImportExport.Api.Interfaces;
using MongoDB.Driver;

namespace ImportExport.Api.Services;

public class InvoiceService : IInvoiceService
{
    private readonly IMongoCollection<Invoice> collection;

    public InvoiceService()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        var db = client.GetDatabase("reportHub");
        collection = db.GetCollection<Invoice>("invoices");
    }
    public async Task CreateAsync(Invoice invoice)
    {
        invoice.Id = Guid.NewGuid();
        invoice.IssueDate = DateTime.UtcNow;
        invoice.DueDate = DateTime.UtcNow.AddDays(30);
        invoice.PaymentStatus = "Pending";
        invoice.Currency = "USD";

        await collection.InsertOneAsync(invoice);
    }

    public async Task<IList<Invoice>> GetAsync()
    {
        return await collection.Find(x => true).ToListAsync();
    }
}
