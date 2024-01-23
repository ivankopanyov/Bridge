namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EuroConvSummDetails
{
    public string TableName { get; set; }
    public decimal? ConvertedRecords { get; set; }
    public string FromScope { get; set; }
    public string ToScope { get; set; }
    public DateTime? FromTime { get; set; }
    public DateTime? ToTime { get; set; }

    public virtual EuroConvSumm TableNameNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EuroConvSummDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("EURO_CONV_SUMM_DETAILS");

            entity.HasIndex(e => e.TableName)
                .HasName("EC_IND");

            entity.Property(e => e.ConvertedRecords)
                .HasColumnName("CONVERTED_RECORDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromScope)
                .HasColumnName("FROM_SCOPE")
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.Property(e => e.FromTime)
                .HasColumnName("FROM_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.TableName)
                .IsRequired()
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ToScope)
                .HasColumnName("TO_SCOPE")
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.Property(e => e.ToTime)
                .HasColumnName("TO_TIME")
                .HasColumnType("DATE");

			if (!types.Contains(typeof(EuroConvSumm)))
				entity.Ignore(e => e.TableNameNavigation);
			else
	            entity.HasOne(d => d.TableNameNavigation)
	                .WithMany()
	                .HasForeignKey(d => d.TableName)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ECSD_ECS_FK");
        });
	}
}
