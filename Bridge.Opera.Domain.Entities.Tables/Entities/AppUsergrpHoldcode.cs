namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AppUsergrpHoldcode
{
    public string Resort { get; set; }
    public decimal AppUserId { get; set; }
    public string HoldCode { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AppUsergrpHoldcode>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.AppUserId, e.HoldCode })
                .HasName("AUGHC_PK");

            entity.ToTable("APP_USERGRP_HOLDCODE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HoldCode)
                .HasColumnName("HOLD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");
        });
	}
}
