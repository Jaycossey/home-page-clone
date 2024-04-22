using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using opticron_clone.Data;
using System;
using System.Linq;

namespace opticron_clone.Models;
// Static class 
public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new FeatureModelContext(
            serviceProvider.GetRequiredService<DbContextOptions<FeatureModelContext>>()))
            {
                // Search for existing DB 
                if (context.FeatureModel.Any())
                {
                    // DB already seeded
                    return;
                }
                context.FeatureModel.AddRange(
                    new FeatureModel
                    {
                        Title = "New Products",
                        ImageSrc = "/images/eagleFish.png",
                        Description = "Lorem Ipsum dolor esquss squall indorime, celatus ignatus.",
                        FBtnText = "New Products"
                    },
                    new FeatureModel
                    {
                        Title = "Field Events",
                        ImageSrc = "/images/telescopicGroup.png",
                        Description = "Lorem Ipsum dolor esquss squall indorime, celatus ignatus.",
                        FBtnText = "View Events"
                    },
                    new FeatureModel
                    {
                        Title = "Latest News",
                        ImageSrc = "/images/valleyView.png",
                        Description = "Lorem Ipsum dolor esquss squall indorime, celatus ignatus.",
                        FBtnText = "Read Article"
                    },
                    new FeatureModel
                    {
                        Title = "Gallery",
                        ImageSrc = "/images/blueTit.png",
                        Description = "Lorem Ipsum dolor esquss squall indorime, celatus ignatus.",
                        FBtnText = "View Gallery"
                    }
                );
                context.SaveChanges();
            }
    }
}
