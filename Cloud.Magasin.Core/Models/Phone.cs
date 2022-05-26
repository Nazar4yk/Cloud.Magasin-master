﻿using MongoDB.Bson.Serialization.Attributes;

namespace Cloud.Magasin.Core.Models
{
    public class Phone
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
    }
}
