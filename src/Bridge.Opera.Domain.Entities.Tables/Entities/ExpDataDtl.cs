namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExpDataDtl
{
    public ExpDataDtl()
    {
        ExpCreditCardDetails = new HashSet<ExpCreditCardDetails>();
    }

    public decimal ExpDataId { get; set; }
    public decimal ExpDataDtlId { get; set; }
    public string ExpData { get; set; }
    public string ExpUpdatedData { get; set; }
    public string ChangedYn { get; set; }
    public string InactiveYn { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string FileExtn { get; set; }
    public string ExpData2 { get; set; }
    public string ExpData3 { get; set; }
    public string ExpUpdatedData2 { get; set; }
    public string ExpUpdatedData3 { get; set; }

    public virtual ExpDataHdr ExpDataNavigation { get; set; }
    public virtual ICollection<ExpCreditCardDetails> ExpCreditCardDetails { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpDataDtl>(entity =>
        {
            entity.HasKey(e => new { e.ExpDataId, e.ExpDataDtlId })
                .HasName("EDD_PK");

            entity.ToTable("EXP_DATA_DTL");

            entity.Property(e => e.ExpDataId)
                .HasColumnName("EXP_DATA_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpDataDtlId)
                .HasColumnName("EXP_DATA_DTL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChangedYn)
                .HasColumnName("CHANGED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.ExpData)
                .HasColumnName("EXP_DATA")
                .IsUnicode(false);

            entity.Property(e => e.ExpData2)
                .HasColumnName("EXP_DATA_2")
                .IsUnicode(false);

            entity.Property(e => e.ExpData3)
                .HasColumnName("EXP_DATA_3")
                .IsUnicode(false);

            entity.Property(e => e.ExpUpdatedData)
                .HasColumnName("EXP_UPDATED_DATA")
                .IsUnicode(false);

            entity.Property(e => e.ExpUpdatedData2)
                .HasColumnName("EXP_UPDATED_DATA_2")
                .IsUnicode(false);

            entity.Property(e => e.ExpUpdatedData3)
                .HasColumnName("EXP_UPDATED_DATA_3")
                .IsUnicode(false);

            entity.Property(e => e.FileExtn)
                .HasColumnName("FILE_EXTN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveYn)
                .HasColumnName("INACTIVE_YN")
                .HasMaxLength(1)
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

			if (!types.Contains(typeof(ExpDataHdr)))
				entity.Ignore(e => e.ExpDataNavigation);
			else
	            entity.HasOne(d => d.ExpDataNavigation)
	                .WithMany(p => p.ExpDataDtl)
	                .HasForeignKey(d => d.ExpDataId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("EDD_EDH_FK");
        
			if (!types.Contains(typeof(ExpCreditCardDetails)))
				entity.Ignore(e => e.ExpCreditCardDetails);
		});
	}
}
