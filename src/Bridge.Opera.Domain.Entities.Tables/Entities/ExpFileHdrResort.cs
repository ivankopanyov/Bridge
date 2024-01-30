namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExpFileHdrResort
{
    public decimal? ExpFileId { get; set; }
    public string? Resort { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ExpFileHdr ExpFile { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpFileHdrResort>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("EXP_FILE_HDR_RESORT");

            entity.HasIndex(e => new { e.ExpFileId, e.Resort })
                .HasName("EXP_FILE_HDR_RESORT_UK")
                .IsUnique();

            entity.Property(e => e.ExpFileId)
                .HasColumnName("EXP_FILE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ExpFileHdr)))
				entity.Ignore(e => e.ExpFile);
			else
	            entity.HasOne(d => d.ExpFile)
	                .WithMany()
	                .HasForeignKey(d => d.ExpFileId)
	                .HasConstraintName("EXP_FILE_HDR_RESORT_FK");
        });
	}
}
