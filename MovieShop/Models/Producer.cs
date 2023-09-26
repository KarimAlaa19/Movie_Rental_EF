using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MovieShop.Models
{
    public class Producer
    {
        [Key]
        [MaxLength(10)]
        public int Id { get; set; }

        [StringLength(200)]
        public string? CompanyName { get; set; }
        
        [StringLength(255)]
        public string? Country { get; set; }

        public virtual ICollection<Movie> Movies { get; set; } = new HashSet<Movie>();

    }
}
