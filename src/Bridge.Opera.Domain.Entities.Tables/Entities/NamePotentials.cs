namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NamePotentials
{
    public string? Resort { get; set; }
    public decimal? NameId { get; set; }
    public decimal? PotentialRoomRevenue { get; set; }
    public decimal? PotentialRoomNights { get; set; }
    public byte? LaptopChange { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NamePotentials>(entity =>
        {
            entity.HasKey(e => new { e.NameId, e.Resort })
                .HasName("NAME_POTENTIALS_PK");

            entity.ToTable("NAME_POTENTIALS");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.PotentialRoomNights)
                .HasColumnName("POTENTIAL_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PotentialRoomRevenue)
                .HasColumnName("POTENTIAL_ROOM_REVENUE")
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
