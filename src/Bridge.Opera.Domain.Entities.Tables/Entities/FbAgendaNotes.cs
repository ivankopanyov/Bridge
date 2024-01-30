namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FbAgendaNotes
{
    public decimal? FbaId { get; set; }
    public decimal? NoteId { get; set; }
    public string? NoteCode { get; set; }
    public string? InternalYn { get; set; }
    public string? NoteTitle { get; set; }
    public string? Notes { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public byte? LaptopChange { get; set; }

    public virtual FbAgenda Fba { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FbAgendaNotes>(entity =>
        {
            entity.HasKey(e => new { e.NoteId, e.FbaId })
                .HasName("FBAN_PK");

            entity.ToTable("FB$AGENDA_NOTES");

            entity.HasIndex(e => e.FbaId)
                .HasName("FBA_ID_IDX");

            entity.Property(e => e.NoteId)
                .HasColumnName("NOTE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbaId)
                .HasColumnName("FBA_ID")
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
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

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

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(FbAgenda)))
				entity.Ignore(e => e.Fba);
			else
	            entity.HasOne(d => d.Fba)
	                .WithMany(p => p.FbAgendaNotes)
	                .HasForeignKey(d => d.FbaId)
	                .HasConstraintName("FBAN_FBA_FK");
        });
	}
}
