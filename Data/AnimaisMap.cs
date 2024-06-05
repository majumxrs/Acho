using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data
{
    public class AnimaisMap : IEntityTypeConfiguration<AnimaisModel>
    {
        public void Configure(EntityTypeBuilder<AnimaisModel> builder)
        {
            builder.HasKey(x => x.AnimaisId);
            builder.Property(x => x.AnimalNome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.AnimalRaca).IsRequired().HasMaxLength(255);
            builder.Property(x => x.AnimalTipo).IsRequired().HasMaxLength(255);
            builder.Property(x => x.AnimalCor).IsRequired().HasMaxLength(255);
            builder.Property(x => x.AnimalSexo).IsRequired().HasMaxLength(255);
            builder.Property(x => x.AnimalObservacao).IsRequired().HasMaxLength(255);
            builder.Property(x => x.AnimalFoto).IsRequired().HasMaxLength(255);
            builder.Property(x => x.AnimalDataDesaparecimento).IsRequired().HasMaxLength(255);
            builder.Property(x => x.AnimalDataEncontro);
            builder.Property(x => x.AnimalStatus).IsRequired();
            builder.Property(x => x.UsuarioId).IsRequired().HasMaxLength(255);
        }
    }
}
