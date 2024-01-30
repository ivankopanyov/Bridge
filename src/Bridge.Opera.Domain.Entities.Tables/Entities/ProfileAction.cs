namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProfileAction
{
    public decimal? ActionId { get; set; }
    public string? ActionType { get; set; }
    public string? ActionDescription { get; set; }
    public string? Machine { get; set; }
    public decimal? NameId { get; set; }
    public string? Terminal { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileAction>(entity =>
        {
            entity.HasKey(e => e.ActionId)
                .HasName("PROFILE_ACTION_PK");

            entity.ToTable("PROFILE_ACTION");

            entity.HasIndex(e => new { e.NameId, e.ActionType })
                .HasName("PROFILE_ACTION_TYPE_NAMEID_IDX");

            entity.HasIndex(e => new { e.InsertDate, e.ChainCode, e.ActionType })
                .HasName("PROF_INSERT_DATE_IDX");

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionDescription)
                .HasColumnName("ACTION_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
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

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(10)
                .IsUnicode(false);
        });
	}
}
