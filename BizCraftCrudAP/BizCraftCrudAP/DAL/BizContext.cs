using BizCraftCrudAP.Models;
using Microsoft.EntityFrameworkCore;

namespace BizCraftCrudAP.DAL
{
    public class BizContext : DbContext
    {
        public BizContext(DbContextOptions<BizContext>options) : base(options)
        {

        }

        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Team>().HasData(
                new Team {Id = 1, Image = "woman1.jpg", Fullname = "<h3>Vosgi Varduhi</h3>", Position = "<p>Web Designer</p>",
                    Facelogo = "<i class='fa fa-facebook'></i>", Twitlogo = "<i class='fa fa-twitter'></i>", Googlogo = "<i class='fa fa-google-plus'></i>",
                    Linkelogo = "<i class='fa fa-linkedin'></i>",Otherlogo = "<i class='fa fa-dribbble'></i>"
                },
                new Team { Id = 2, Image = "man1.jpg",
                    Fullname = "<h3>Robert Aleska</h3>",
                    Position = "<p>Developer</p>",
                    Facelogo = "<i class='fa fa-facebook'></i>",
                    Twitlogo = "<i class='fa fa-twitter'></i>",
                    Googlogo = "<i class='fa fa-google-plus'></i>",
                    Linkelogo = "<i class='fa fa-linkedin'></i>",
                    Otherlogo = "<i class='fa fa-dribbble'></i>"
                },
                new Team { Id = 3, Image = "woman2.jpg",
                    Fullname = "<h3>Taline Voski</h3>",
                    Position = "<p>Graphic Designer</p>",
                    Facelogo = "<i class='fa fa-facebook'></i>",
                    Twitlogo = "<i class='fa fa-twitter'></i>",
                    Googlogo = "<i class='fa fa-google-plus'></i>",
                    Linkelogo = "<i class='fa fa-linkedin'></i>",
                    Otherlogo = "<i class='fa fa-dribbble'></i>"
                },
                new Team { Id = 4, Image = "man22.jpg",
                    Fullname = "<h3>Alban Spencer</h3>",
                    Position = "<p>Junior Developer</p>",
                    Facelogo = "<i class='fa fa-facebook'></i>",
                    Twitlogo = "<i class='fa fa-twitter'></i>",
                    Googlogo = "<i class='fa fa-google-plus'></i>",
                    Linkelogo = "<i class='fa fa-linkedin'></i>",
                    Otherlogo = "<i class='fa fa-dribbble'></i>"
                }
                );

        }
    }
}
