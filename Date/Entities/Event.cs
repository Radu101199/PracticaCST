using System;
namespace Practica.Date.Entities
{
	public class Event
	{

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public string Location { get; set; }

        public int Participants { get; set; }

        public List<User> AttendingUsers { get; set; }

    }
}

