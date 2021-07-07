namespace BigSchool.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        [Required]
        public int Id { get; set; }

        [StringLength(128)]
        public string LecturerId { get; set; }

        [Required(ErrorMessage ="không để trống")]
        [StringLength(255)]
        public string Place { get; set; }
        [Required(ErrorMessage = "không để trống")]
        public int? CategoryId { get; set; }
        public string Name;

        public DateTime? DateTime { get; set; }
        public AspNetUser AspNetUser { get; internal set; }

        public List<Category> ListCategory = new List<Category>();
    }
}
