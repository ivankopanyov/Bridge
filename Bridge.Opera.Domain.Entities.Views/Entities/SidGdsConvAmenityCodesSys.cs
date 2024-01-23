namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidGdsConvAmenityCodesSys
{
    public string GdsHost { get; set; }
    public string AmenityCode { get; set; }
    public string FeatureType { get; set; }
    public string Feature { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidGdsConvAmenityCodesSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_GDS_CONV_AMENITY_CODES_SYS");

            entity.Property(e => e.AmenityCode)
                .IsRequired()
                .HasColumnName("AMENITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Feature)
                .IsRequired()
                .HasColumnName("FEATURE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FeatureType)
                .IsRequired()
                .HasColumnName("FEATURE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GdsHost)
                .IsRequired()
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
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
