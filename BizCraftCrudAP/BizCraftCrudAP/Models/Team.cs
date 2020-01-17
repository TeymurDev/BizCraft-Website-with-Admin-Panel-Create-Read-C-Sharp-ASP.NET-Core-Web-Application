using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizCraftCrudAP.Models
{
    public class Team
    {
        public int Id { get; set; }
        [StringLength(300)]
        public string Image { get; set; }
        [Required, StringLength(100)]
        public string Fullname { get; set; }
        [Required, StringLength(100)]
        public string Position { get; set; }
        [Required, StringLength(150)]
        public string Facelogo { get; set; }
        [Required, StringLength(150)]
        public string Twitlogo { get; set; }
        [Required, StringLength(150)]
        public string Googlogo { get; set; }
        [Required, StringLength(150)]
        public string Linkelogo { get; set; }
        [Required, StringLength(150)]
        public string Otherlogo { get; set; }

        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
    }
}
