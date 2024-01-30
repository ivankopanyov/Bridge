namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ArNotes
{
    public decimal? NoteId { get; set; }
    public string? Resort { get; set; }
    public decimal? AccountCode { get; set; }
    public string? NoteCode { get; set; }
    public string? NoteTitle { get; set; }
    public string? Notes { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? InternalYn { get; set; }

    public virtual ArAccount ArAccount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArNotes>(entity =>
        {
            entity.HasKey(e => e.NoteId)
                .HasName("ARN_PK");

            entity.ToTable("AR$_NOTES");

            entity.HasIndex(e => new { e.Resort, e.AccountCode })
                .HasName("ARN_ARACC_FKI");

            entity.Property(e => e.NoteId)
                .HasColumnName("NOTE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
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

            entity.Property(e => e.NoteCode)
                .HasColumnName("NOTE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NoteTitle)
                .HasColumnName("NOTE_TITLE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Notes)
                .HasColumnName("NOTES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ArAccount)))
				entity.Ignore(e => e.ArAccount);
			else
	            entity.HasOne(d => d.ArAccount)
	                .WithMany(p => p.ArNotes)
	                .HasForeignKey(d => new { d.Resort, d.AccountCode })
	                .HasConstraintName("ARN_ARACC_FK");
        });
	}
}
