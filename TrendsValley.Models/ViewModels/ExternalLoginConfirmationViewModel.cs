﻿using System.ComponentModel.DataAnnotations;

namespace TrendsValley.Models.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
