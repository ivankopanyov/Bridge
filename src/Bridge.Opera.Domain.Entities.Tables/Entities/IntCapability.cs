namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntCapability
{
    public string? InterfaceId { get; set; }
    public string? Resort { get; set; }
    public string? Functionality { get; set; }
    public string? EnabledYn { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntCapability>(entity =>
        {
            entity.HasKey(e => new { e.InterfaceId, e.Resort, e.Functionality })
                .HasName("INT_CAPABILITY_PK");

            entity.ToTable("INT_CAPABILITY");

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Functionality)
                .HasColumnName("FUNCTIONALITY")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EnabledYn)
                .IsRequired()
                .HasColumnName("ENABLED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
