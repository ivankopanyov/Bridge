namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ColourHeader1
{
    public decimal ColourId { get; set; }
    public string Colourname { get; set; }
    public string Descr { get; set; }
    public decimal? OwnerUser { get; set; }
    public string WhereClause { get; set; }
    public string FormName { get; set; }
    public string Colour { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ColourHeader1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("COLOUR_HEADER");

            entity.Property(e => e.Colour)
                .HasColumnName("COLOUR")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ColourId)
                .HasColumnName("COLOUR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Colourname)
                .IsRequired()
                .HasColumnName("COLOURNAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Descr)
                .HasColumnName("DESCR")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FormName)
                .HasColumnName("FORM_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OwnerUser)
                .HasColumnName("OWNER_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WhereClause)
                .HasColumnName("WHERE_CLAUSE")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
