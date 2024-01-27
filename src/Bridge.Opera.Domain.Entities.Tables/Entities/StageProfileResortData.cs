namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfileResortData
{
    public string Resort { get; set; }
    public string ResortNameId { get; set; }
    public string ExtResortCode { get; set; }
    public string OperaResortCode { get; set; }
    public string ScAttachments { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileResortData>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResortNameId, e.ExtResortCode })
                .HasName("SPA_PK");

            entity.ToTable("STAGE_PROFILE_RESORT_DATA");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExtResortCode)
                .HasColumnName("EXT_RESORT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OperaResortCode)
                .HasColumnName("OPERA_RESORT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ScAttachments)
                .HasColumnName("SC_ATTACHMENTS")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
