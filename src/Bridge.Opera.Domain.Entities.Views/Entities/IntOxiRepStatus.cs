namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IntOxiRepStatus
{
    public string? Code { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntOxiRepStatus>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INT_OXI_REP_STATUS");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
