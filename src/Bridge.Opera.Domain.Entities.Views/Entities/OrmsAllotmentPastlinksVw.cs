namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsAllotmentPastlinksVw
{
    public string? Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? BlockType { get; set; }
    public string? OrmsBlockClass { get; set; }
    public string? AllotmentCode { get; set; }
    public string? Description { get; set; }
    public decimal? LinkSequence { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsAllotmentPastlinksVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_ALLOTMENT_PASTLINKS_VW");

            entity.Property(e => e.AllotmentCode)
                .IsRequired()
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockType)
                .HasColumnName("BLOCK_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LinkSequence)
                .HasColumnName("LINK_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrmsBlockClass)
                .HasColumnName("ORMS_BLOCK_CLASS")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
