namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OsgLatest
{
    public string Resort { get; set; }
    public string DocumentType { get; set; }
    public string Last { get; set; }
    public string LastKv { get; set; }
    public DateTime InsertTs { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime? UpdateTs { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? LastBusinessDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OsgLatest>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.DocumentType })
                .HasName("OSG_LATEST_PK");

            entity.ToTable("OSG_LATEST");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DocumentType)
                .HasColumnName("DOCUMENT_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertTs)
                .HasColumnName("INSERT_TS")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Last)
                .HasColumnName("LAST")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LastBusinessDate)
                .HasColumnName("LAST_BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastKv)
                .HasColumnName("LAST_KV")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateTs)
                .HasColumnName("UPDATE_TS")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
