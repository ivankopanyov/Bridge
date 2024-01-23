namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TelephoneBook
{
    public string CategoryCode { get; set; }
    public string Name { get; set; }
    public string Telephone { get; set; }
    public string Remarks { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal CategorySeq { get; set; }
    public string WebAddress { get; set; }

    public virtual TelephoneCategory CategorySeqNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TelephoneBook>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TELEPHONE_BOOK");

            entity.HasIndex(e => e.CategorySeq)
                .HasName("TEL_BOOK_TEL$_CATEGORY_IDX");

            entity.HasIndex(e => e.Name)
                .HasName("TELEPHONE_BOOK_NAME_IDX");

            entity.HasIndex(e => new { e.CategoryCode, e.Name })
                .HasName("TELEPHONE_BOOK_CAT_NAME_IDX");

            entity.Property(e => e.CategoryCode)
                .IsRequired()
                .HasColumnName("CATEGORY_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CategorySeq)
                .HasColumnName("CATEGORY_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Remarks)
                .HasColumnName("REMARKS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Telephone)
                .HasColumnName("TELEPHONE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WebAddress)
                .HasColumnName("WEB_ADDRESS")
                .HasMaxLength(1000)
                .IsUnicode(false);

			if (!types.Contains(typeof(TelephoneCategory)))
				entity.Ignore(e => e.CategorySeqNavigation);
			else
	            entity.HasOne(d => d.CategorySeqNavigation)
	                .WithMany()
	                .HasPrincipalKey(p => p.CategorySeq)
	                .HasForeignKey(d => d.CategorySeq)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("TEL_BOOK_TEL$_CATEGORY_FK");
        });
	}
}
