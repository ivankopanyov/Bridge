namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipInfo
{
    public decimal MembershipId { get; set; }
    public string ColumnName { get; set; }
    public string ColumnValue { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string UpperValue { get; set; }
    public string Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipInfo>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MEMBERSHIP_INFO");

            entity.HasIndex(e => e.UpdateDate)
                .HasName("MEM_INFO_IDX2");

            entity.HasIndex(e => new { e.ColumnName, e.UpperValue })
                .HasName("MEM_INFO_IDX1");

            entity.HasIndex(e => new { e.MembershipId, e.ColumnName, e.Resort })
                .HasName("MIO_UK")
                .IsUnique();

            entity.Property(e => e.ColumnName)
                .IsRequired()
                .HasColumnName("COLUMN_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ColumnValue)
                .HasColumnName("COLUMN_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpperValue)
                .HasColumnName("UPPER_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
