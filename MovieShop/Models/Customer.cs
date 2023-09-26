using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop.Models
{
    public class Customer
    {
        [Key]
        [MaxLength(10)]
        public int Id { get; set; }

        [StringLength(255)]
        public string? FirstName { get; set; }

        [StringLength(255)]
        public string? LastName { get; set; }
        
        [StringLength(255)]
        public string? Address { get; set; }
        
        [Column("BirthDate", TypeName = "Date")]
        public DateTime? DoB { get; set; }
        
        [MaxLength(10)]
        public int? PhoneNumber { get; set; }


        public virtual ICollection<Customer_Movie> Customer_Movies { get; set; } = new HashSet<Customer_Movie>();
    }
}
