namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipStatementDetUdfs
{
    public decimal? MemberStatementId { get; set; }
    public decimal? StatementBatchId { get; set; }
    public string? Udfc01 { get; set; }
    public string? Udfc02 { get; set; }
    public string? Udfc03 { get; set; }
    public string? Udfc04 { get; set; }
    public string? Udfc05 { get; set; }
    public string? Udfc06 { get; set; }
    public string? Udfc07 { get; set; }
    public string? Udfc08 { get; set; }
    public string? Udfc09 { get; set; }
    public string? Udfc10 { get; set; }
    public string? Udfc11 { get; set; }
    public string? Udfc12 { get; set; }
    public string? Udfc13 { get; set; }
    public string? Udfc14 { get; set; }
    public string? Udfc15 { get; set; }
    public string? Udfc16 { get; set; }
    public string? Udfc17 { get; set; }
    public string? Udfc18 { get; set; }
    public string? Udfc19 { get; set; }
    public string? Udfc20 { get; set; }
    public DateTime? Udfd01 { get; set; }
    public DateTime? Udfd02 { get; set; }
    public DateTime? Udfd03 { get; set; }
    public DateTime? Udfd04 { get; set; }
    public DateTime? Udfd05 { get; set; }
    public DateTime? Udfd06 { get; set; }
    public DateTime? Udfd07 { get; set; }
    public DateTime? Udfd08 { get; set; }
    public DateTime? Udfd09 { get; set; }
    public DateTime? Udfd10 { get; set; }
    public decimal? Udfn01 { get; set; }
    public decimal? Udfn02 { get; set; }
    public decimal? Udfn03 { get; set; }
    public decimal? Udfn04 { get; set; }
    public decimal? Udfn05 { get; set; }
    public decimal? Udfn06 { get; set; }
    public decimal? Udfn07 { get; set; }
    public decimal? Udfn08 { get; set; }
    public decimal? Udfn09 { get; set; }
    public decimal? Udfn10 { get; set; }
    public decimal? Udfn11 { get; set; }
    public decimal? Udfn12 { get; set; }
    public decimal? Udfn13 { get; set; }
    public decimal? Udfn14 { get; set; }
    public decimal? Udfn15 { get; set; }
    public decimal? Udfn16 { get; set; }
    public decimal? Udfn17 { get; set; }
    public decimal? Udfn18 { get; set; }
    public decimal? Udfn19 { get; set; }
    public decimal? Udfn20 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipStatementDetUdfs>(entity =>
        {
            entity.HasKey(e => e.MemberStatementId)
                .HasName("MEMBERSHIP_STMT_UDF_PPK");

            entity.ToTable("MEMBERSHIP_STATEMENT_DET_UDFS");

            entity.HasIndex(e => e.StatementBatchId)
                .HasName("MEMBERSHIP_STMT_UDF_IDX");

            entity.HasIndex(e => new { e.MemberStatementId, e.StatementBatchId })
                .HasName("MEMBERSHIP_STMT_DETUDF_IDX1");

            entity.Property(e => e.MemberStatementId)
                .HasColumnName("MEMBER_STATEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatementBatchId)
                .HasColumnName("STATEMENT_BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfc01)
                .HasColumnName("UDFC01")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc02)
                .HasColumnName("UDFC02")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc03)
                .HasColumnName("UDFC03")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc04)
                .HasColumnName("UDFC04")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc05)
                .HasColumnName("UDFC05")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc06)
                .HasColumnName("UDFC06")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc07)
                .HasColumnName("UDFC07")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc08)
                .HasColumnName("UDFC08")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc09)
                .HasColumnName("UDFC09")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc10)
                .HasColumnName("UDFC10")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc11)
                .HasColumnName("UDFC11")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc12)
                .HasColumnName("UDFC12")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc13)
                .HasColumnName("UDFC13")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc14)
                .HasColumnName("UDFC14")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc15)
                .HasColumnName("UDFC15")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc16)
                .HasColumnName("UDFC16")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc17)
                .HasColumnName("UDFC17")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc18)
                .HasColumnName("UDFC18")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc19)
                .HasColumnName("UDFC19")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc20)
                .HasColumnName("UDFC20")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfd01)
                .HasColumnName("UDFD01")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd02)
                .HasColumnName("UDFD02")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd03)
                .HasColumnName("UDFD03")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd04)
                .HasColumnName("UDFD04")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd05)
                .HasColumnName("UDFD05")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd06)
                .HasColumnName("UDFD06")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd07)
                .HasColumnName("UDFD07")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd08)
                .HasColumnName("UDFD08")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd09)
                .HasColumnName("UDFD09")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd10)
                .HasColumnName("UDFD10")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfn01)
                .HasColumnName("UDFN01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn02)
                .HasColumnName("UDFN02")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn03)
                .HasColumnName("UDFN03")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn04)
                .HasColumnName("UDFN04")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn05)
                .HasColumnName("UDFN05")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn06)
                .HasColumnName("UDFN06")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn07)
                .HasColumnName("UDFN07")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn08)
                .HasColumnName("UDFN08")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn09)
                .HasColumnName("UDFN09")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn10)
                .HasColumnName("UDFN10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn11)
                .HasColumnName("UDFN11")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn12)
                .HasColumnName("UDFN12")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn13)
                .HasColumnName("UDFN13")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn14)
                .HasColumnName("UDFN14")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn15)
                .HasColumnName("UDFN15")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn16)
                .HasColumnName("UDFN16")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn17)
                .HasColumnName("UDFN17")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn18)
                .HasColumnName("UDFN18")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn19)
                .HasColumnName("UDFN19")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn20)
                .HasColumnName("UDFN20")
                .HasColumnType("NUMBER");
        });
	}
}
