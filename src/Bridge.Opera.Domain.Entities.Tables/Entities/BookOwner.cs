namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BookOwner
{
    public string? Resort { get; set; }
    public decimal? BookId { get; set; }
    public string? UserResort { get; set; }
    public decimal? UserId { get; set; }
    public string? OwnerType { get; set; }
    public string? PrimaryYn { get; set; }
    public string? Relationship { get; set; }
    public string? ToType { get; set; }
    public string? Description { get; set; }
    public byte? LaptopChange { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? PrimarySfaYn { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }
    public virtual Name User { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BookOwner>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.BookId, e.UserResort, e.UserId, e.OwnerType })
                .HasName("BO_PK");

            entity.ToTable("BOOK$OWNER");

            entity.HasIndex(e => e.UserId)
                .HasName("BO_USERID_IDX");

            entity.HasIndex(e => new { e.BookId, e.Resort })
                .HasName("BO_BOOKID_IDX");

            entity.HasIndex(e => new { e.Resort, e.BookId, e.OwnerType })
                .HasName("BO_RES_BOOKID_OTYPE_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserResort)
                .HasColumnName("USER_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OwnerType)
                .HasColumnName("OWNER_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
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

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.PrimarySfaYn)
                .HasColumnName("PRIMARY_SFA_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

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

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.User);
			else
	            entity.HasOne(d => d.User)
	                .WithMany(p => p.BookOwner)
	                .HasForeignKey(d => d.UserId)
	                .HasConstraintName("BO_USERID_FK");

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany(p => p.BookOwner)
	                .HasForeignKey(d => new { d.BookId, d.Resort })
	                .HasConstraintName("BO_AH_FK");
        });
	}
}
