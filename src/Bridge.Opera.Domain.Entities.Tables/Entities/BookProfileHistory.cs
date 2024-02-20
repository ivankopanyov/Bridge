namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BookProfileHistory
{
    public decimal? LeadId { get; set; }
    public decimal? ProfileId { get; set; }
    public string? Resort { get; set; }
    public decimal? BookId { get; set; }
    public decimal? ProfRevId { get; set; }
    public string? SendYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BookProfileHistory>(entity =>
        {
            entity.HasKey(e => new { e.LeadId, e.ProfileId, e.Resort, e.BookId, e.ProfRevId })
                .HasName("BPHIST_PK");

            entity.ToTable("BOOK$PROFILE_HISTORY");

            entity.Property(e => e.LeadId)
                .HasColumnName("LEAD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfileId)
                .HasColumnName("PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfRevId)
                .HasColumnName("PROF_REV_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SendYn)
                .HasColumnName("SEND_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
