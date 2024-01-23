namespace Bridge.Opera.Domain.Entities.Tables;

public partial class QmsSections
{
    public string Resort { get; set; }
    public string DeptId { get; set; }
    public string SectionId { get; set; }
    public string SectionDesc { get; set; }
    public string LocCode { get; set; }
    public string LocType { get; set; }
    public decimal DeptGroupSeqNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QmsSections>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.DeptId, e.SectionId, e.LocCode, e.LocType })
                .HasName("QS_PK");

            entity.ToTable("QMS_SECTIONS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SectionId)
                .HasColumnName("SECTION_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LocCode)
                .HasColumnName("LOC_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LocType)
                .HasColumnName("LOC_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DeptGroupSeqNo)
                .HasColumnName("DEPT_GROUP_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SectionDesc)
                .IsRequired()
                .HasColumnName("SECTION_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
