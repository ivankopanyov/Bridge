namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfileUdfs
{
    public string? Resort { get; set; }
    public string? UdfType { get; set; }
    public string? ResortNameId { get; set; }
    public string? UdfAttribute { get; set; }
    public string? PmsTableName { get; set; }
    public string? ValidYn { get; set; }
    public string? ErrorDesc { get; set; }

    public virtual StageProfiles ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileUdfs>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResortNameId, e.UdfType })
                .HasName("STAGE_PROFILE_UDF_PK");

            entity.ToTable("STAGE_PROFILE_UDFS");

            entity.HasIndex(e => new { e.ResortNameId, e.Resort, e.UdfType })
                .HasName("STAGE_PROF_UDF_PK")
                .IsUnique();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UdfType)
                .HasColumnName("UDF_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ErrorDesc)
                .HasColumnName("ERROR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PmsTableName)
                .HasColumnName("PMS_TABLE_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UdfAttribute)
                .IsRequired()
                .HasColumnName("UDF_ATTRIBUTE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ValidYn)
                .HasColumnName("VALID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

			if (!types.Contains(typeof(StageProfiles)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.StageProfileUdfs)
	                .HasForeignKey(d => new { d.Resort, d.ResortNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("SPU_STAGE_PROFILES_FK");
        });
	}
}
