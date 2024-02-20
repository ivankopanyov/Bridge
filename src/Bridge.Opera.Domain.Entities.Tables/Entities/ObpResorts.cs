namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ObpResorts
{
    public string? ProcedureName { get; set; }
    public string? Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObpResorts>(entity =>
        {
            entity.HasKey(e => new { e.ProcedureName, e.Resort })
                .HasName("OBP_RESORTS_PK");

            entity.ToTable("OBP_RESORTS");

            entity.Property(e => e.ProcedureName)
                .HasColumnName("PROCEDURE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
