using DietitianConsultation.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietitianConsultation.Server.Configurations.Entities
{
    public class FoodSeedConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData(
                new Food
                {
                Id = 1,
                Name = "Chicken And Broccoli",
                Type = "Meat and Vegetable",
                Description="Healthy food that contain vitamin and protein",
                Calories = 220,
                ServingSize = 1,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
        },
                new Food
                {
                 Id = 2,
                 Name = "Pizza",
                 Description = "Fast Food(Unhealthy)",
                 Calories = 266,
                 ServingSize = 1,
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System"
                }
            );
         


        }
    }
}
