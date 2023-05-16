using System;
namespace Practica.Date.Entities
{
	public class Advertisement
	{

        public int Id { get; set; }

        public string Text { get; set; }

        public string ImageUrl { get; set; }

        public string VideoUrl { get; set; }

        public string TargetAudience { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Cost { get; set; }

    }
}

