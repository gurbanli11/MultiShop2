﻿using System.ComponentModel.DataAnnotations;

namespace MultiShop.ViewModels.Sliders
{
	public class UpdateSliderVM
	{

		[MaxLength(32), Required]
		public string Title { get; set; }
		[MaxLength(64)]
		public string Subtitle { get; set; }
		[Required]
		public string ImageUrl { get; set; }
	}
}
