using System.ComponentModel.DataAnnotations;

namespace Models

{
    public class Payment
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? CardOwnerName { get; set; }

        [Required]
        [MaxLength(16)]
        public string? CardNumber { get; set; }

        [Required]
        [MaxLength(5)]
        public string? ExpiraionDate { get; set; }

        [Required]
        [MaxLength(3)]
        public string? SecurityCode { get; set; }
    }
}