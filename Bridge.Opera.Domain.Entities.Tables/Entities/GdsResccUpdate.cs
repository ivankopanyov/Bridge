namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsResccUpdate
{
    public string Resort { get; set; }
    public decimal PropupId { get; set; }
    public string DepositCreditCard { get; set; }
    public string GuaranteeCreditCard { get; set; }
    public string GdsHost { get; set; }

    public virtual GdsPropupUpdate Propup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsResccUpdate>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.GuaranteeCreditCard })
                .HasName("GDS_RESCC_UPDATE_PK");

            entity.ToTable("GDS_RESCC_UPDATE");

            entity.HasIndex(e => e.PropupId)
                .HasName("GDS_RESCC_UPDATE_IND1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuaranteeCreditCard)
                .HasColumnName("GUARANTEE_CREDIT_CARD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DepositCreditCard)
                .HasColumnName("DEPOSIT_CREDIT_CARD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsHost)
                .IsRequired()
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropupId)
                .HasColumnName("PROPUP_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GdsPropupUpdate)))
				entity.Ignore(e => e.Propup);
			else
	            entity.HasOne(d => d.Propup)
	                .WithMany(p => p.GdsResccUpdate)
	                .HasForeignKey(d => d.PropupId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("GDS_RESCC_UPDATE_FK1");
        });
	}
}
