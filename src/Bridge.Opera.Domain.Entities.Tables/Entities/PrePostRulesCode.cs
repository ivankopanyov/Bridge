namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PrePostRulesCode
{
    public string Resort { get; set; }
    public string PreYn { get; set; }
    public string PostYn { get; set; }
    public string PaymentType { get; set; }
    public string ReservationType { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PrePostRulesCode>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.PreYn, e.PostYn, e.PaymentType, e.ReservationType })
                .HasName("PRE_POST_RULE_CODES_PK");

            entity.ToTable("PRE_POST_RULES_CODE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PreYn)
                .HasColumnName("PRE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PostYn)
                .HasColumnName("POST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PaymentType)
                .HasColumnName("PAYMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReservationType)
                .HasColumnName("RESERVATION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
