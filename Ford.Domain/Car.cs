using System.Runtime.Serialization;
using MongoDB.Bson;

namespace Ford.Domain
{
    public class Car
    {
        public ObjectId Id { get; set; }
        public string Model { get; set; }
        public int Year{ get; set; }
        public string Motor { get; set; }
        public string GearBox { get; set; }
        public bool Active { get; set; }
    }
}