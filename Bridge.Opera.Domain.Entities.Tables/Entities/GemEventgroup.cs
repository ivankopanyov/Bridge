namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemEventgroup
{
    public GemEventgroup()
    {
        GemEvent = new HashSet<GemEvent>();
    }

    public decimal GroupId { get; set; }
    public decimal BookId { get; set; }
    public string Description { get; set; }
    public string Resort { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }
    public virtual ICollection<GemEvent> GemEvent { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemEventgroup>(entity =>
        {
            entity.HasKey(e => e.GroupId)
                .HasName("EG_PK");

            entity.ToTable("GEM$EVENTGROUP");

            entity.HasIndex(e => new { e.BookId, e.Resort })
                .HasName("EG_BOOKING_IDX");

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany(p => p.GemEventgroup)
	                .HasForeignKey(d => new { d.BookId, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("EG_BOOKING_FK");
        
			if (!types.Contains(typeof(GemEvent)))
				entity.Ignore(e => e.GemEvent);
		});
	}
}
