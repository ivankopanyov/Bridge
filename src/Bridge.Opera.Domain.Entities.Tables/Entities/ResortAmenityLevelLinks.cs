namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortAmenityLevelLinks
{
    public string? Resort { get; set; }
    public string? AmenityCode { get; set; }
    public decimal? AmenitySeqId { get; set; }
    public string? AmenityLevelCode { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual Preferences AmenitySeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortAmenityLevelLinks>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.AmenityCode, e.AmenityLevelCode })
                .HasName("RESORT_AMENITY_LEVEL_LINKS_PK");

            entity.ToTable("RESORT_AMENITY_LEVEL_LINKS");

            entity.HasIndex(e => e.AmenitySeqId)
                .HasName("RES_AMENITY_PREF_FKI");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AmenityCode)
                .HasColumnName("AMENITY_CODE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AmenityLevelCode)
                .HasColumnName("AMENITY_LEVEL_CODE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AmenitySeqId)
                .HasColumnName("AMENITY_SEQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Preferences)))
				entity.Ignore(e => e.AmenitySeq);
			else
	            entity.HasOne(d => d.AmenitySeq)
	                .WithMany(p => p.ResortAmenityLevelLinks)
	                .HasPrincipalKey(p => p.PreferenceSeqId)
	                .HasForeignKey(d => d.AmenitySeqId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RES_AMENITY_PREF_FK");
        });
	}
}
