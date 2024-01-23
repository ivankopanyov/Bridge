namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ObiUserAccess
{
    public decimal AppUserId { get; set; }
    public string AccessLevel { get; set; }
    public string AccessCode { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiUserAccess>(entity =>
        {
            entity.HasKey(e => new { e.AppUserId, e.AccessLevel, e.AccessCode })
                .HasName("OBI_USER_ACCESS_PK");

            entity.ToTable("OBI_USER_ACCESS");

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccessLevel)
                .HasColumnName("ACCESS_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccessCode)
                .HasColumnName("ACCESS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");
        });
	}
}
