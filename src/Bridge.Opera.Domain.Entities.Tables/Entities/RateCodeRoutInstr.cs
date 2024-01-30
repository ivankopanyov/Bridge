namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateCodeRoutInstr
{
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public string? TrxCode { get; set; }
    public string? ProfileType { get; set; }
    public decimal? ArrangementId { get; set; }
    public DateTime? InactiveDate { get; set; }

    public virtual RateHeader R { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateCodeRoutInstr>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RateCode, e.TrxCode, e.ProfileType })
                .HasName("RCRI_PK");

            entity.ToTable("RATE$CODE_ROUT_INSTR");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProfileType)
                .HasColumnName("PROFILE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArrangementId)
                .HasColumnName("ARRANGEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

			if (!types.Contains(typeof(RateHeader)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.RateCodeRoutInstr)
	                .HasForeignKey(d => new { d.Resort, d.RateCode })
	                .HasConstraintName("RATE_CODE_ROUT_INSTR_FK");
        });
	}
}
