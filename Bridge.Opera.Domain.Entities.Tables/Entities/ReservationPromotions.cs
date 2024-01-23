namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationPromotions
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public string PromoCode { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }

    public virtual Promotions Promotions { get; set; }
    public virtual ReservationName Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationPromotions>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.PromoCode })
                .HasName("RESERVATION_PROMOTIONS_PK");

            entity.ToTable("RESERVATION_PROMOTIONS");

            entity.HasIndex(e => new { e.Resort, e.PromoCode })
                .HasName("RESERVATION_PROMOTIONS_FK1_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PromoCode)
                .HasColumnName("PROMO_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Promotions)))
				entity.Ignore(e => e.Promotions);
			else
	            entity.HasOne(d => d.Promotions)
	                .WithMany(p => p.ReservationPromotions)
	                .HasPrincipalKey(p => new { p.Resort, p.PromoCode })
	                .HasForeignKey(d => new { d.Resort, d.PromoCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESERVATION_PROMOTIONS_FK1");

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.ReservationPromotions)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESERVATION_PROMOTIONS_FK2");
        });
	}
}
