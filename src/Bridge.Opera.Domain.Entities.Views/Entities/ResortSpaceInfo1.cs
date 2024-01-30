namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ResortSpaceInfo1
{
    public decimal? SpaceInfoId { get; set; }
    public string? Resort { get; set; }
    public decimal? SpaceAmount { get; set; }
    public string? SpaceType { get; set; }
    public decimal? MaxOccupancy { get; set; }
    public decimal? AreaM { get; set; }
    public decimal? AreaF { get; set; }
    public decimal? HeightmaxM { get; set; }
    public decimal? HeightmaxF { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortSpaceInfo1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESORT_SPACE_INFO");

            entity.Property(e => e.AreaF)
                .HasColumnName("AREA_F")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AreaM)
                .HasColumnName("AREA_M")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HeightmaxF)
                .HasColumnName("HEIGHTMAX_F")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HeightmaxM)
                .HasColumnName("HEIGHTMAX_M")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxOccupancy)
                .HasColumnName("MAX_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SpaceAmount)
                .HasColumnName("SPACE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SpaceInfoId)
                .HasColumnName("SPACE_INFO_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SpaceType)
                .IsRequired()
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
