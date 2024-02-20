namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AuthorizerLimitsHeader
{
    public AuthorizerLimitsHeader()
    {
        AuthorizerLimitsDetails = new HashSet<AuthorizerLimitsDetails>();
    }

    public decimal? AuthHeaderId { get; set; }
    public string? Resort { get; set; }
    public decimal? AuthorizerId { get; set; }
    public decimal? CreditLimit { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? OccurrenceLimit { get; set; }

    public virtual ICollection<AuthorizerLimitsDetails> AuthorizerLimitsDetails { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AuthorizerLimitsHeader>(entity =>
        {
            entity.HasKey(e => new { e.AuthHeaderId, e.Resort })
                .HasName("ALH_PK");

            entity.ToTable("AUTHORIZER$_LIMITS_HEADER");

            entity.Property(e => e.AuthHeaderId)
                .HasColumnName("AUTH_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AuthorizerId)
                .HasColumnName("AUTHORIZER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccurrenceLimit)
                .HasColumnName("OCCURRENCE_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(AuthorizerLimitsDetails)))
				entity.Ignore(e => e.AuthorizerLimitsDetails);
		});
	}
}
