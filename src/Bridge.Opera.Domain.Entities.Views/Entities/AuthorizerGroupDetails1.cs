namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AuthorizerGroupDetails1
{
    public string Resort { get; set; }
    public string AuthGroupCode { get; set; }
    public decimal GroupHeaderId { get; set; }
    public decimal? CreditLimit { get; set; }
    public decimal? OccurrenceLimit { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AuthorizerGroupDetails1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AUTHORIZER_GROUP_DETAILS");

            entity.Property(e => e.AuthGroupCode)
                .IsRequired()
                .HasColumnName("AUTH_GROUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupHeaderId)
                .HasColumnName("GROUP_HEADER_ID")
                .HasColumnType("NUMBER");

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
