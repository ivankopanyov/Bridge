namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExpDataHdrResort
{
    public decimal ExpDataId { get; set; }
    public string Resort { get; set; }
    public string Status { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ExpDataHdr ExpData { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpDataHdrResort>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("EXP_DATA_HDR_RESORT");

            entity.HasIndex(e => new { e.ExpDataId, e.Resort })
                .HasName("EXP_DATA_HDR_RESORT_UK")
                .IsUnique();

            entity.Property(e => e.ExpDataId)
                .HasColumnName("EXP_DATA_ID")
                .HasColumnType("NUMBER");

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
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ExpDataHdr)))
				entity.Ignore(e => e.ExpData);
			else
	            entity.HasOne(d => d.ExpData)
	                .WithMany()
	                .HasForeignKey(d => d.ExpDataId)
	                .HasConstraintName("EXP_DATA_HDR_RESORT_FK");
        });
	}
}
