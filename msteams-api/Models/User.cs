using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace msteams_api.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string userFirstName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string userLastName { get; set; }
    }
}
