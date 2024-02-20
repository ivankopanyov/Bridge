namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExtnNumberSetup
{
    public string? Resort { get; set; }
    public string? ExtnNumber { get; set; }
    public string? ExtnType { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExtnNumberSetup>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("EXTN_NUMBER_SETUP");

            entity.HasIndex(e => new { e.Resort, e.ExtnNumber, e.ExtnType })
                .HasName("EXTN_NUMBER_UK")
                .IsUnique();

            entity.Property(e => e.ExtnNumber)
                .IsRequired()
                .HasColumnName("EXTN_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExtnType)
                .HasColumnName("EXTN_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
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
