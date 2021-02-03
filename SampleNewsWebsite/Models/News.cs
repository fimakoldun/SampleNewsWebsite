using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleNewsWebsite.Models
{
    public class News
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid Id { get; set; }

        [Column( TypeName = "datetime" )]
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime EditedDate { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string Text { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(400)")]
        public string Title { get; set; }

        public string CreatorId { get; set; }

        [Required]
        [ForeignKey("CreatorId")]
        public ApplicationUser Creator { get; set; }

        public string EditorId { get; set; }

        [Required]
        [ForeignKey("EditorId")]
        public ApplicationUser Editor { get; set; }
    }
}
