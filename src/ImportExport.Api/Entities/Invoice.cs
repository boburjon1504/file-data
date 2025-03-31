using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ImportExport.Api.Entities;

public class Invoice
{
    [BsonId]
    [BsonRepresentation(BsonType.Binary)]
    [BsonGuidRepresentation(GuidRepresentation.Standard)]
    public Guid Id { get; set; }

    public DateTime IssueDate { get; set; }

    public DateTime DueDate { get; set; }

    public decimal Amount { get; set; }

    public string Currency { get; set; }

    public string PaymentStatus { get; set; }
}
