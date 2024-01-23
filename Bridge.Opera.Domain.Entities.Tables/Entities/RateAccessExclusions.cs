namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateAccessExclusions
{
    public string Resort { get; set; }
    public string RateCode { get; set; }
    public string AccessSourceType { get; set; }
    public string AccessSourceValue { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string PermModify { get; set; }
    public string PermCancel { get; set; }
    public string HideFromAvailYn { get; set; }
    public string PermCreate { get; set; }

    public virtual RateHeader R { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateAccessExclusions>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RateCode, e.AccessSourceType, e.AccessSourceValue, e.BeginDate })
                .HasName("RATE_ACCESS_EXCLUSIONS_PK");

            entity.ToTable("RATE_ACCESS_EXCLUSIONS");

            entity.HasIndex(e => new { e.AccessSourceType, e.AccessSourceValue, e.Resort, e.RateCode })
                .HasName("RATE_ACCESS_EXCLUSIONS_IND1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AccessSourceType)
                .HasColumnName("ACCESS_SOURCE_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AccessSourceValue)
                .HasColumnName("ACCESS_SOURCE_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HideFromAvailYn)
                .HasColumnName("HIDE_FROM_AVAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PermCancel)
                .HasColumnName("PERM_CANCEL")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PermCreate)
                .HasColumnName("PERM_CREATE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PermModify)
                .HasColumnName("PERM_MODIFY")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

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
	                .WithMany(p => p.RateAccessExclusions)
	                .HasForeignKey(d => new { d.Resort, d.RateCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RATE_ACCESS_EXCLUSIONS_FK");
        });
	}
}
