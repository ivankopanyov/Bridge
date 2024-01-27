namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DestinationLevel
{
    public DestinationLevel()
    {
        Destination = new HashSet<Destination>();
    }

    public decimal LevelId { get; set; }
    public string LevelDesc { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? OrderBy { get; set; }
    public string ChainCode { get; set; }

    public virtual ICollection<Destination> Destination { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DestinationLevel>(entity =>
        {
            entity.HasKey(e => e.LevelId)
                .HasName("DL_PK");

            entity.ToTable("DESTINATION$LEVEL");

            entity.Property(e => e.LevelId)
                .HasColumnName("LEVEL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LevelDesc)
                .HasColumnName("LEVEL_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(Destination)))
				entity.Ignore(e => e.Destination);
		});
	}
}
