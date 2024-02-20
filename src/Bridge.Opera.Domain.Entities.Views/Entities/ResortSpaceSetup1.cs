namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ResortSpaceSetup1
{
    public decimal? SpaceInfoId { get; set; }
    public string? Resort { get; set; }
    public string? SetupStyle { get; set; }
    public decimal? SetupCapacity { get; set; }
    public string? SpaceType { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortSpaceSetup1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESORT_SPACE_SETUP");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SetupCapacity)
                .HasColumnName("SETUP_CAPACITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetupStyle)
                .IsRequired()
                .HasColumnName("SETUP_STYLE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SpaceInfoId)
                .HasColumnName("SPACE_INFO_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SpaceType)
                .HasColumnName("SPACE_TYPE")
                .HasMaxLength(40)
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
