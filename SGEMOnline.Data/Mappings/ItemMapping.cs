using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGEMOnline.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEMOnline.Data.Mappings
{
    public class ItemMapping : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(i => i.Codigo);

            builder.Property(i => i.Descricao)
                .IsRequired();
        }
    }
}
