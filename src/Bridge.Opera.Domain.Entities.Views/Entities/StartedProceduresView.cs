namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class StartedProceduresView
{
    public string? Code { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StartedProceduresView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("STARTED_PROCEDURES_VIEW");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
