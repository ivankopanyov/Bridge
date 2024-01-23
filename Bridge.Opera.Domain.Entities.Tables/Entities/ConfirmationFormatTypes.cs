namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ConfirmationFormatTypes
{
    public ConfirmationFormatTypes()
    {
        ConfirmFormatElements = new HashSet<ConfirmFormatElements>();
        ConfirmationFormats = new HashSet<ConfirmationFormats>();
    }

    public string FormatType { get; set; }
    public string Description { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string CanDeleteYn { get; set; }

    public virtual ICollection<ConfirmFormatElements> ConfirmFormatElements { get; set; }
    public virtual ICollection<ConfirmationFormats> ConfirmationFormats { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ConfirmationFormatTypes>(entity =>
        {
            entity.HasKey(e => e.FormatType)
                .HasName("CONFIRM_FORMAT_TYPES_PK");

            entity.ToTable("CONFIRMATION_FORMAT_TYPES");

            entity.Property(e => e.FormatType)
                .HasColumnName("FORMAT_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(ConfirmFormatElements)))
				entity.Ignore(e => e.ConfirmFormatElements);

			if (!types.Contains(typeof(ConfirmationFormats)))
				entity.Ignore(e => e.ConfirmationFormats);
		});
	}
}
