using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleNewsWebsite.Models
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(3000)")]
        public string Text { get; set; }

        [Column(TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime CreatedDate { get; set; }

        public string CreatorId { get; set; }

        public Guid NewsId { get; set; }

        [Required]
        [ForeignKey("CreatorId")]
        public ApplicationUser Creator { get; set; }

        [Required]
        [ForeignKey("NewsId")]
        public News News { get; set; }
    }
}
