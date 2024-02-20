namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BqtChkAccountInfo
{
    public decimal? Accbookid { get; set; }
    public decimal? Accid { get; set; }
    public string? Accname { get; set; }
    public string? Accaddress1 { get; set; }
    public string? Accaddress2 { get; set; }
    public string? Acccity { get; set; }
    public string? Acczipcode { get; set; }
    public string? Accstate { get; set; }
    public string? Acccountry { get; set; }
    public decimal? Conid { get; set; }
    public string? Conname { get; set; }
    public string? Conaddress1 { get; set; }
    public string? Conaddress2 { get; set; }
    public string? Concity { get; set; }
    public string? Conzipcode { get; set; }
    public string? Constate { get; set; }
    public string? Concountry { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BqtChkAccountInfo>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BQT_CHK_ACCOUNT_INFO");

            entity.Property(e => e.Accaddress1)
                .HasColumnName("ACCADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Accaddress2)
                .HasColumnName("ACCADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Accbookid)
                .HasColumnName("ACCBOOKID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Acccity)
                .HasColumnName("ACCCITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Acccountry)
                .HasColumnName("ACCCOUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Accid)
                .HasColumnName("ACCID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Accname)
                .HasColumnName("ACCNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Accstate)
                .HasColumnName("ACCSTATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Acczipcode)
                .HasColumnName("ACCZIPCODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.Conaddress1)
                .HasColumnName("CONADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Conaddress2)
                .HasColumnName("CONADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Concity)
                .HasColumnName("CONCITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Concountry)
                .HasColumnName("CONCOUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Conid)
                .HasColumnName("CONID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Conname)
                .HasColumnName("CONNAME")
                .HasMaxLength(162)
                .IsUnicode(false);

            entity.Property(e => e.Constate)
                .HasColumnName("CONSTATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Conzipcode)
                .HasColumnName("CONZIPCODE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
