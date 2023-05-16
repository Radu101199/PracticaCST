using System;
namespace Practica.Date.Entities
{
	public class Page
	{

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public List<User> Admins { get; set; }

        public int Likes { get; set; }

    }
}

