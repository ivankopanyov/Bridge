namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GuestCheckDetails
{
    public string? CheckNumber { get; set; }
    public string? CheckDetail { get; set; }
    public DateTime? CheckDate { get; set; }
    public string? CheckOutlet { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GuestCheckDetails>(entity =>
        {
            entity.HasKey(e => new { e.CheckNumber, e.CheckDate })
                .HasName("GST_CHK_DETAIL_PK");

            entity.ToTable("GUEST_CHECK_DETAILS");

            entity.Property(e => e.CheckNumber)
                .HasColumnName("CHECK_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CheckDate)
                .HasColumnName("CHECK_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CheckDetail)
                .HasColumnName("CHECK_DETAIL")
                .HasColumnType("CLOB");

            entity.Property(e => e.CheckOutlet)
                .HasColumnName("CHECK_OUTLET")
                .HasMaxLength(3)
                .IsUnicode(false);
        });
	}
}
