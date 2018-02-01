using System;
using MongoDB.Bson;

namespace Ford.Infrastructure.Data.Models
{
    public class CarSchema
    {
        public ObjectId Id { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Motor { get; set; }
        public string GearBox { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}