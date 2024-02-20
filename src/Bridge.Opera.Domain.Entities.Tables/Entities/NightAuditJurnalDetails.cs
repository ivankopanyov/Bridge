namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NightAuditJurnalDetails
{
    public decimal? SysJobId { get; set; }
    public string? Remarks { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NightAuditJurnalDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("NIGHT_AUDIT_JURNAL_DETAILS");

            entity.Property(e => e.Remarks)
                .HasColumnName("REMARKS")
                .IsUnicode(false);

            entity.Property(e => e.SysJobId)
                .HasColumnName("SYS_JOB_ID")
                .HasColumnType("NUMBER");
        });
	}
}
