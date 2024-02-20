namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipHistory
{
    public decimal? MembershipId { get; set; }
    public string? ChangeType { get; set; }
    public string? OldValue { get; set; }
    public string? NewValue { get; set; }
    public string? Description { get; set; }
    public decimal? ExtractBatchId { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? ActionId { get; set; }
    public string? ActionType { get; set; }

    public virtual Memberships Membership { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipHistory>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MEMBERSHIP_HISTORY");

            entity.HasIndex(e => e.MembershipId)
                .HasName("MEMBERSHIP_HISTORY_IND1");

            entity.HasIndex(e => new { e.ActionId, e.ActionType })
                .HasName("MEMBERSHIP_HISTORY_IND2");

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ChangeType)
                .HasColumnName("CHANGE_TYPE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExtractBatchId)
                .HasColumnName("EXTRACT_BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewValue)
                .HasColumnName("NEW_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.OldValue)
                .HasColumnName("OLD_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false);

			if (!types.Contains(typeof(Memberships)))
				entity.Ignore(e => e.Membership);
			else
	            entity.HasOne(d => d.Membership)
	                .WithMany()
	                .HasForeignKey(d => d.MembershipId)
	                .HasConstraintName("MEMBERSHIP_HISTORY_FK");
        });
	}
}
