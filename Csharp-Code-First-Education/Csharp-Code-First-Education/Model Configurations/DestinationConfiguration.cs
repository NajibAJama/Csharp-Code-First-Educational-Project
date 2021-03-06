﻿using System.Data.Entity.ModelConfiguration;

namespace Csharp_Code_First_Education.Model_Configurations
{
    class DestinationConfiguration : EntityTypeConfiguration<Destination>
    {
        public DestinationConfiguration()
        {
            Property(d => d.Name).HasMaxLength(100);
            Property(d => d.Description).HasMaxLength(400);
            Property(d => d.Country).HasMaxLength(100);
            Property(d => d.Photo).HasColumnType("image");
            HasMany(d => d.Lodgings).WithRequired(l => l.Destination);
            ToTable("Locations", "baga");
            Property(d => d.Name).HasColumnName("LocationName");
            Property(d => d.DestinationId).HasColumnName("LocationID");

            //Preventing Properties from Being Included in the Model
            //Ignore(d => d.TodayForecast);


            //Map(m =>
            //{
            //    m.Properties(d => new
            //    {
            //        d.Name,d.Country,d.Description
            //    });
            //    m.ToTable("Locations");
            //});
            //Map(m =>
            //{
            //    m.Properties(d => new
            //    {
            //        d.Photo
            //    });
            //    m.ToTable("LocationPhotos");
            //});
        }
    }
}
