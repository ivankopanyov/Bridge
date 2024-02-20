namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Destination
{
    public decimal? DestinationId { get; set; }
    public decimal? MasterDestinationId { get; set; }
    public decimal? LevelId { get; set; }
    public string? DestinationDesc { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? ChainCode { get; set; }

    public virtual DestinationLevel Level { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Destination>(entity =>
        {
            entity.ToTable("DESTINATION$");

            entity.HasIndex(e => e.LevelId)
                .HasName("DE_DL_FK_IDX");

            entity.Property(e => e.DestinationId)
                .HasColumnName("DESTINATION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DestinationDesc)
                .HasColumnName("DESTINATION_DESC")
                .HasMaxLength(100)
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

            entity.Property(e => e.LevelId)
                .HasColumnName("LEVEL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterDestinationId)
                .HasColumnName("MASTER_DESTINATION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(DestinationLevel)))
				entity.Ignore(e => e.Level);
			else
	            entity.HasOne(d => d.Level)
	                .WithMany(p => p.Destination)
	                .HasForeignKey(d => d.LevelId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("DE_DL_FK");
        });
	}
}
