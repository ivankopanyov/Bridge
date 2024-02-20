namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameHoldCommission
{
    public decimal? NameId { get; set; }
    public string? Resort { get; set; }
    public string? HoldCode { get; set; }
    public string? HoldDesc { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameHoldCommission>(entity =>
        {
            entity.HasKey(e => new { e.NameId, e.Resort })
                .HasName("NHC_PK");

            entity.ToTable("NAME_HOLD_COMMISSION");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HoldCode)
                .IsRequired()
                .HasColumnName("HOLD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HoldDesc)
                .HasColumnName("HOLD_DESC")
                .HasMaxLength(200)
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
