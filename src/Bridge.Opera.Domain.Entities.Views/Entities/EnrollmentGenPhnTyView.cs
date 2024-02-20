namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EnrollmentGenPhnTyView
{
    public string? Code { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EnrollmentGenPhnTyView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ENROLLMENT_GEN_PHN_TY_VIEW");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);
        });
	}
}
