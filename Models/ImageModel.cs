using System.ComponentModel.DataAnnotations;

namespace InfoVerse.Models
{
    public class ImageModel
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? imgUrl { get; set; }
        public string? TransitionType { get; set; }
        public int? AutoCycleTime { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool isActive { get; set; } = true;
    }
}
