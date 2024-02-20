namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortCreditCard
{
    public string? Resort { get; set; }
    public string? CardType { get; set; }
    public byte? MinimumClosingProbability { get; set; }
    public string? MerchantNumber { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }

    public virtual CreditCard CreditCard { get; set; }
    public virtual Resort ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortCreditCard>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.CardType })
                .HasName("RESORT_CREDIT_CARD_PK");

            entity.ToTable("RESORT_CREDIT_CARD");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CardType)
                .HasColumnName("CARD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MerchantNumber)
                .HasColumnName("MERCHANT_NUMBER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MinimumClosingProbability).HasColumnName("MINIMUM_CLOSING_PROBABILITY");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.ResortCreditCard)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESORT_FK15");

			if (!types.Contains(typeof(CreditCard)))
				entity.Ignore(e => e.CreditCard);
			else
	            entity.HasOne(d => d.CreditCard)
	                .WithMany(p => p.ResortCreditCard)
	                .HasForeignKey(d => new { d.CardType, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("CARD_TYPE_FK2");
        });
	}
}
