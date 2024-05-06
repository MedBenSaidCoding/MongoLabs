namespace SampleParis.Models
{
    public class Product
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string Id {get; set;} = null!;

        [BsonElement("name"),]
        public string? Name {get; set;} = null!;

        [BsonElement("price")]
        public decimal Price {get; set;}

        [BsonElement("category")]
        public string? CategoryId {get;set;} 
    }
}