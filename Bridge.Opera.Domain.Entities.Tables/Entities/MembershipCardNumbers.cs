namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipCardNumbers
{
    public string ChainCode { get; set; }
    public string MembershipType { get; set; }
    public string MembershipCardNo { get; set; }
    public decimal NameId { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string SourceType { get; set; }
    public string SourceName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipCardNumbers>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MEMBERSHIP_CARD_NUMBERS");

            entity.HasIndex(e => e.MembershipCardNo)
                .HasName("MCR_IND2");

            entity.HasIndex(e => e.NameId)
                .HasName("MCR_IND1");

            entity.HasIndex(e => new { e.ChainCode, e.MembershipType, e.MembershipCardNo, e.NameId })
                .HasName("MCR_UK")
                .IsUnique();

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipCardNo)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceName)
                .HasColumnName("SOURCE_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SourceType)
                .HasColumnName("SOURCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
