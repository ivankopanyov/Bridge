namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScPkgEvent
{
    public ScPkgEvent()
    {
        ScPkgItem = new HashSet<ScPkgItem>();
        ScPkgMenu = new HashSet<ScPkgMenu>();
    }

    public decimal? PkgEvId { get; set; }
    public string? MasterPkgEvId { get; set; }
    public decimal? PkgLink { get; set; }
    public decimal? DayOrder { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? EvType { get; set; }
    public string? EvName { get; set; }
    public string? Resort { get; set; }
    public string? Room { get; set; }
    public string? RoomSetup { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? RoomRate { get; set; }
    public string? MasterYn { get; set; }
    public string? ShareableYn { get; set; }

    public virtual ScPackage PkgLinkNavigation { get; set; }
    public virtual ICollection<ScPkgItem> ScPkgItem { get; set; }
    public virtual ICollection<ScPkgMenu> ScPkgMenu { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScPkgEvent>(entity =>
        {
            entity.HasKey(e => e.PkgEvId)
                .HasName("PKGEV_PK");

            entity.ToTable("SC$PKG_EVENT");

            entity.HasIndex(e => e.PkgLink)
                .HasName("PKGEV_PKG_IDX");

            entity.HasIndex(e => new { e.Resort, e.PkgLink, e.PkgEvId })
                .HasName("PKGEV_UK")
                .IsUnique();

            entity.Property(e => e.PkgEvId)
                .HasColumnName("PKG_EV_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayOrder)
                .HasColumnName("DAY_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EvName)
                .IsRequired()
                .HasColumnName("EV_NAME")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.EvType)
                .IsRequired()
                .HasColumnName("EV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterPkgEvId)
                .HasColumnName("MASTER_PKG_EV_ID")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.MasterYn)
                .HasColumnName("MASTER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PkgLink)
                .HasColumnName("PKG_LINK")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRate)
                .HasColumnName("ROOM_RATE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomSetup)
                .HasColumnName("ROOM_SETUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShareableYn)
                .HasColumnName("SHAREABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ScPackage)))
				entity.Ignore(e => e.PkgLinkNavigation);
			else
	            entity.HasOne(d => d.PkgLinkNavigation)
	                .WithMany(p => p.ScPkgEvent)
	                .HasForeignKey(d => d.PkgLink)
	                .HasConstraintName("PKGEV_PKG_FK");
        
			if (!types.Contains(typeof(ScPkgItem)))
				entity.Ignore(e => e.ScPkgItem);

			if (!types.Contains(typeof(ScPkgMenu)))
				entity.Ignore(e => e.ScPkgMenu);
		});
	}
}
