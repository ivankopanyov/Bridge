namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class QmsSectionsView
{
    public string? Resort { get; set; }
    public string? DeptIds { get; set; }
    public string? SectionId { get; set; }
    public string? SectionDesc { get; set; }
    public string? LocCodes { get; set; }
    public decimal? DeptGroupSeqNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QmsSectionsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("QMS_SECTIONS_VIEW");

            entity.Property(e => e.DeptGroupSeqNo)
                .HasColumnName("DEPT_GROUP_SEQ_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeptIds)
                .HasColumnName("DEPT_IDS")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LocCodes)
                .HasColumnName("LOC_CODES")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SectionDesc)
                .IsRequired()
                .HasColumnName("SECTION_DESC")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SectionId)
                .IsRequired()
                .HasColumnName("SECTION_ID")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
