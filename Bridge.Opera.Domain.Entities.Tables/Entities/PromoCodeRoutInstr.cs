namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PromoCodeRoutInstr
{
    public string Resort { get; set; }
    public string PromoCode { get; set; }
    public string TrxCode { get; set; }
    public decimal? ArrangementId { get; set; }
    public string PromptForAuthorizerYn { get; set; }
    public decimal? CreditLimit { get; set; }
    public decimal? RoutingPercent { get; set; }
    public string Comments { get; set; }
    public decimal? MembershipId { get; set; }
    public decimal? AuthorizerId { get; set; }
    public decimal? FolioView { get; set; }
    public string AutoPopulateRoutingYn { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string Day1 { get; set; }
    public string Day2 { get; set; }
    public string Day3 { get; set; }
    public string Day4 { get; set; }
    public string Day5 { get; set; }
    public string Day6 { get; set; }
    public string Day7 { get; set; }
    public decimal? RoutingCovers { get; set; }
    public string DailyYn { get; set; }

    public virtual Promotions Promotions { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PromoCodeRoutInstr>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PROMO_CODE_ROUT_INSTR");

            entity.HasIndex(e => new { e.Resort, e.PromoCode, e.TrxCode, e.ArrangementId })
                .HasName("PCRI_UK")
                .IsUnique();

            entity.Property(e => e.ArrangementId)
                .HasColumnName("ARRANGEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AuthorizerId)
                .HasColumnName("AUTHORIZER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AutoPopulateRoutingYn)
                .HasColumnName("AUTO_POPULATE_ROUTING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DailyYn)
                .HasColumnName("DAILY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day1)
                .HasColumnName("DAY1")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day2)
                .HasColumnName("DAY2")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day3)
                .HasColumnName("DAY3")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day4)
                .HasColumnName("DAY4")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day5)
                .HasColumnName("DAY5")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day6)
                .HasColumnName("DAY6")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day7)
                .HasColumnName("DAY7")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PromoCode)
                .IsRequired()
                .HasColumnName("PROMO_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PromptForAuthorizerYn)
                .HasColumnName("PROMPT_FOR_AUTHORIZER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoutingCovers)
                .HasColumnName("ROUTING_COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoutingPercent)
                .HasColumnName("ROUTING_PERCENT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Promotions)))
				entity.Ignore(e => e.Promotions);
			else
	            entity.HasOne(d => d.Promotions)
	                .WithMany()
	                .HasPrincipalKey(p => new { p.Resort, p.PromoCode })
	                .HasForeignKey(d => new { d.Resort, d.PromoCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("PCRI_PROMO_FK");
        });
	}
}
