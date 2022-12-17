using DietitianConsultation.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietitianConsultation.Server.Configurations.Entities
{
    public class PatientSeedConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasData(
        new Patient
        {
            Id = 1,
            Name = "Joe",
            Gender = "Male",
            Address = "Tampines Street 21 blk 123",
            DateOfBirth ="22/1/2001",
            Contact = 85567722,
            DateCreated = DateTime.Now,
            DateUpdated = DateTime.Now,
            CreatedBy = "System",
            UpdatedBy = "System"
        },
        new Patient
        {
            Id = 2,
            Name = "Steven",
            Gender = "Male",
            Address = "Tampines Street 21 blk 123",
            DateOfBirth = "21/7/2006",
            Contact = 84403885,
            DateCreated = DateTime.Now,
            DateUpdated = DateTime.Now,
            CreatedBy = "System",
            UpdatedBy = "System"
        }
);
         


        }
    }
}
