namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MemberCardRegUsers
{
    public string AppUserRegCode { get; set; }
    public string ChainCode { get; set; }
    public decimal? AppUserId { get; set; }
    public string AppUserUniq { get; set; }
    public string AppUser { get; set; }
    public string UserFirst { get; set; }
    public string UserLast { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string MemberCardRegCro { get; set; }
    public string MemberCardRegResort { get; set; }
    public string AppUserEmail { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemberCardRegUsers>(entity =>
        {
            entity.HasKey(e => e.AppUserRegCode)
                .HasName("MEMBER_CARD_REG_USERS_PK");

            entity.ToTable("MEMBER_CARD_REG_USERS");

            entity.HasIndex(e => e.AppUserId)
                .HasName("MEM_CARD_REG_USR_IDX01");

            entity.Property(e => e.AppUserRegCode)
                .HasColumnName("APP_USER_REG_CODE")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.AppUser)
                .IsRequired()
                .HasColumnName("APP_USER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AppUserEmail)
                .HasColumnName("APP_USER_EMAIL")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppUserUniq)
                .IsRequired()
                .HasColumnName("APP_USER_UNIQ")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemberCardRegCro)
                .HasColumnName("MEMBER_CARD_REG_CRO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MemberCardRegResort)
                .HasColumnName("MEMBER_CARD_REG_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UserFirst)
                .HasColumnName("USER_FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UserLast)
                .HasColumnName("USER_LAST")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
