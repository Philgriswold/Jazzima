using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jazzima1.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
        public int UserId { get; set; }
    }
}
