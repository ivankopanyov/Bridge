namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfileErrors
{
    public string? Resort { get; set; }
    public string? ResortNameId { get; set; }
    public string? ErrorField { get; set; }
    public string? ErrorValue { get; set; }
    public string? ErrorDesc { get; set; }

    public virtual StageProfiles ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileErrors>(entity =>
        {
            entity.HasKey(e => new { e.ErrorField, e.Resort, e.ResortNameId })
                .HasName("STAGE_PROF_ERRORS_PK");

            entity.ToTable("STAGE_PROFILE_ERRORS");

            entity.HasIndex(e => new { e.Resort, e.ResortNameId })
                .HasName("STAGE_PROFILE_ERRORS_IND");

            entity.Property(e => e.ErrorField)
                .HasColumnName("ERROR_FIELD")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ErrorDesc)
                .HasColumnName("ERROR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ErrorValue)
                .HasColumnName("ERROR_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

			if (!types.Contains(typeof(StageProfiles)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.StageProfileErrors)
	                .HasForeignKey(d => new { d.Resort, d.ResortNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("STAGE_PROF_ERRORS_FK");
        });
	}
}
