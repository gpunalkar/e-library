using System.ComponentModel.DataAnnotations;

{
    public class Book : Entity
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Author { get; set; }
    }
}
