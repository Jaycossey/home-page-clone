using System.ComponentModel.DataAnnotations;

namespace opticron_clone.Models;

// Model structure for home page view
public class FeatureModel
{
    // Data id for reference
    public int Id { get; set; }
    // Title content
    public string? Title { get; set; }
    // Image filepath (relative to root)
    public string? ImageSrc { get; set; }
    // Description (lorem 1/2 p) 
    public string? Description { get; set; }
    // Button Text (name specific to section, may not be required TODO: edit if needed)
    public string? FBtnText { get; set; }
}
