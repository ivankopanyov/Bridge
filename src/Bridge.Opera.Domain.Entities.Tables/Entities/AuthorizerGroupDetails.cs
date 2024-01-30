namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AuthorizerGroupDetails
{
    public string? Resort { get; set; }
    public string? AuthGroupCode { get; set; }
    public decimal? GroupHeaderId { get; set; }
    public string? TrxCode { get; set; }
    public decimal? ArrangementId { get; set; }
    public string? ArrangementCode { get; set; }
    public decimal? CreditLimit { get; set; }
    public decimal? OccurrenceLimit { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual AuthorizerGroups AuthorizerGroups { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AuthorizerGroupDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("AUTHORIZER$_GROUP_DETAILS");

            entity.HasIndex(e => new { e.Resort, e.AuthGroupCode, e.TrxCode, e.ArrangementId })
                .HasName("AUTHORIZER$_GROUP_DETAILS_UK")
                .IsUnique();

            entity.Property(e => e.ArrangementCode)
                .HasColumnName("ARRANGEMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArrangementId)
                .HasColumnName("ARRANGEMENT_ID")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccurrenceLimit)
                .HasColumnName("OCCURRENCE_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(AuthorizerGroups)))
				entity.Ignore(e => e.AuthorizerGroups);
			else
	            entity.HasOne(d => d.AuthorizerGroups)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.AuthGroupCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("AUTHORIZER$_GROUP_DETAILS_FK");
        });
	}
}
