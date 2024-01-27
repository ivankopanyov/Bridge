namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MsTab4
{
    public decimal? TabRowId { get; set; }
    public string Id { get; set; }
    public string Label { get; set; }
    public string Description { get; set; }
    public string SelectedYn { get; set; }
    public string Char1 { get; set; }
    public string Char2 { get; set; }
    public string Char3 { get; set; }
    public string Char4 { get; set; }
    public string Char5 { get; set; }
    public decimal? Number1 { get; set; }
    public decimal? Number2 { get; set; }
    public decimal? Number3 { get; set; }
    public decimal? Number4 { get; set; }
    public decimal? Number5 { get; set; }
    public DateTime? Date1 { get; set; }
    public DateTime? Date2 { get; set; }
    public DateTime? Date3 { get; set; }
    public DateTime? Date4 { get; set; }
    public DateTime? Date5 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MsTab4>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MS_TAB4");

            entity.Property(e => e.Char1)
                .HasColumnName("CHAR1")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Char2)
                .HasColumnName("CHAR2")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Char3)
                .HasColumnName("CHAR3")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Char4)
                .HasColumnName("CHAR4")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Char5)
                .HasColumnName("CHAR5")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Date1)
                .HasColumnName("DATE1")
                .HasColumnType("DATE");

            entity.Property(e => e.Date2)
                .HasColumnName("DATE2")
                .HasColumnType("DATE");

            entity.Property(e => e.Date3)
                .HasColumnName("DATE3")
                .HasColumnType("DATE");

            entity.Property(e => e.Date4)
                .HasColumnName("DATE4")
                .HasColumnType("DATE");

            entity.Property(e => e.Date5)
                .HasColumnName("DATE5")
                .HasColumnType("DATE");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Label)
                .HasColumnName("LABEL")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Number1)
                .HasColumnName("NUMBER1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Number2)
                .HasColumnName("NUMBER2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Number3)
                .HasColumnName("NUMBER3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Number4)
                .HasColumnName("NUMBER4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Number5)
                .HasColumnName("NUMBER5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SelectedYn)
                .HasColumnName("SELECTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TabRowId)
                .HasColumnName("TAB_ROW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
