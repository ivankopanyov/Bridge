namespace Bridge.Opera.Domain.Entities.Tables;

public partial class UserResortAccess
{
    public decimal AppUserId { get; set; }
    public string Resort { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? AppUserIdOrigin { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UserResortAccess>(entity =>
        {
            entity.HasKey(e => new { e.AppUserId, e.Resort })
                .HasName("USER_RESORT_ACCESS_PK");

            entity.ToTable("USER_RESORT_ACCESS");

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AppUserIdOrigin)
                .HasColumnName("APP_USER_ID_ORIGIN")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");
        });
	}
}
