namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidObpResorts
{
    public string? ProcedureName { get; set; }
    public string? Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidObpResorts>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_OBP_RESORTS");

            entity.Property(e => e.ProcedureName)
                .IsRequired()
                .HasColumnName("PROCEDURE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
