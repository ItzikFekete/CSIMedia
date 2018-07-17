using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace CSIMedia.Models
{
    public class Media
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
    public class MediaDBContext : DbContext
    {
        public DbSet<Media> Medias { get; set; }

        public System.Data.Entity.DbSet<CSIMedia.Table> Tables { get; set; }
    }
}