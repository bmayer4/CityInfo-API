using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Entities
{
    public class City  //did not put annotations on citydto because it was only used to get data, not store it
    {
        [Key]  //this isn't necessary since it is an Id field or ends in Id, defaults to primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   //this is default as well
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        public ICollection<PointOfInterest> PointsOfInterest { get; set; } = new List<PointOfInterest>();  //init to empty list good idea to avoid null reference exceptions
    }
}
