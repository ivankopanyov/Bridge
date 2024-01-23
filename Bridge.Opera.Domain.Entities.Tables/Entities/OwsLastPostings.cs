namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OwsLastPostings
{
    public decimal PostingId { get; set; }
    public string ExternalPostingId { get; set; }
    public string InterfaceId { get; set; }
    public string Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string Room { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OwsLastPostings>(entity =>
        {
            entity.HasKey(e => e.PostingId)
                .HasName("OWS_LAST_POSTINGS_PK");

            entity.ToTable("OWS_LAST_POSTINGS");

            entity.HasIndex(e => new { e.ExternalPostingId, e.InterfaceId, e.Resort })
                .HasName("OWS_LAST_POSTINGS_UK")
                .IsUnique();

            entity.Property(e => e.PostingId)
                .HasColumnName("POSTING_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExternalPostingId)
                .IsRequired()
                .HasColumnName("EXTERNAL_POSTING_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
