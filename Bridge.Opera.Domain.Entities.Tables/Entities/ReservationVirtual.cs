namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationVirtual
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal Pool { get; set; }
    public string Virtual { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public string Password { get; set; }
    public string Username { get; set; }
    public decimal? SessionId { get; set; }

    public virtual ReservationName Res { get; set; }
    public virtual VnPoolDetails VnPoolDetails { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationVirtual>(entity =>
        {
            entity.HasKey(e => new { e.ResvNameId, e.Pool, e.Resort })
                .HasName("RV_PK");

            entity.ToTable("RESERVATION_VIRTUAL#");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId })
                .HasName("RESERVATION_VIRTUAL#_IND2");

            entity.HasIndex(e => new { e.Virtual, e.Pool, e.Resort })
                .HasName("RESERVATION_VIRTUAL#_IND1");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Pool)
                .HasColumnName("POOL#")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Password)
                .HasColumnName("PASSWORD")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SessionId)
                .HasColumnName("SESSION_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Username)
                .HasColumnName("USERNAME")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Virtual)
                .IsRequired()
                .HasColumnName("VIRTUAL#")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.ReservationVirtual)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESV_NAME_FK");

			if (!types.Contains(typeof(VnPoolDetails)))
				entity.Ignore(e => e.VnPoolDetails);
			else
	            entity.HasOne(d => d.VnPoolDetails)
	                .WithMany(p => p.ReservationVirtual)
	                .HasForeignKey(d => new { d.Virtual, d.Pool, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("VN_POOL_DETAILS_FK");
        });
	}
}
