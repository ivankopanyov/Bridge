namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DatabaseWsSid
{
    public string? WsCode { get; set; }
    public string? WsName { get; set; }
    public string? WsDescription { get; set; }
    public string? WsEndpoint { get; set; }
    public string? WsFunction { get; set; }
    public string? WsNamespace { get; set; }
    public string? VersionClientList { get; set; }
    public string? CurrentClientVer { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DatabaseWsSid>(entity =>
        {
            entity.HasKey(e => e.WsCode)
                .HasName("DWD_PK");

            entity.ToTable("DATABASE_WS_SID");

            entity.Property(e => e.WsCode)
                .HasColumnName("WS_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CurrentClientVer)
                .HasColumnName("CURRENT_CLIENT_VER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VersionClientList)
                .HasColumnName("VERSION_CLIENT_LIST")
                .IsUnicode(false);

            entity.Property(e => e.WsDescription)
                .HasColumnName("WS_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.WsEndpoint)
                .HasColumnName("WS_ENDPOINT")
                .IsUnicode(false);

            entity.Property(e => e.WsFunction)
                .HasColumnName("WS_FUNCTION")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.WsName)
                .HasColumnName("WS_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.WsNamespace)
                .HasColumnName("WS_NAMESPACE")
                .HasMaxLength(400)
                .IsUnicode(false);
        });
	}
}
