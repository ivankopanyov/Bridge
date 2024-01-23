namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ManualPostCovers
{
    public string Resort { get; set; }
    public string TrxCode { get; set; }
    public DateTime Dt { get; set; }
    public decimal Covers { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ManualPostCovers>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.TrxCode, e.Dt })
                .HasName("MANUAL_POST_COVERS_PK");

            entity.ToTable("MANUAL_POST_COVERS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Dt)
                .HasColumnName("DT")
                .HasColumnType("DATE");

            entity.Property(e => e.Covers)
                .HasColumnName("COVERS")
                .HasColumnType("NUMBER");

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
