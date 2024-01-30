namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsAccessCodes
{
    public decimal? NameId { get; set; }
    public string? Channel { get; set; }
    public string? RateCode { get; set; }
    public string? AccessCode { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? RealAccessCode { get; set; }
    public string? Resorts { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsAccessCodes>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GDS_ACCESS_CODES");

            entity.HasIndex(e => new { e.NameId, e.Channel, e.RateCode, e.AccessCode, e.RealAccessCode })
                .HasName("GAE_UK")
                .IsUnique();

            entity.Property(e => e.AccessCode)
                .HasColumnName("ACCESS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Channel)
                .IsRequired()
                .HasColumnName("CHANNEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RealAccessCode)
                .HasColumnName("REAL_ACCESS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resorts)
                .HasColumnName("RESORTS")
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
