using Microsoft.EntityFrameworkCore;

namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ActivityReservationGuest
{
    public decimal NameId { get; set; }
    public string Last { get; set; }
    public string First { get; set; }
    public string RelationshipType { get; set; }
    public string RelationshipTypeDesc { get; set; }
    public string OcNameId { get; set; }
    public string GcNameId { get; set; }
    public string CreateRelationshipYn { get; set; }
    public string IncludeGuestYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ActivityReservationGuest>(entity =>
        {
            entity.HasKey(e => e.NameId)
                .HasName("ACT_RESV_GST_PK");

            entity.ToTable("ACTIVITY_RESERVATION_GUEST");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreateRelationshipYn)
                .HasColumnName("CREATE_RELATIONSHIP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GcNameId)
                .HasColumnName("GC_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IncludeGuestYn)
                .HasColumnName("INCLUDE_GUEST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Last)
                .HasColumnName("LAST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OcNameId)
                .HasColumnName("OC_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RelationshipType)
                .HasColumnName("RELATIONSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RelationshipTypeDesc)
                .HasColumnName("RELATIONSHIP_TYPE_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
