namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OwsAdminToolLogin
{
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? AccessLevel { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OwsAdminToolLogin>(entity =>
        {
            entity.HasKey(e => e.Username)
                .HasName("OWS_ADMIN_TOOL_LOGIN_PK");

            entity.ToTable("OWS_ADMIN_TOOL_LOGIN");

            entity.Property(e => e.Username)
                .HasColumnName("USERNAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccessLevel)
                .HasColumnName("ACCESS_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Password)
                .IsRequired()
                .HasColumnName("PASSWORD")
                .HasMaxLength(20)
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
