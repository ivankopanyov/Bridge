namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AuthorizerLimitsData
{
    public string? Resort { get; set; }
    public string? Description { get; set; }
    public decimal? AuthHeaderId { get; set; }
    public decimal? AuthorizerId { get; set; }
    public string? AppUser { get; set; }
    public DateTime? TrxDate { get; set; }
    public decimal? CreditLimit { get; set; }
    public decimal? Actual { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AuthorizerLimitsData>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AUTHORIZER_LIMITS_DATA");

            entity.Property(e => e.Actual)
                .HasColumnName("ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppUser)
                .IsRequired()
                .HasColumnName("APP_USER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AuthHeaderId)
                .HasColumnName("AUTH_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AuthorizerId)
                .HasColumnName("AUTHORIZER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");
        });
	}
}
