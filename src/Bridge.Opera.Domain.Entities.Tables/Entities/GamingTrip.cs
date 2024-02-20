namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GamingTrip
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? NameId { get; set; }
    public decimal? ActualTable { get; set; }
    public decimal? ActualSlot { get; set; }
    public decimal? ActualOther { get; set; }
    public decimal? Credit { get; set; }
    public string? SkillRating { get; set; }
    public string? PreferredGame { get; set; }
    public decimal? PlayerTable { get; set; }
    public decimal? PlayerSlot { get; set; }
    public decimal? PlayerOther { get; set; }
    public decimal? TheoreticalTable { get; set; }
    public decimal? TheoreticalSlot { get; set; }
    public decimal? TheoreticalOther { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GamingTrip>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.NameId })
                .HasName("GAME_PK");

            entity.ToTable("GAMING$_TRIP");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualOther)
                .HasColumnName("ACTUAL_OTHER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualSlot)
                .HasColumnName("ACTUAL_SLOT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualTable)
                .HasColumnName("ACTUAL_TABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Credit)
                .HasColumnName("CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PlayerOther)
                .HasColumnName("PLAYER_OTHER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PlayerSlot)
                .HasColumnName("PLAYER_SLOT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PlayerTable)
                .HasColumnName("PLAYER_TABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PreferredGame)
                .HasColumnName("PREFERRED_GAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SkillRating)
                .HasColumnName("SKILL_RATING")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TheoreticalOther)
                .HasColumnName("THEORETICAL_OTHER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TheoreticalSlot)
                .HasColumnName("THEORETICAL_SLOT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TheoreticalTable)
                .HasColumnName("THEORETICAL_TABLE")
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
