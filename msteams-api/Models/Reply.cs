using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace msteams_api.Models
{
    public class Reply
    {
        [Key]
        public int id { get; set; }

        public int postId { get; set; }

        public int replySenderId { get; set; }

        [Timestamp]
        public DateTime repliedTime { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        public string content { get; set; }
    }
}
