namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidOsrAvailableFieldsSys
{
    public decimal Fieldid { get; set; }
    public string Content { get; set; }
    public string Description { get; set; }
    public string Label { get; set; }
    public string Source { get; set; }
    public string Alias { get; set; }
    public string Link { get; set; }
    public decimal? Width { get; set; }
    public string Alignment { get; set; }
    public string Type { get; set; }
    public string Parametertype { get; set; }
    public string Value { get; set; }
    public string Format { get; set; }
    public string Selectlov { get; set; }
    public string Reserve { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string Filter { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidOsrAvailableFieldsSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_OSR_AVAILABLE_FIELDS_SYS");

            entity.Property(e => e.Alias)
                .HasColumnName("ALIAS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Alignment)
                .HasColumnName("ALIGNMENT")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Content)
                .IsRequired()
                .HasColumnName("CONTENT")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Fieldid)
                .HasColumnName("FIELDID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Filter)
                .HasColumnName("FILTER")
                .IsUnicode(false);

            entity.Property(e => e.Format)
                .HasColumnName("FORMAT")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Label)
                .IsRequired()
                .HasColumnName("LABEL")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Link)
                .HasColumnName("LINK")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Parametertype)
                .HasColumnName("PARAMETERTYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Reserve)
                .HasColumnName("RESERVE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Selectlov)
                .HasColumnName("SELECTLOV")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Source)
                .IsRequired()
                .HasColumnName("SOURCE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Value)
                .HasColumnName("VALUE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Width)
                .HasColumnName("WIDTH")
                .HasColumnType("NUMBER");
        });
	}
}
