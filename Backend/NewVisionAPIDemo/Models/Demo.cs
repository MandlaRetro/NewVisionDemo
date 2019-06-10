using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewVisionAPIDemo.Models {
    public class Demo {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string ImageBase64 { get; set; }
    }
}
