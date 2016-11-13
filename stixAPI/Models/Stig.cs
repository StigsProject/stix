﻿namespace stixAPI.Models
{
	using System.ComponentModel.DataAnnotations;

	public class Stig
	{
		public int Id { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public string Description { get; set; }

		public string Location { get; set; }
	}
}
