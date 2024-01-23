namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TrxCodeDiversions
{
    public decimal DiversionId { get; set; }
    public string Resort { get; set; }
    public string DiversionCode { get; set; }
    public decimal SeqNo { get; set; }
    public string RuleType { get; set; }
    public string MembershipType { get; set; }
    public string MembershipLevel { get; set; }
    public string VipCode { get; set; }
    public string DivertToRoom { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrxCodeDiversions>(entity =>
        {
            entity.HasKey(e => e.DiversionId)
                .HasName("TRXDIV_PK");

            entity.ToTable("TRX$_CODE_DIVERSIONS");

            entity.HasIndex(e => new { e.Resort, e.DiversionCode, e.SeqNo })
                .HasName("TRXDIV_UK")
                .IsUnique();

            entity.Property(e => e.DiversionId)
                .HasColumnName("DIVERSION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiversionCode)
                .IsRequired()
                .HasColumnName("DIVERSION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DivertToRoom)
                .HasColumnName("DIVERT_TO_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RuleType)
                .IsRequired()
                .HasColumnName("RULE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.VipCode)
                .HasColumnName("VIP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
