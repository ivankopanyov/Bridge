namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortOriginsOfBooking
{
    public ResortOriginsOfBooking()
    {
        RateHeader = new HashSet<RateHeader>();
        RateSet = new HashSet<RateSet>();
    }

    public string Resort { get; set; }
    public string SourceCode { get; set; }
    public string ParentSourceCode { get; set; }
    public string Description { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? SellSequence { get; set; }
    public decimal? ScOrderby { get; set; }

    public virtual ICollection<RateHeader> RateHeader { get; set; }
    public virtual ICollection<RateSet> RateSet { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortOriginsOfBooking>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.SourceCode })
                .HasName("SOURCES_PK");

            entity.ToTable("RESORT_ORIGINS_OF_BOOKING");

            entity.HasIndex(e => new { e.SourceCode, e.Resort })
                .HasName("SOURCE_RESORT_IDX")
                .IsUnique();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
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

            entity.Property(e => e.ParentSourceCode)
                .HasColumnName("PARENT_SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ScOrderby)
                .HasColumnName("SC_ORDERBY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SellSequence)
                .HasColumnName("SELL_SEQUENCE")
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
        
			if (!types.Contains(typeof(RateHeader)))
				entity.Ignore(e => e.RateHeader);

			if (!types.Contains(typeof(RateSet)))
				entity.Ignore(e => e.RateSet);
		});
	}
}
