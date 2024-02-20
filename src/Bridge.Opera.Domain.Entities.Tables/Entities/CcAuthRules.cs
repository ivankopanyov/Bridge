namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CcAuthRules
{
    public string? Resort { get; set; }
    public string? GuaranteeCode { get; set; }
    public string? SourceCode { get; set; }
    public decimal? ApprovalAmountCalcMethod { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Percentage { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomClass { get; set; }
    public string? RateCode { get; set; }
    public string? RateCategory { get; set; }

    public virtual ResortRateCategory R { get; set; }
    public virtual ResortRoomCategory R1 { get; set; }
    public virtual ResortRoomClasses R2 { get; set; }
    public virtual RateHeader RNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CcAuthRules>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CC_AUTH_RULES");

            entity.HasIndex(e => new { e.Resort, e.RateCategory })
                .HasName("CC_AUTH_RATECAT_FKI");

            entity.HasIndex(e => new { e.Resort, e.RateCode })
                .HasName("CC_AUTH_RATECODE_FKI");

            entity.HasIndex(e => new { e.Resort, e.RoomCategory })
                .HasName("CC_AUTH_ROOMCAT_FKI");

            entity.HasIndex(e => new { e.Resort, e.RoomClass })
                .HasName("CC_AUTH_ROOMCLASS_FKI");

            entity.HasIndex(e => new { e.Resort, e.RoomCategory, e.RoomClass, e.RateCode, e.RateCategory, e.GuaranteeCode, e.SourceCode })
                .HasName("CC_AUTH_RULES_UK")
                .IsUnique();

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ApprovalAmountCalcMethod)
                .HasColumnName("APPROVAL_AMOUNT_CALC_METHOD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Percentage)
                .HasColumnName("PERCENTAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(ResortRateCategory)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.RateCategory })
	                .OnDelete(DeleteBehavior.Cascade)
	                .HasConstraintName("CC_AUTH_RATECAT_FK");

			if (!types.Contains(typeof(RateHeader)))
				entity.Ignore(e => e.RNavigation);
			else
	            entity.HasOne(d => d.RNavigation)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.RateCode })
	                .OnDelete(DeleteBehavior.Cascade)
	                .HasConstraintName("CC_AUTH_RATECODE_FK");

			if (!types.Contains(typeof(ResortRoomCategory)))
				entity.Ignore(e => e.R1);
			else
	            entity.HasOne(d => d.R1)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.RoomCategory })
	                .OnDelete(DeleteBehavior.Cascade)
	                .HasConstraintName("CC_AUTH_ROOMCAT_FK");

			if (!types.Contains(typeof(ResortRoomClasses)))
				entity.Ignore(e => e.R2);
			else
	            entity.HasOne(d => d.R2)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.RoomClass })
	                .OnDelete(DeleteBehavior.Cascade)
	                .HasConstraintName("CC_AUTH_ROOMCLASS_FK");
        });
	}
}
