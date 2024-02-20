namespace Bridge.Opera.Domain.Entities.Tables;

public partial class VouchersResvChangeLog
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? ChangedType { get; set; }
    public decimal? ChangedDays { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

    public virtual ReservationName Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<VouchersResvChangeLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("VOUCHERS_RESV_CHANGE_LOG");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId })
                .HasName("VRCL_RESVNAME_FKI");

            entity.Property(e => e.ChangedDays)
                .HasColumnName("CHANGED_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChangedType)
                .IsRequired()
                .HasColumnName("CHANGED_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .HasConstraintName("VRCL_RESVNAME_FK");
        });
	}
}
