using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Zust.Entities.Models
{
    public class CustomIdentityDbContext : IdentityDbContext<CustomIdentityUser, CustomIdentityRole, string>
    {

        public CustomIdentityDbContext()
        {

        }

        public CustomIdentityDbContext(DbContextOptions<CustomIdentityDbContext> options)
            : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Friendship> Friends { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<FriendRequest> FriendRequests { get; set; }


     //   protected override void OnModelCreating(ModelBuilder modelBuilder)
     //   {
     //       base.OnModelCreating(modelBuilder);

     //       modelBuilder.Entity<FriendRequest>()
     //.HasOne(request => request.Sender)
     //.WithMany(user => user.FriendRequestsSent)
     //.HasForeignKey(request => request.SenderId);

     //       modelBuilder.Entity<FriendRequest>()
     //           .HasOne(request => request.Receiver)
     //           .WithMany(user => user.FriendRequestsReceived)
     //           .HasForeignKey(request => request.ReceiverId);
     //   }

    }

}
