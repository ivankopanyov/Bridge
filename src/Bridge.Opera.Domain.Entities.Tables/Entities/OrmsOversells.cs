namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsOversells
{
    public string Resort { get; set; }
    public DateTime OversellDate { get; set; }
    public decimal Oversell { get; set; }
    public decimal? OverrideOversell { get; set; }
    public decimal? OverrideBy { get; set; }
    public DateTime? OverrideDate { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public string ApprovedYn { get; set; }
    public decimal? ApprovedBy { get; set; }
    public DateTime? ApprovedDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsOversells>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.OversellDate })
                .HasName("ORMS_OVERSELLS_PK");

            entity.ToTable("ORMS_OVERSELLS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OversellDate)
                .HasColumnName("OVERSELL_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ApprovedBy)
                .HasColumnName("APPROVED_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ApprovedDate)
                .HasColumnName("APPROVED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ApprovedYn)
                .HasColumnName("APPROVED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpiryDate)
                .HasColumnName("EXPIRY_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OverrideBy)
                .HasColumnName("OVERRIDE_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OverrideDate)
                .HasColumnName("OVERRIDE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OverrideOversell)
                .HasColumnName("OVERRIDE_OVERSELL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Oversell)
                .HasColumnName("OVERSELL")
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
