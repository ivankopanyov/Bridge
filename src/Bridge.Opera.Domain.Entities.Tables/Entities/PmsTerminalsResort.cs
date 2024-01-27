namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PmsTerminalsResort
{
    public string Resort { get; set; }
    public string StationId { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PmsTerminalsResort>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.StationId })
                .HasName("PMS_TERMINALS_RESORT_PK");

            entity.ToTable("PMS_TERMINALS_RESORT");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StationId)
                .HasColumnName("STATION_ID")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
