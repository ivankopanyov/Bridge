namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameLoyaltySegments
{
    public decimal? NameId { get; set; }
    public string? LoyaltySegmentCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual Name Name { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameLoyaltySegments>(entity =>
        {
            entity.HasKey(e => new { e.NameId, e.LoyaltySegmentCode })
                .HasName("NAME_LOYALTY_SEGMENTS_PK");

            entity.ToTable("NAME_LOYALTY_SEGMENTS");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LoyaltySegmentCode)
                .HasColumnName("LOYALTY_SEGMENT_CODE")
                .HasMaxLength(40)
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

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.Name);
			else
	            entity.HasOne(d => d.Name)
	                .WithMany(p => p.NameLoyaltySegments)
	                .HasForeignKey(d => d.NameId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("NLS_NAME_FK");
        });
	}
}
