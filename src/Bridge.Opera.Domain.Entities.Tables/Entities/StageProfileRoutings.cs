namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfileRoutings
{
    public string? Resort { get; set; }
    public string? ResortNameId { get; set; }
    public string? RoutingCode { get; set; }
    public string? TransactionCode { get; set; }
    public string? ExtRoutingResort { get; set; }
    public string? ValidYn { get; set; }
    public string? ErrorDesc { get; set; }
    public DateTime? InactiveDate { get; set; }

    public virtual StageProfiles ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileRoutings>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("STAGE_PROFILE_ROUTINGS");

            entity.HasIndex(e => new { e.Resort, e.ResortNameId })
                .HasName("STAGE_PROFROUT_IDX");

            entity.Property(e => e.ErrorDesc)
                .HasColumnName("ERROR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExtRoutingResort)
                .HasColumnName("EXT_ROUTING_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoutingCode)
                .HasColumnName("ROUTING_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TransactionCode)
                .HasColumnName("TRANSACTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ValidYn)
                .HasColumnName("VALID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

			if (!types.Contains(typeof(StageProfiles)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.ResortNameId })
	                .HasConstraintName("STAGE_PROFROUT_FK");
        });
	}
}
