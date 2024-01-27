namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AuthorizerLimitsHeader1
{
    public string Resort { get; set; }
    public decimal AuthHeaderId { get; set; }
    public decimal AuthorizerId { get; set; }
    public string Description { get; set; }
    public decimal? CreditLimit { get; set; }
    public decimal? OccurrenceLimit { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AuthorizerLimitsHeader1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AUTHORIZER_LIMITS_HEADER");

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

            entity.Property(e => e.OccurrenceLimit)
                .HasColumnName("OCCURRENCE_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
