namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BookingLink
{
    public string Resort { get; set; }
    public decimal BookingId { get; set; }
    public string LinkType { get; set; }
    public decimal LinkId { get; set; }
    public string PrimaryYn { get; set; }
    public string Relationship { get; set; }
    public string ToType { get; set; }
    public string Description { get; set; }
    public byte? LaptopChange { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string DefaultPrintYn { get; set; }
    public string ExternalYn { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BookingLink>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.BookingId, e.LinkType, e.LinkId })
                .HasName("BL_PK");

            entity.ToTable("BOOKING$LINK");

            entity.HasIndex(e => e.LinkId)
                .HasName("BL_NAME_FK_IDX");

            entity.HasIndex(e => new { e.BookingId, e.Resort })
                .HasName("BL_BOOKID_IDX");

            entity.HasIndex(e => new { e.InactiveDate, e.Resort })
                .HasName("BL_INACTIVE_DT_IDX");

            entity.HasIndex(e => new { e.InsertDate, e.Resort })
                .HasName("BL_INSERT_DT_IDX");

            entity.HasIndex(e => new { e.LinkType, e.LinkId })
                .HasName("BL_LINKTYPE_IDX");

            entity.HasIndex(e => new { e.UpdateDate, e.Resort })
                .HasName("BL_UPDATE_DT_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BookingId)
                .HasColumnName("BOOKING_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LinkType)
                .HasColumnName("LINK_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LinkId)
                .HasColumnName("LINK_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultPrintYn)
                .HasColumnName("DEFAULT_PRINT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ExternalYn)
                .HasColumnName("EXTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Relationship)
                .HasColumnName("RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToType)
                .HasColumnName("TO_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany(p => p.BookingLink)
	                .HasForeignKey(d => new { d.BookingId, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("BL_AH_FK");
        });
	}
}
