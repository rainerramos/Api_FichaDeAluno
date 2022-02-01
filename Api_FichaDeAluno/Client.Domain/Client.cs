using System.ComponentModel.DataAnnotations;

namespace ARF.Domain
{
    public class Client
    {
        public Client()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        [Required(ErrorMessage = "Birhtday is required")]
        public DateTime Birthday { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        [MinLength(3, ErrorMessage = "Insert more than 3 characters")]
        [MaxLength(150, ErrorMessage = "The max characters are 150")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please insert a valid weight")]
        public double Weight { get; set; }

        [Required(ErrorMessage = "Please insert a valid height")]
        public double Height { get; set; }

        [Required(ErrorMessage = "Please insert a valid phone number")]
        public int Phone { get; set; }

        [Required(ErrorMessage = "Please insert a valid CPF")]
        public string CPF { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Address is required")]
        public string Address { get; set; }
    }
}
