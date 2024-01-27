namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExportBucketTypes
{
    public ExportBucketTypes()
    {
        TrxCodeArrangement = new HashSet<TrxCodeArrangement>();
    }

    public string Resort { get; set; }
    public string ExportBucketType { get; set; }
    public string Description { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string CompYn { get; set; }

    public virtual ICollection<TrxCodeArrangement> TrxCodeArrangement { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExportBucketTypes>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("EXPORT_BUCKET_TYPES");

            entity.HasIndex(e => new { e.Resort, e.ExportBucketType })
                .HasName("EBT_UK")
                .IsUnique();

            entity.Property(e => e.CompYn)
                .HasColumnName("COMP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ExportBucketType)
                .IsRequired()
                .HasColumnName("EXPORT_BUCKET_TYPE")
                .HasMaxLength(100)
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
        
			if (!types.Contains(typeof(TrxCodeArrangement)))
				entity.Ignore(e => e.TrxCodeArrangement);
		});
	}
}
