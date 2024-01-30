namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortSpaceSetup
{
    public string? Resort { get; set; }
    public string? SetupStyle { get; set; }
    public decimal? SetupCapacity { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? SpaceType { get; set; }
    public decimal? SpaceInfoId { get; set; }

    public virtual Resort ResortNavigation { get; set; }
    public virtual ResortSpaceInfo SpaceInfo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortSpaceSetup>(entity =>
        {
            entity.HasKey(e => new { e.SpaceInfoId, e.SetupStyle })
                .HasName("RSS_PK");

            entity.ToTable("RESORT$SPACE_SETUP");

            entity.HasIndex(e => e.Resort)
                .HasName("RSS_RESORT_FK_IDX");

            entity.HasIndex(e => e.SpaceInfoId)
                .HasName("RSS_RSI_FK_I");

            entity.Property(e => e.SpaceInfoId)
                .HasColumnName("SPACE_INFO_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetupStyle)
                .HasColumnName("SETUP_STYLE")
                .HasMaxLength(20)
                .IsUnicode(false);

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

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.ResortSpaceSetup)
	                .HasForeignKey(d => d.Resort)
	                .HasConstraintName("RSS_RESORT_FK");

			if (!types.Contains(typeof(ResortSpaceInfo)))
				entity.Ignore(e => e.SpaceInfo);
			else
	            entity.HasOne(d => d.SpaceInfo)
	                .WithMany(p => p.ResortSpaceSetup)
	                .HasForeignKey(d => d.SpaceInfoId)
	                .HasConstraintName("RSS_RSI_FK");
        });
	}
}
