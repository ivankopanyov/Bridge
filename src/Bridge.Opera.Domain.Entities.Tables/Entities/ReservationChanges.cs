namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationChanges
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public DateTime BusinessDate { get; set; }
    public string ChangeType { get; set; }
    public string OldValue { get; set; }
    public string NewValue { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ReservationName Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationChanges>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.BusinessDate, e.ChangeType })
                .HasName("RESERVATION_CHANGES_PK");

            entity.ToTable("RESERVATION_CHANGES");

            entity.HasIndex(e => new { e.Resort, e.BusinessDate, e.ChangeType })
                .HasName("RESERVATION_CHANGES_BDATE_IDX");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId, e.ChangeType })
                .HasName("RESERVATION_CHANGES_CHG_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChangeType)
                .HasColumnName("CHANGE_TYPE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewValue)
                .HasColumnName("NEW_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OldValue)
                .HasColumnName("OLD_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.ReservationChanges)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .HasConstraintName("RESERVATION_CHANGES_FK");
        });
	}
}
