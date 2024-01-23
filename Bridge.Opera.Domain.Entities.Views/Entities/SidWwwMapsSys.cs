namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidWwwMapsSys
{
    public string SiteName { get; set; }
    public string SiteAddress { get; set; }
    public string DefaultFlg { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string CanDeleteYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidWwwMapsSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_WWW_MAPS_SYS");

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DefaultFlg)
                .HasColumnName("DEFAULT_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SiteAddress)
                .IsRequired()
                .HasColumnName("SITE_ADDRESS")
                .IsUnicode(false);

            entity.Property(e => e.SiteName)
                .IsRequired()
                .HasColumnName("SITE_NAME")
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
