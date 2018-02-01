using System.ComponentModel.DataAnnotations;

namespace Ford.Domain
{
    public class Car
    {
        public string Id { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int Year{ get; set; }
        [Required]
        public string Motor { get; set; }
        [Required]
        public string GearBox { get; set; }
        public bool Active { get; set; }
    }
}