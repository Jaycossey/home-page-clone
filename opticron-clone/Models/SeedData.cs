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
                        FBtnText = "New Products",
                        SectionNum = 1
                    },
                    new FeatureModel
                    {
                        Title = "Field Events",
                        ImageSrc = "/images/telescopicGroup.png",
                        Description = "Lorem Ipsum dolor esquss squall indorime, celatus ignatus.",
                        FBtnText = "View Events",
                        SectionNum = 1
                    },
                    new FeatureModel
                    {
                        Title = "Latest News",
                        ImageSrc = "/images/valleyView.png",
                        Description = "Lorem Ipsum dolor esquss squall indorime, celatus ignatus.",
                        FBtnText = "Read Article",
                        SectionNum = 1
                    },
                    new FeatureModel
                    {
                        Title = "Gallery",
                        ImageSrc = "/images/blueTit.png",
                        Description = "Lorem Ipsum dolor esquss squall indorime, celatus ignatus.",
                        FBtnText = "View Gallery",
                        SectionNum = 1
                    },
                    new FeatureModel
                    {
                        Title = "Discovery WP PC",
                        ImageSrc = "/images/cashBack.png",
                        Description = "£20 Cashback",
                        FBtnText = "",
                        SectionNum = 2
                    },
                    new FeatureModel
                    {
                        Title = "HR ED Fieldscopes",
                        ImageSrc = "/images/olympusBrand.png",
                        Description = "Free Digiscoping Kit",
                        FBtnText = "",
                        SectionNum = 2
                    },
                    new FeatureModel
                    {
                        Title = "IS 60 WP Fieldscope Kits",
                        ImageSrc = "/images/fieldScope.png",
                        Description = "Save 25%",
                        FBtnText = "",
                        SectionNum = 2
                    },
                    new FeatureModel
                    {
                        Title = "Binoculars",
                        ImageSrc = "/images/binoc1.png",
                        Description = "",
                        FBtnText = "",
                        SectionNum = 3
                    },
                    new FeatureModel
                    {
                        Title = "Compact Binoculars",
                        ImageSrc = "/images/compactBinoc.png",
                        Description = "",
                        FBtnText = "",
                        SectionNum = 3
                    },
                    new FeatureModel
                    {
                        Title = "Telescopes & Eyepieces",
                        ImageSrc = "/images/telescope.png",
                        Description = "",
                        FBtnText = "",
                        SectionNum = 3
                    },
                    new FeatureModel
                    {
                        Title = "Observation & Marine",
                        ImageSrc = "/images/binocular.png",
                        Description = "",
                        FBtnText = "",
                        SectionNum = 3
                    }
                );
                context.SaveChanges();
            }
    }
}
