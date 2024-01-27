namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortCommissionDetailRes
{
    public string Resort { get; set; }
    public string CommissionCode { get; set; }
    public string PerNight { get; set; }
    public string PerStay { get; set; }
    public decimal? Amount { get; set; }
    public decimal? WkndAmt { get; set; }
    public string CommFlatPercentage { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

    public virtual ResortCommission ResortCommission { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortCommissionDetailRes>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.CommissionCode })
                .HasName("RESORT_COMM_DETAIL_RES_PK");

            entity.ToTable("RESORT_COMMISSION_DETAIL_RES");

            entity.HasIndex(e => new { e.CommissionCode, e.Resort })
                .HasName("RC_RESORT_COMMISSION_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CommissionCode)
                .HasColumnName("COMMISSION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommFlatPercentage)
                .HasColumnName("COMM_FLAT_PERCENTAGE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PerNight)
                .HasColumnName("PER_NIGHT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PerStay)
                .HasColumnName("PER_STAY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WkndAmt)
                .HasColumnName("WKND_AMT")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ResortCommission)))
				entity.Ignore(e => e.ResortCommission);
			else
	            entity.HasOne(d => d.ResortCommission)
	                .WithMany(p => p.ResortCommissionDetailRes)
	                .HasForeignKey(d => new { d.CommissionCode, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RC_RESORT_COMMISSION_FK");
        });
	}
}
