using System;
namespace Practica.Date.Entities
{
	public class Group
	{

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<User> Members { get; set; }

    }
}

