namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProfileStageUserStats
{
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string? Action { get; set; }
    public string? Resort { get; set; }
    public string? NameType { get; set; }
    public decimal? OrsNameId { get; set; }
    public string? PmsNameId { get; set; }
    public string? OrsName { get; set; }
    public string? OrsFirst { get; set; }
    public string? PmsName { get; set; }
    public string? PmsFirst { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileStageUserStats>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PROFILE_STAGE_USER_STATS");

            entity.HasIndex(e => e.InsertDate)
                .HasName("PROF_STAGE_USER_STATS_IND2");

            entity.HasIndex(e => e.InsertUser)
                .HasName("PROF_STAGE_USER_STATS_IND1");

            entity.Property(e => e.Action)
                .HasColumnName("ACTION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrsFirst)
                .HasColumnName("ORS_FIRST")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.OrsName)
                .HasColumnName("ORS_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.OrsNameId)
                .HasColumnName("ORS_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsFirst)
                .HasColumnName("PMS_FIRST")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PmsName)
                .HasColumnName("PMS_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PmsNameId)
                .HasColumnName("PMS_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
