namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RmonResortGroupDtls
{
    public string SiteCode { get; set; }
    public string RemoteResortGroup { get; set; }
    public string RemoteResort { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RmonResortGroupDtls>(entity =>
        {
            entity.HasKey(e => new { e.SiteCode, e.RemoteResortGroup, e.RemoteResort })
                .HasName("RRL_PK");

            entity.ToTable("RMON_RESORT_GROUP_DTLS");

            entity.Property(e => e.SiteCode)
                .HasColumnName("SITE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RemoteResortGroup)
                .HasColumnName("REMOTE_RESORT_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RemoteResort)
                .HasColumnName("REMOTE_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
