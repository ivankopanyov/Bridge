namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpProfIdView
{
    public decimal? ExportId { get; set; }
    public decimal? ProfId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpProfIdView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_PROF_ID_VIEW");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfId)
                .HasColumnName("PROF_ID")
                .HasColumnType("NUMBER");
        });
	}
}
