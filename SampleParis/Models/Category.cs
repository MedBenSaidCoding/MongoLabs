namespace SampleParis.Models
{
    public class Category
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string Id {get; set;} = null!;

        [BsonElement("name")]
        public string? Name {get; set;}

    }
}