using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Entities
{
    public class PointOfInterest
    {
        //even though we have annotaions on create and update dto, it is best practice to apply them at lowest level which is entity

        [Key]  
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        [ForeignKey("CityId")] //this is not necessary since convention does this anyways (FK named after navigation properties class name followed by Id)
        public City City { get; set; }  //navigation property, defines relationship to parent, defaults to PK of City to become FK here

        public int CityId { get; set; }  //it's not required to explicitly define this FK property on the dependent class, but is recommended 
    }
}
