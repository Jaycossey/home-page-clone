using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace opticron_clone.Models;

// Model structure for home page view
public class Offer
{
    // Data id for reference
    public int Id { get; set; }
    // Title content
    public string? Title { get; set; }
    // Image filepath (relative to root)
    [Display(Name = "Image Source")]
    public string? ImageSrc { get; set; }
    public string? OfferDetail { get; set; }
}
