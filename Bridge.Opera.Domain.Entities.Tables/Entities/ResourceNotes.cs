namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResourceNotes
{
    public string Resort { get; set; }
    public decimal BookId { get; set; }
    public decimal EventId { get; set; }
    public decimal NoteId { get; set; }
    public decimal ResourceId { get; set; }
    public string ResourceType { get; set; }
    public string NoteTitle { get; set; }
    public string Notes { get; set; }
    public string InternalYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual GemEvent Event { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResourceNotes>(entity =>
        {
            entity.HasKey(e => e.NoteId)
                .HasName("RN_PK");

            entity.ToTable("RESOURCE$NOTES");

            entity.HasIndex(e => e.EventId)
                .HasName("RN_GE_IDX");

            entity.HasIndex(e => new { e.BookId, e.EventId, e.ResourceType, e.ResourceId, e.NoteId })
                .HasName("RN_UK")
                .IsUnique();

            entity.Property(e => e.NoteId)
                .HasColumnName("NOTE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NoteTitle)
                .HasColumnName("NOTE_TITLE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Notes)
                .HasColumnName("NOTES")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResourceId)
                .HasColumnName("RESOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResourceType)
                .IsRequired()
                .HasColumnName("RESOURCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GemEvent)))
				entity.Ignore(e => e.Event);
			else
	            entity.HasOne(d => d.Event)
	                .WithMany(p => p.ResourceNotes)
	                .HasForeignKey(d => d.EventId)
	                .HasConstraintName("RN_GE_FK");
        });
	}
}
