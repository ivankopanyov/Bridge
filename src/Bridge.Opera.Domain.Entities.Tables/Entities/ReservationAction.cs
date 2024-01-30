namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationAction
{
    public decimal? ActionInstanceId { get; set; }
    public string? ActionType { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? Machine { get; set; }
    public string? Terminal { get; set; }
    public string? ActionDescription { get; set; }
    public decimal? RootResvNameId { get; set; }
    public string? Module { get; set; }
    public decimal? ParentActionInstanceId { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string? Resort { get; set; }
    public string? CroCode { get; set; }
    public decimal? CallHeaderId { get; set; }
    public string? ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationAction>(entity =>
        {
            entity.HasKey(e => e.ActionInstanceId)
                .HasName("RESERVATION_ACTION_PK");

            entity.ToTable("RESERVATION_ACTION");

            entity.HasIndex(e => e.ParentActionInstanceId)
                .HasName("RESERVATION_ACTION_IND1");

            entity.HasIndex(e => new { e.ActionInstanceId, e.ActionType })
                .HasName("RESERVATION_ACTION_IND3")
                .IsUnique();

            entity.HasIndex(e => new { e.BusinessDate, e.ActionType, e.ChainCode })
                .HasName("RESERVATION_ACTION_IND2");

            entity.HasIndex(e => new { e.InsertDate, e.Resort, e.ActionType })
                .HasName("RESV_INSERT_DATE_IDX");

            entity.Property(e => e.ActionInstanceId)
                .HasColumnName("ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActionDescription)
                .HasColumnName("ACTION_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CallHeaderId)
                .HasColumnName("CALL_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CroCode)
                .HasColumnName("CRO_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ParentActionInstanceId)
                .HasColumnName("PARENT_ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RootResvNameId)
                .HasColumnName("ROOT_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(10)
                .IsUnicode(false);
        });
	}
}
