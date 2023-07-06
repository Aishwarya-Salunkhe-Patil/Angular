using System.ComponentModel.DataAnnotations;

namespace Cards.API.Models
{
    public class Card
    {
        [Key]
        public Guid Id { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public String CardholderName { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string CardNumber { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public int ExpiryMonth { get; set; }

        public int ExpiryYear { get; set; }

        public int CVC { get; set; }
    }
}
