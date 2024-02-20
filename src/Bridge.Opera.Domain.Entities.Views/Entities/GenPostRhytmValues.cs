namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GenPostRhytmValues
{
    public string? Code { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GenPostRhytmValues>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GEN_POST_RHYTM_VALUES");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);
        });
	}
}
