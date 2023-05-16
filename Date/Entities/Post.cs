using System;
namespace Practica.Date.Entities
{
	public class Post
	{
		public int Id { get; set; }

		public int UserId { get; set; }

		public string Content { get; set; }

        public DateTime Date { get; set; }

		public string Location { get; set; }

		public string PictureURL { get; set; }

		public string VideoURL { get; set; }

		public string Reaction { get; set; }

        public User User { get; set; }

        public List<Comment> Comments { get; set; }

        //public List<Photo> Photos { get; set; }

        //public List<Video> Videos { get; set; }

	}
}

