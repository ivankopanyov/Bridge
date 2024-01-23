namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateTranslation
{
    public decimal RateTranslationId { get; set; }
    public string Resort { get; set; }
    public string LanguageCode { get; set; }
    public string Description { get; set; }
    public string TranslatedColumn { get; set; }
    public string Room { get; set; }
    public string RoomCategory { get; set; }
    public string RoomClass { get; set; }
    public string RateCode { get; set; }
    public string Product { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual RateHeader R { get; set; }
    public virtual ResortRoomClasses RNavigation { get; set; }
    public virtual Resort ResortNavigation { get; set; }
    public virtual ResortProducts ResortProducts { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateTranslation>(entity =>
        {
            entity.ToTable("RATE_TRANSLATION");

            entity.HasIndex(e => new { e.Resort, e.Product, e.LanguageCode })
                .HasName("RATE_TRANSLAT_PRODUCT_IDX");

            entity.HasIndex(e => new { e.Resort, e.RateCode, e.LanguageCode })
                .HasName("RATE_TRANSLAT_RATE_CODE_IDX");

            entity.HasIndex(e => new { e.Resort, e.Room, e.LanguageCode })
                .HasName("RATE_TRANSLAT_ROOM_IDX");

            entity.HasIndex(e => new { e.Resort, e.RoomCategory, e.LanguageCode })
                .HasName("RATE_TRANSLAT_ROOM_CAT_IDX");

            entity.HasIndex(e => new { e.Resort, e.RoomClass, e.LanguageCode })
                .HasName("RATE_TRANSLAT_ROOM_CLASS_IDX");

            entity.Property(e => e.RateTranslationId)
                .HasColumnName("RATE_TRANSLATION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LanguageCode)
                .IsRequired()
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Product)
                .HasColumnName("PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TranslatedColumn)
                .HasColumnName("TRANSLATED_COLUMN")
                .HasMaxLength(40)
                .IsUnicode(false);

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
	                .WithMany(p => p.RateTranslation)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RATE_TRANSLAT_RESORT_FK");

			if (!types.Contains(typeof(ResortProducts)))
				entity.Ignore(e => e.ResortProducts);
			else
	            entity.HasOne(d => d.ResortProducts)
	                .WithMany(p => p.RateTranslation)
	                .HasForeignKey(d => new { d.Resort, d.Product })
	                .HasConstraintName("RATE_TRANSLAT_RESORT_PRODU_FK");

			if (!types.Contains(typeof(RateHeader)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.RateTranslation)
	                .HasForeignKey(d => new { d.Resort, d.RateCode })
	                .HasConstraintName("RATE_TRANSLAT_RATE_HEADER_FK");

			if (!types.Contains(typeof(ResortRoomClasses)))
				entity.Ignore(e => e.RNavigation);
			else
	            entity.HasOne(d => d.RNavigation)
	                .WithMany(p => p.RateTranslation)
	                .HasForeignKey(d => new { d.Resort, d.RoomClass })
	                .HasConstraintName("RATE_TRANSLAT_ROOM_CLASS_FK");
        });
	}
}
