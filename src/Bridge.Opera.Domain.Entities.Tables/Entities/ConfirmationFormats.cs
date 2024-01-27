namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ConfirmationFormats
{
    public string FormatCode { get; set; }
    public string FormatType { get; set; }
    public string FormatDefinition { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string CanDeleteYn { get; set; }
    public string Description { get; set; }
    public decimal? OrderBy { get; set; }
    public string ChainCode { get; set; }

    public virtual ConfirmationFormatTypes FormatTypeNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ConfirmationFormats>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.FormatCode })
                .HasName("CONFIRMATION_FORMATS_PK");

            entity.ToTable("CONFIRMATION_FORMATS");

            entity.HasIndex(e => e.FormatType)
                .HasName("CONFIRMATION_FORMATS_FK1_I");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FormatCode)
                .HasColumnName("FORMAT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FormatDefinition)
                .IsRequired()
                .HasColumnName("FORMAT_DEFINITION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FormatType)
                .IsRequired()
                .HasColumnName("FORMAT_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ConfirmationFormatTypes)))
				entity.Ignore(e => e.FormatTypeNavigation);
			else
	            entity.HasOne(d => d.FormatTypeNavigation)
	                .WithMany(p => p.ConfirmationFormats)
	                .HasForeignKey(d => d.FormatType)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("CONFIRMATION_FORMATS_FK1");
        });
	}
}
