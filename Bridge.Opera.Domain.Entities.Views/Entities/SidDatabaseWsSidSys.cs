namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidDatabaseWsSidSys
{
    public string WsCode { get; set; }
    public string WsName { get; set; }
    public string WsDescription { get; set; }
    public string WsEndpoint { get; set; }
    public string WsFunction { get; set; }
    public string WsNamespace { get; set; }
    public string VersionClientList { get; set; }
    public string CurrentClientVer { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidDatabaseWsSidSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_DATABASE_WS_SID_SYS");

            entity.Property(e => e.CurrentClientVer)
                .HasColumnName("CURRENT_CLIENT_VER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VersionClientList)
                .HasColumnName("VERSION_CLIENT_LIST")
                .IsUnicode(false);

            entity.Property(e => e.WsCode)
                .IsRequired()
                .HasColumnName("WS_CODE")
                .HasMaxLength(40)
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
