using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWorkInDal.Model
{
    [Table("Students")]
    public class Student
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Column(TypeName ="varchar(200)")]
        [Required]
        public string Name { get; set; }
        public int Marks { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string Subjects { get; set; }
    }
}
