namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BonusCheck
{
    public decimal? BonusCheckId { get; set; }
    public string? BonusCheckType { get; set; }
    public string? BonusCheckNumber { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BonusCheck>(entity =>
        {
            entity.ToTable("BONUS_CHECK");

            entity.HasIndex(e => e.BonusCheckNumber)
                .HasName("BONUS_CHECK_NUMBER_IDX")
                .IsUnique();

            entity.Property(e => e.BonusCheckId)
                .HasColumnName("BONUS_CHECK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BonusCheckNumber)
                .IsRequired()
                .HasColumnName("BONUS_CHECK_NUMBER")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BonusCheckType)
                .IsRequired()
                .HasColumnName("BONUS_CHECK_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

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
