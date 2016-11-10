namespace stixAPI.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Stig
    {
        [Key]
        public int Id;

        [Required]
        public string Title;

        [Required]
        public string Description;

        public string Location;
    }
}
