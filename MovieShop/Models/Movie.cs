using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop.Models
{
    public class Movie
    {
        [Key]
        [MaxLength(10)]
        public int Id { get; set; }

        [StringLength(255)]
        public string? Title { get; set; }

        [MaxLength(10)]
        public int? Duration { get; set; }
        [Range(0, 5)]
        public decimal? Rating { get; set; } = 0;

        [ForeignKey(ConstString.ProducerEntity)]
        public int? ProducerId { get; set; }



        public virtual Producer Producer { get; set; }

        public virtual ICollection<Customer_Movie> Customer_Movies { get; set; } = new HashSet<Customer_Movie>();

    }
}
