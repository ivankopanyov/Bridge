namespace Bridge.Opera.Domain.Entities.Tables;

public partial class InternalSystems
{
    public string Code { get; set; }
    public string Lic1 { get; set; }
    public string Lic2 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InternalSystems>(entity =>
        {
            entity.HasKey(e => e.Code)
                .HasName("INTERNAL_SYSTEMS_PK");

            entity.ToTable("INTERNAL_SYSTEMS");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Lic1)
                .HasColumnName("LIC1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Lic2)
                .HasColumnName("LIC2")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
