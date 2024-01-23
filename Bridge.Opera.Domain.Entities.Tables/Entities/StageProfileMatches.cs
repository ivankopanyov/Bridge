namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfileMatches
{
    public string Resort { get; set; }
    public string ResortNameId { get; set; }
    public decimal NameId { get; set; }
    public string MatchDesc { get; set; }
    public decimal? MatchWeight { get; set; }
    public decimal? Sequence { get; set; }
    public decimal? ProcessTime { get; set; }

    public virtual StageProfiles ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileMatches>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResortNameId, e.NameId })
                .HasName("SPM_PK");

            entity.ToTable("STAGE_PROFILE_MATCHES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResortNameId)
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MatchDesc)
                .HasColumnName("MATCH_DESC")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MatchWeight)
                .HasColumnName("MATCH_WEIGHT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProcessTime)
                .HasColumnName("PROCESS_TIME")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Sequence)
                .HasColumnName("SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(StageProfiles)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.StageProfileMatches)
	                .HasForeignKey(d => new { d.Resort, d.ResortNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("STAGE_PROFILE_MATCHES_FK");
        });
	}
}
