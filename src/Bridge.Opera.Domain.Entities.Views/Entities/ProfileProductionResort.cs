namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ProfileProductionResort
{
    public string? Resort { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string? CurrencyCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileProductionResort>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PROFILE_PRODUCTION_RESORT");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
