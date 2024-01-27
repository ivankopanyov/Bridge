namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipPaymentTypes
{
    public string Resort { get; set; }
    public string MembershipType { get; set; }
    public string PaymentType { get; set; }
    public string CalcPoints { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual CreditCard CreditCard { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipPaymentTypes>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.MembershipType, e.PaymentType })
                .HasName("MEM_PAY_PK");

            entity.ToTable("MEMBERSHIP_PAYMENT_TYPES");

            entity.HasIndex(e => new { e.PaymentType, e.Resort })
                .HasName("MEM_TYPE_FKI");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaymentType)
                .HasColumnName("PAYMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CalcPoints)
                .HasColumnName("CALC_POINTS")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

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

			if (!types.Contains(typeof(CreditCard)))
				entity.Ignore(e => e.CreditCard);
			else
	            entity.HasOne(d => d.CreditCard)
	                .WithMany(p => p.MembershipPaymentTypes)
	                .HasForeignKey(d => new { d.PaymentType, d.Resort })
	                .HasConstraintName("MEM_TYPE_FK");
        });
	}
}
