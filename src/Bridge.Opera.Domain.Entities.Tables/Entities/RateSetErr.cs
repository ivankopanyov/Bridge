namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateSetErr
{
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public DateTime? RateDate { get; set; }
    public string? RoomCategory { get; set; }
    public decimal? Los { get; set; }
    public decimal? Amount { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual RateHeader R { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateSetErr>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RateCode, e.RateDate, e.RoomCategory, e.Los })
                .HasName("RATE_SET_ERR_PK");

            entity.ToTable("RATE_SET_ERR");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateDate)
                .HasColumnName("RATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Los)
                .HasColumnName("LOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

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

			if (!types.Contains(typeof(RateHeader)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.RateSetErr)
	                .HasForeignKey(d => new { d.Resort, d.RateCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RATE_SET_ERR_RH_FK");
        });
	}
}
