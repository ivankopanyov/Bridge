namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BookProfileLink
{
    public string Resort { get; set; }
    public decimal BookId { get; set; }
    public decimal ProfileId { get; set; }
    public string PrimaryYn { get; set; }
    public decimal? LaptopChange { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }
    public virtual BusinessProfile Profile { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BookProfileLink>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.BookId, e.ProfileId })
                .HasName("BBBPL_PK");

            entity.ToTable("BOOK$PROFILE_LINK");

            entity.HasIndex(e => e.ProfileId)
                .HasName("BBBPL_BP_FK_IDX");

            entity.HasIndex(e => new { e.BookId, e.Resort })
                .HasName("BBBPL_AH_FK_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfileId)
                .HasColumnName("PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(BusinessProfile)))
				entity.Ignore(e => e.Profile);
			else
	            entity.HasOne(d => d.Profile)
	                .WithMany(p => p.BookProfileLink)
	                .HasForeignKey(d => d.ProfileId)
	                .HasConstraintName("BBBPL_BP_FK");

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany(p => p.BookProfileLink)
	                .HasForeignKey(d => new { d.BookId, d.Resort })
	                .HasConstraintName("BBBPL_AH_FK");
        });
	}
}
