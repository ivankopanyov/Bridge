namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GemTranslation1
{
    public decimal? CodeId { get; set; }
    public string? CodeType { get; set; }
    public string? Code { get; set; }
    public string? Description { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? DisplayYn { get; set; }
    public decimal? OrderBy { get; set; }
    public string? WebBookingYn { get; set; }
    public decimal? WebSetup { get; set; }
    public decimal? WebSetdown { get; set; }
    public string? FulldayYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemTranslation1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GEM_TRANSLATION");

            entity.Property(e => e.Code)
                .IsRequired()
                .HasColumnName("CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CodeId)
                .HasColumnName("CODE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CodeType)
                .IsRequired()
                .HasColumnName("CODE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.DisplayYn)
                .HasColumnName("DISPLAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FulldayYn)
                .HasColumnName("FULLDAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WebBookingYn)
                .HasColumnName("WEB_BOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.WebSetdown)
                .HasColumnName("WEB_SETDOWN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WebSetup)
                .HasColumnName("WEB_SETUP")
                .HasColumnType("NUMBER");
        });
	}
}
