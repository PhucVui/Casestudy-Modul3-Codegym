﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MotobikeShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotobikeShop.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(el => el.Id);

            builder.Property(el => el.CreateAt).IsRequired();
            builder.Property(el => el.PayStatus).IsRequired();
            builder.Property(el => el.PayStatus).IsRequired();
        }
    }
}
