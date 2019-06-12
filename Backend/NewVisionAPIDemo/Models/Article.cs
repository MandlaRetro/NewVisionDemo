using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewVisionAPIDemo.Models {
    public class Article {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ImageBase64 { get; set; }
        public DateTime UploadDate { get; set; }
    }
}
