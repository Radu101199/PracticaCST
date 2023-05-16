using System;
namespace Practica.Date.Entities
{
	public class User
	{

		public int Id { get; set; }

		public string LastName { get; set; }

		public string FirstName { get; set; }

        public string Gender { get; set; }

        public string NickName { get; set; }

		public string Email { get; set; }

		public DateTime BirthDate { get; set; }

		public string LivesAt { get; set; }

		public string Education { get; set; }

		public string WorkPlace { get; set; }

		public ICollection<Post> Posts { get; set; }

		public string HashedPassword { get; set; }

	}
}
