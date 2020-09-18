using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //throw new System.NotImplementedException();
            builder.HasKey(u => u.Id);
            
            // builder utiliza o padrao fluent
            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);
            
            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400);
            
            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar2");
            
            builder
                .Property(u => u.SobreNome)
                .IsRequired()
                .HasMaxLength(50);

            // relacionamento de 1 usuario para muitos pedidos eh mais usada
            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);
        }
    }
}
