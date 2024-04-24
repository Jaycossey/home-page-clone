using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace opticron_clone.Models;

// Model structure for home page view
public class FeatureModel
{
    // Data id for reference
    public int Id { get; set; }
    // Title content
    public string? Title { get; set; }
    // Image filepath (relative to root)
    [Display(Name = "Image Source")]
    public string? ImageSrc { get; set; }
    // Description (lorem 1/2 p) 
    public string? Description { get; set; }
    // Button Text (name specific to section, may not be required TODO: edit if needed)
    [Display(Name = "Feature Button Text")]
    public string? FBtnText { get; set; }
    // Type integer for section displayType
    public int SectionNum { get; set; }
}
