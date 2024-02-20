namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class Destination1
{
    public decimal? DestinationId { get; set; }
    public decimal? MasterDestinationId { get; set; }
    public decimal? LevelId { get; set; }
    public string? DestinationDesc { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Destination1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DESTINATION");

            entity.Property(e => e.DestinationDesc)
                .HasColumnName("DESTINATION_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DestinationId)
                .HasColumnName("DESTINATION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LevelId)
                .HasColumnName("LEVEL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterDestinationId)
                .HasColumnName("MASTER_DESTINATION_ID")
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
