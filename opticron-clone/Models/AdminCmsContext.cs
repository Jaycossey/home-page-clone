using System.ComponentModel.DataAnnotations;

namespace AdminCms.Models;

public class AdminCmsContext
{
    public int Id { get; set; }
    public string? Title { get; set; }
}