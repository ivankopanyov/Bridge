namespace Bridge.Opera.Domain.Entities.Tables;

public partial class HotelAccounts
{
    public string Resort { get; set; }
    public string AcctCode { get; set; }
    public string AcctDesc { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual Resort ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HotelAccounts>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.AcctCode })
                .HasName("HOTEL_ACCOUNTS_PK");

            entity.ToTable("HOTEL_ACCOUNTS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AcctCode)
                .HasColumnName("ACCT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AcctDesc)
                .HasColumnName("ACCT_DESC")
                .HasMaxLength(2000)
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

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.HotelAccounts)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("HACCTS_RESORT");
        });
	}
}
