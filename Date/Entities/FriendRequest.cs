using System;
namespace Practica.Date.Entities
{
	public class FriendRequest
	{

        public int Id { get; set; }

        public DateTime DateSent { get; set; }

        public int SenderId { get; set; }

        public User Sender { get; set; }

        public int RecipientId { get; set; }

        public User Recipient { get; set; }

    }
}

