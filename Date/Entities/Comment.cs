using System;
namespace Practica.Date.Entities
{
	public class Comment
	{
        public int Id { get; set; }

        public int PostId { get; set; }

        public int UserId { get; set; }

        public string Content { get; set; }

        public string Reaction { get; set; }

        public DateTime DateCommented { get; set; }

        public User User { get; set; }

    }
}

