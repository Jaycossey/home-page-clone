using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;
using NuGet.Protocol.Plugins;

namespace FeaturedData.Models;

// Model of data types for featured section
// view
public class FeaturedItem
{   
    public int Id { get; set; }
    public string ItemTitle { get; set; }
    public string ImageSrc { get; set; }
    public string Description { get; set; }
    public string BtnText { get; set; }
}