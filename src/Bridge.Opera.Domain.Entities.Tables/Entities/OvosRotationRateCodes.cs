namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosRotationRateCodes
{
    public decimal? Id { get; set; }
    public string? RateCode { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }

    public virtual OvosContractPoints IdNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosRotationRateCodes>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OVOS_ROTATION_RATE_CODES");

            entity.HasIndex(e => e.Id)
                .HasName("OVOS_ROTATION_RATE_CODES_IDX");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(OvosContractPoints)))
				entity.Ignore(e => e.IdNavigation);
			else
	            entity.HasOne(d => d.IdNavigation)
	                .WithMany()
	                .HasForeignKey(d => d.Id)
	                .HasConstraintName("ORRC_OCP_FK");
        });
	}
}
