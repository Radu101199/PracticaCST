using System;
using Microsoft.EntityFrameworkCore;
using Practica.Date.Entities;

namespace Practica.Date
{
	public class SocialMediaDb : DbContext
	{
		public SocialMediaDb(DbContextOptions<SocialMediaDb> options) : base(options)
		{

		}

		public DbSet<User> Users { get; set; }

		public DbSet<Post> Posts { get; set; }

        public DbSet<Advertisement> Advertisements { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Friend> Friends { get; set; }

        public DbSet<FriendRequest> friendRequests { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Page> Pages { get; set; }

        public DbSet<Group> Groups { get; set; }

    }
}

