namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EmpWorkCategories
{
    public decimal? EmpId { get; set; }
    public string? Resort { get; set; }
    public string? WcCode { get; set; }

    public virtual WorkCategories WorkCategories { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EmpWorkCategories>(entity =>
        {
            entity.HasKey(e => new { e.WcCode, e.Resort, e.EmpId })
                .HasName("EW_PK");

            entity.ToTable("EMP_WORK_CATEGORIES");

            entity.HasIndex(e => new { e.EmpId, e.Resort })
                .HasName("EMP_WC_I");

            entity.HasIndex(e => new { e.Resort, e.WcCode })
                .HasName("EW_WC_FK_IDX");

            entity.Property(e => e.WcCode)
                .HasColumnName("WC_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EmpId)
                .HasColumnName("EMP_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(WorkCategories)))
				entity.Ignore(e => e.WorkCategories);
			else
	            entity.HasOne(d => d.WorkCategories)
	                .WithMany(p => p.EmpWorkCategories)
	                .HasForeignKey(d => new { d.Resort, d.WcCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("EW_WC_FK");
        });
	}
}
