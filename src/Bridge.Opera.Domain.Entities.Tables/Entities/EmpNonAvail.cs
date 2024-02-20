namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EmpNonAvail
{
    public decimal? NameId { get; set; }
    public string? Resort { get; set; }
    public DateTime? AbsentFrom { get; set; }
    public DateTime? ReturnOn { get; set; }
    public string? ReasonCode { get; set; }
    public string? Comments { get; set; }

    public virtual Reasons Re { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EmpNonAvail>(entity =>
        {
            entity.HasKey(e => new { e.AbsentFrom, e.Resort, e.NameId })
                .HasName("EMP_NON_AVAIL_PK");

            entity.ToTable("EMP_NON_AVAIL");

            entity.HasIndex(e => new { e.Resort, e.ReasonCode })
                .HasName("EMP_NON_AVAIL_REASON_FK_IDX");

            entity.Property(e => e.AbsentFrom)
                .HasColumnName("ABSENT_FROM")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ReasonCode)
                .IsRequired()
                .HasColumnName("REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReturnOn)
                .HasColumnName("RETURN_ON")
                .HasColumnType("DATE");

			if (!types.Contains(typeof(Reasons)))
				entity.Ignore(e => e.Re);
			else
	            entity.HasOne(d => d.Re)
	                .WithMany(p => p.EmpNonAvail)
	                .HasForeignKey(d => new { d.Resort, d.ReasonCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("EMP_NON_AVAIL_REASON_FK");
        });
	}
}
