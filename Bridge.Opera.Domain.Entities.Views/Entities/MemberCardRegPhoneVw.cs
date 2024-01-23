namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MemberCardRegPhoneVw
{
    public string MemberCardRegCode { get; set; }
    public string PhoneType { get; set; }
    public string PhoneNumber { get; set; }
    public string PhoneRole { get; set; }
    public string ChainCode { get; set; }
    public decimal? PhoneId { get; set; }
    public string PrimaryYn { get; set; }
    public string ValidYn { get; set; }
    public string ErrorDesc { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemberCardRegPhoneVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBER_CARD_REG_PHONE_VW");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ErrorDesc)
                .HasColumnName("ERROR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemberCardRegCode)
                .IsRequired()
                .HasColumnName("MEMBER_CARD_REG_CODE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PhoneId)
                .HasColumnName("PHONE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasColumnName("PHONE_NUMBER")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PhoneRole)
                .HasColumnName("PHONE_ROLE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PhoneType)
                .IsRequired()
                .HasColumnName("PHONE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ValidYn)
                .HasColumnName("VALID_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
