namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationKeyOptions
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal KeyOptionId { get; set; }
    public string Comments { get; set; }
    public decimal? InsertActionInstanceId { get; set; }
    public decimal? DmlSeqNo { get; set; }
    public string Source { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

    public virtual ReservationName Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationKeyOptions>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.KeyOptionId })
                .HasName("RESV_KEY_PK");

            entity.ToTable("RESERVATION_KEY_OPTIONS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.KeyOptionId)
                .HasColumnName("KEY_OPTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DmlSeqNo)
                .HasColumnName("DML_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertActionInstanceId)
                .HasColumnName("INSERT_ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Source)
                .HasColumnName("SOURCE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.ReservationKeyOptions)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESV_KEY_RNAME_FK");
        });
	}
}
