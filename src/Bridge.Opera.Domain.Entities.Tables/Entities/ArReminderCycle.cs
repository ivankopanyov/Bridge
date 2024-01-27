namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ArReminderCycle
{
    public string GlobalAcctYn { get; set; }
    public string Resort { get; set; }
    public decimal ReminderCode { get; set; }
    public decimal? AccountTypeId { get; set; }
    public decimal? NoOfDays { get; set; }
    public decimal InsertUser { get; set; }
    public string LetterName { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual ArAccountTypes ArAccountTypes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArReminderCycle>(entity =>
        {
            entity.HasKey(e => new { e.ReminderCode, e.Resort })
                .HasName("REMINDER_PK");

            entity.ToTable("AR$_REMINDER_CYCLE");

            entity.HasIndex(e => new { e.Resort, e.AccountTypeId })
                .HasName("AR$_ACCOUNT_TYPES_IDX");

            entity.HasIndex(e => new { e.AccountTypeId, e.NoOfDays, e.Resort })
                .HasName("REMINDER_UK")
                .IsUnique();

            entity.Property(e => e.ReminderCode)
                .HasColumnName("REMINDER_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountTypeId)
                .HasColumnName("ACCOUNT_TYPE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GlobalAcctYn)
                .HasColumnName("GLOBAL_ACCT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LetterName)
                .HasColumnName("LETTER_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.NoOfDays)
                .HasColumnName("NO_OF_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ArAccountTypes)))
				entity.Ignore(e => e.ArAccountTypes);
			else
	            entity.HasOne(d => d.ArAccountTypes)
	                .WithMany(p => p.ArReminderCycle)
	                .HasForeignKey(d => new { d.Resort, d.AccountTypeId })
	                .HasConstraintName("AR$_ACCOUNT_TYPES");
        });
	}
}
