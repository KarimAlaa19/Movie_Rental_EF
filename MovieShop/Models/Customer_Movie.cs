using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop.Models
{
    public class Customer_Movie
    {
        [ForeignKey(ConstString.CustomerEntity)]
        public int CustomerId{ get; set; }
        [ForeignKey(ConstString.MovieEntity)]
        public int MovueId { get; set; }

        [Column("Date_Rented")]
        public DateTime? DateRented { get; set; }

        [Column("Due_Date")]
        public DateTime? DueDate { get; set; }


        public virtual Customer Customer { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
