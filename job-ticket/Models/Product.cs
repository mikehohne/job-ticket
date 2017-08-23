using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace job_ticket.Models
{
	public class Product
	{
		public int Id { get; set; }
		public int productID { get; set; }
		public string productName { get; set; }
		public string imageURL { get; set; }
		public bool hasTemplate { get; set; }
		public float stockQuantity { get; set; }

	}
}