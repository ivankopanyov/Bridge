namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OcrmProfileLink
{
    public decimal? OcrmProfileId { get; set; }
    public decimal? NameId { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? DefaultYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OcrmProfileLink>(entity =>
        {
            entity.HasKey(e => e.OcrmProfileId)
                .HasName("OCRMPR_PK");

            entity.ToTable("OCRM_PROFILE_LINK");

            entity.HasIndex(e => new { e.NameId, e.DefaultYn })
                .HasName("OCRM_PROF_LNK_IDX01");

            entity.Property(e => e.OcrmProfileId)
                .HasColumnName("OCRM_PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
