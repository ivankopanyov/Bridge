namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class StatusTypeCodesV
{
    public string? Code { get; set; }
    public string? Description { get; set; }
    public string? StatusType { get; set; }
    public string? DeductType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StatusTypeCodesV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("STATUS_TYPE_CODES_V");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(11)
                .IsUnicode(false);

            entity.Property(e => e.DeductType)
                .HasColumnName("DEDUCT_TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.Property(e => e.StatusType)
                .HasColumnName("STATUS_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
