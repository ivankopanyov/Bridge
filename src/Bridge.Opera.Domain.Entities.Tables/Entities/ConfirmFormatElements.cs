namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ConfirmFormatElements
{
    public string? FormatType { get; set; }
    public string? FormatElement { get; set; }
    public byte? OrderBy { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? CanDeleteYn { get; set; }
    public string? ExtendedYn { get; set; }
    public string? Description { get; set; }

    public virtual ConfirmationFormatTypes FormatTypeNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ConfirmFormatElements>(entity =>
        {
            entity.HasKey(e => new { e.FormatType, e.FormatElement })
                .HasName("CONFIRM_FORMAT_ELEMENTS_PK");

            entity.ToTable("CONFIRM_FORMAT_ELEMENTS");

            entity.Property(e => e.FormatType)
                .HasColumnName("FORMAT_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FormatElement)
                .HasColumnName("FORMAT_ELEMENT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ExtendedYn)
                .HasColumnName("EXTENDED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy).HasColumnName("ORDER_BY");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ConfirmationFormatTypes)))
				entity.Ignore(e => e.FormatTypeNavigation);
			else
	            entity.HasOne(d => d.FormatTypeNavigation)
	                .WithMany(p => p.ConfirmFormatElements)
	                .HasForeignKey(d => d.FormatType)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("CONFIRM_FORMAT_ELEMENT_FK1");
        });
	}
}
