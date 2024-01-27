namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortCutoffSchedule
{
    public string Resort { get; set; }
    public string Washcode { get; set; }
    public decimal CutoffDays { get; set; }
    public decimal? CutoffPerc { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public decimal? CutoffRooms1 { get; set; }
    public decimal? CutoffRooms2 { get; set; }
    public decimal? CutoffRooms3 { get; set; }
    public decimal? CutoffRooms4 { get; set; }
    public decimal? CutoffSellRooms { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortCutoffSchedule>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.Washcode, e.CutoffDays })
                .HasName("RCS_PK");

            entity.ToTable("RESORT_CUTOFF_SCHEDULE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Washcode)
                .HasColumnName("WASHCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CutoffDays)
                .HasColumnName("CUTOFF_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CutoffPerc)
                .HasColumnName("CUTOFF_PERC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CutoffRooms1)
                .HasColumnName("CUTOFF_ROOMS1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CutoffRooms2)
                .HasColumnName("CUTOFF_ROOMS2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CutoffRooms3)
                .HasColumnName("CUTOFF_ROOMS3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CutoffRooms4)
                .HasColumnName("CUTOFF_ROOMS4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CutoffSellRooms)
                .HasColumnName("CUTOFF_SELL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
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
