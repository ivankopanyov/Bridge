namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AuthorizerLimitsDetails
{
    public decimal AuthDetailId { get; set; }
    public string Resort { get; set; }
    public decimal AuthorizerId { get; set; }
    public decimal AuthHeaderId { get; set; }
    public string TrxCode { get; set; }
    public decimal? ArrangementId { get; set; }
    public string ArrangementCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string AuthGroupCode { get; set; }

    public virtual TrxCodeArrangement Arrangement { get; set; }
    public virtual AuthorizerLimitsHeader AuthorizerLimitsHeader { get; set; }
    public virtual TrxCodes TrxCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AuthorizerLimitsDetails>(entity =>
        {
            entity.HasKey(e => new { e.AuthDetailId, e.Resort })
                .HasName("ALD_PK");

            entity.ToTable("AUTHORIZER$_LIMITS_DETAILS");

            entity.HasIndex(e => e.ArrangementId)
                .HasName("ALD_ARRANGE_FK_I");

            entity.HasIndex(e => new { e.AuthHeaderId, e.Resort })
                .HasName("ALD_ALH_FK_I");

            entity.HasIndex(e => new { e.Resort, e.TrxCode })
                .HasName("ALD_TC_FK_I");

            entity.HasIndex(e => new { e.Resort, e.AuthorizerId, e.AuthHeaderId, e.TrxCode, e.ArrangementId })
                .HasName("ALD_UK")
                .IsUnique();

            entity.Property(e => e.AuthDetailId)
                .HasColumnName("AUTH_DETAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArrangementCode)
                .HasColumnName("ARRANGEMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArrangementId)
                .HasColumnName("ARRANGEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AuthGroupCode)
                .HasColumnName("AUTH_GROUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AuthHeaderId)
                .HasColumnName("AUTH_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AuthorizerId)
                .HasColumnName("AUTHORIZER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

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

			if (!types.Contains(typeof(TrxCodeArrangement)))
				entity.Ignore(e => e.Arrangement);
			else
	            entity.HasOne(d => d.Arrangement)
	                .WithMany(p => p.AuthorizerLimitsDetails)
	                .HasForeignKey(d => d.ArrangementId)
	                .HasConstraintName("ALD_ARRANGE_FK");

			if (!types.Contains(typeof(AuthorizerLimitsHeader)))
				entity.Ignore(e => e.AuthorizerLimitsHeader);
			else
	            entity.HasOne(d => d.AuthorizerLimitsHeader)
	                .WithMany(p => p.AuthorizerLimitsDetails)
	                .HasForeignKey(d => new { d.AuthHeaderId, d.Resort })
	                .HasConstraintName("ALD_ALH_FK");

			if (!types.Contains(typeof(TrxCodes)))
				entity.Ignore(e => e.TrxCodes);
			else
	            entity.HasOne(d => d.TrxCodes)
	                .WithMany(p => p.AuthorizerLimitsDetails)
	                .HasForeignKey(d => new { d.Resort, d.TrxCode })
	                .HasConstraintName("ALD_TC_FK");
        });
	}
}
