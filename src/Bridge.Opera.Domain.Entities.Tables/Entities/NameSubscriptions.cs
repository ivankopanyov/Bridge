namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameSubscriptions
{
    public decimal? NameId { get; set; }
    public string? DatabaseId { get; set; }
    public string? DatabaseNameId { get; set; }
    public string? DistributeYn { get; set; }
    public string? ForceYn { get; set; }
    public DateTime? LastDistributeDate { get; set; }
    public DateTime? LastActivityDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? AllowDuplicateYn { get; set; }
    public string? QueryCode { get; set; }
    public decimal? PendingAction { get; set; }

    public virtual Databases Database { get; set; }
    public virtual Name Name { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameSubscriptions>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("NAME_SUBSCRIPTIONS");

            entity.HasIndex(e => e.DatabaseId)
                .HasName("NAME_SUBSCRIPTION_IND5");

            entity.HasIndex(e => e.DatabaseNameId)
                .HasName("NAME_SUBSCRIPTION_IND");

            entity.HasIndex(e => e.PendingAction)
                .HasName("NAME_SUBSCRIPTION_IND3");

            entity.HasIndex(e => e.QueryCode)
                .HasName("NAME_SUBSCRIPTION_IND4");

            entity.HasIndex(e => new { e.NameId, e.DatabaseId, e.DatabaseNameId })
                .HasName("NAME_SUBSCRIPTION_UK")
                .IsUnique();

            entity.Property(e => e.AllowDuplicateYn)
                .HasColumnName("ALLOW_DUPLICATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DatabaseId)
                .IsRequired()
                .HasColumnName("DATABASE_ID")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DatabaseNameId)
                .HasColumnName("DATABASE_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DistributeYn)
                .HasColumnName("DISTRIBUTE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

            entity.Property(e => e.ForceYn)
                .HasColumnName("FORCE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastActivityDate)
                .HasColumnName("LAST_ACTIVITY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastDistributeDate)
                .HasColumnName("LAST_DISTRIBUTE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PendingAction)
                .HasColumnName("PENDING_ACTION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QueryCode)
                .HasColumnName("QUERY_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Databases)))
				entity.Ignore(e => e.Database);
			else
	            entity.HasOne(d => d.Database)
	                .WithMany()
	                .HasForeignKey(d => d.DatabaseId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("NAME_SUBSCRIP_DATABASES_FK");

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.Name);
			else
	            entity.HasOne(d => d.Name)
	                .WithMany()
	                .HasForeignKey(d => d.NameId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("NAME_SUBSCRIP_FK");
        });
	}
}
