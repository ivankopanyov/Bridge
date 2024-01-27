namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BuildadminSidDetails
{
    public string Masterview { get; set; }
    public string Mastercolumn { get; set; }
    public string Masterexpression { get; set; }
    public string Detailview { get; set; }
    public string Detailcolumn { get; set; }
    public string Detailexpression { get; set; }
    public string Detailtabname { get; set; }

    public virtual BuildadminSidList MasterviewNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BuildadminSidDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BUILDADMIN_SID_DETAILS");

            entity.HasIndex(e => new { e.Masterview, e.Mastercolumn, e.Detailview })
                .HasName("BASIDDET_UK")
                .IsUnique();

            entity.Property(e => e.Detailcolumn)
                .HasColumnName("DETAILCOLUMN")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Detailexpression)
                .HasColumnName("DETAILEXPRESSION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Detailtabname)
                .HasColumnName("DETAILTABNAME")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Detailview)
                .HasColumnName("DETAILVIEW")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Mastercolumn)
                .IsRequired()
                .HasColumnName("MASTERCOLUMN")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Masterexpression)
                .HasColumnName("MASTEREXPRESSION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Masterview)
                .IsRequired()
                .HasColumnName("MASTERVIEW")
                .HasMaxLength(50)
                .IsUnicode(false);

			if (!types.Contains(typeof(BuildadminSidList)))
				entity.Ignore(e => e.MasterviewNavigation);
			else
	            entity.HasOne(d => d.MasterviewNavigation)
	                .WithMany()
	                .HasForeignKey(d => d.Masterview)
	                .HasConstraintName("BASIDDET_BASID_FK");
        });
	}
}
