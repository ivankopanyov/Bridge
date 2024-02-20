namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NameUdfVw
{
    public decimal? NameId { get; set; }
    public string? Udfc20 { get; set; }
    public string? Udfc21 { get; set; }
    public string? Udfc22 { get; set; }
    public string? Udfc23 { get; set; }
    public string? Udfc24 { get; set; }
    public string? Udfc25 { get; set; }
    public string? Udfc26 { get; set; }
    public string? Udfc27 { get; set; }
    public string? Udfc28 { get; set; }
    public string? Udfc29 { get; set; }
    public string? Udfc30 { get; set; }
    public string? Udfc31 { get; set; }
    public string? Udfc32 { get; set; }
    public string? Udfc33 { get; set; }
    public string? Udfc34 { get; set; }
    public string? Udfc35 { get; set; }
    public string? Udfc36 { get; set; }
    public string? Udfc37 { get; set; }
    public string? Udfc38 { get; set; }
    public string? Udfc39 { get; set; }
    public string? Udfc40 { get; set; }
    public decimal? Udfn20 { get; set; }
    public decimal? Udfn21 { get; set; }
    public decimal? Udfn22 { get; set; }
    public decimal? Udfn23 { get; set; }
    public decimal? Udfn24 { get; set; }
    public decimal? Udfn25 { get; set; }
    public decimal? Udfn26 { get; set; }
    public decimal? Udfn27 { get; set; }
    public decimal? Udfn28 { get; set; }
    public decimal? Udfn29 { get; set; }
    public decimal? Udfn30 { get; set; }
    public decimal? Udfn31 { get; set; }
    public decimal? Udfn32 { get; set; }
    public decimal? Udfn33 { get; set; }
    public decimal? Udfn34 { get; set; }
    public decimal? Udfn35 { get; set; }
    public decimal? Udfn36 { get; set; }
    public decimal? Udfn37 { get; set; }
    public decimal? Udfn38 { get; set; }
    public decimal? Udfn39 { get; set; }
    public decimal? Udfn40 { get; set; }
    public DateTime? Udfd10 { get; set; }
    public DateTime? Udfd11 { get; set; }
    public DateTime? Udfd12 { get; set; }
    public DateTime? Udfd13 { get; set; }
    public DateTime? Udfd14 { get; set; }
    public DateTime? Udfd15 { get; set; }
    public DateTime? Udfd16 { get; set; }
    public DateTime? Udfd17 { get; set; }
    public DateTime? Udfd18 { get; set; }
    public DateTime? Udfd19 { get; set; }
    public DateTime? Udfd20 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameUdfVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NAME_UDF_VW");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfc20)
                .HasColumnName("UDFC20")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc21)
                .HasColumnName("UDFC21")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc22)
                .HasColumnName("UDFC22")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc23)
                .HasColumnName("UDFC23")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc24)
                .HasColumnName("UDFC24")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc25)
                .HasColumnName("UDFC25")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc26)
                .HasColumnName("UDFC26")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc27)
                .HasColumnName("UDFC27")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc28)
                .HasColumnName("UDFC28")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc29)
                .HasColumnName("UDFC29")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc30)
                .HasColumnName("UDFC30")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc31)
                .HasColumnName("UDFC31")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc32)
                .HasColumnName("UDFC32")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc33)
                .HasColumnName("UDFC33")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc34)
                .HasColumnName("UDFC34")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc35)
                .HasColumnName("UDFC35")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc36)
                .HasColumnName("UDFC36")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc37)
                .HasColumnName("UDFC37")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc38)
                .HasColumnName("UDFC38")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc39)
                .HasColumnName("UDFC39")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc40)
                .HasColumnName("UDFC40")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfd10)
                .HasColumnName("UDFD10")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd11)
                .HasColumnName("UDFD11")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd12)
                .HasColumnName("UDFD12")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd13)
                .HasColumnName("UDFD13")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd14)
                .HasColumnName("UDFD14")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd15)
                .HasColumnName("UDFD15")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd16)
                .HasColumnName("UDFD16")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd17)
                .HasColumnName("UDFD17")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd18)
                .HasColumnName("UDFD18")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd19)
                .HasColumnName("UDFD19")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd20)
                .HasColumnName("UDFD20")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfn20)
                .HasColumnName("UDFN20")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn21)
                .HasColumnName("UDFN21")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn22)
                .HasColumnName("UDFN22")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn23)
                .HasColumnName("UDFN23")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn24)
                .HasColumnName("UDFN24")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn25)
                .HasColumnName("UDFN25")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn26)
                .HasColumnName("UDFN26")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn27)
                .HasColumnName("UDFN27")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn28)
                .HasColumnName("UDFN28")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn29)
                .HasColumnName("UDFN29")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn30)
                .HasColumnName("UDFN30")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn31)
                .HasColumnName("UDFN31")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn32)
                .HasColumnName("UDFN32")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn33)
                .HasColumnName("UDFN33")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn34)
                .HasColumnName("UDFN34")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn35)
                .HasColumnName("UDFN35")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn36)
                .HasColumnName("UDFN36")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn37)
                .HasColumnName("UDFN37")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn38)
                .HasColumnName("UDFN38")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn39)
                .HasColumnName("UDFN39")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn40)
                .HasColumnName("UDFN40")
                .HasColumnType("NUMBER");
        });
	}
}
