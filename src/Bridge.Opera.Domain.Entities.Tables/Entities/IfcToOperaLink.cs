namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcToOperaLink
{
    public string? IfcType { get; set; }
    public string? DbLinkName { get; set; }
    public string? Alias { get; set; }
    public string? UserId { get; set; }
    public string? Password { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? HostName { get; set; }
    public string? InstanceName { get; set; }
    public decimal? Port { get; set; }
    public string? Comments { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcToOperaLink>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("IFC_TO_OPERA_LINK");

            entity.Property(e => e.Alias)
                .HasColumnName("ALIAS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DbLinkName)
                .HasColumnName("DB_LINK_NAME")
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.Property(e => e.HostName)
                .HasColumnName("HOST_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.IfcType)
                .IsRequired()
                .HasColumnName("IFC_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InstanceName)
                .HasColumnName("INSTANCE_NAME")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Password)
                .HasColumnName("PASSWORD")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Port)
                .HasColumnName("PORT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
