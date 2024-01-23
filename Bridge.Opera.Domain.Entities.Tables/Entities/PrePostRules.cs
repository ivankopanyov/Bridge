namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PrePostRules
{
    public string Resort { get; set; }
    public string ResvQueueYn { get; set; }
    public string DaysPriorYn { get; set; }
    public decimal? DaysPrior { get; set; }
    public string PaymentTypePreYn { get; set; }
    public string ResvTypeYn { get; set; }
    public string CreditCardYn { get; set; }
    public string PaymentTypePostYn { get; set; }
    public string IfcPostYn { get; set; }
    public string OtherPostYn { get; set; }
    public string DefaultPreYn { get; set; }
    public string DefaultPostYn { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PrePostRules>(entity =>
        {
            entity.HasKey(e => e.Resort)
                .HasName("PRE_POST_RULES_PK");

            entity.ToTable("PRE_POST_RULES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardYn)
                .HasColumnName("CREDIT_CARD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DaysPrior)
                .HasColumnName("DAYS_PRIOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DaysPriorYn)
                .HasColumnName("DAYS_PRIOR_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DefaultPostYn)
                .HasColumnName("DEFAULT_POST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DefaultPreYn)
                .HasColumnName("DEFAULT_PRE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IfcPostYn)
                .HasColumnName("IFC_POST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherPostYn)
                .HasColumnName("OTHER_POST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PaymentTypePostYn)
                .HasColumnName("PAYMENT_TYPE_POST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PaymentTypePreYn)
                .HasColumnName("PAYMENT_TYPE_PRE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResvQueueYn)
                .HasColumnName("RESV_QUEUE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResvTypeYn)
                .HasColumnName("RESV_TYPE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
