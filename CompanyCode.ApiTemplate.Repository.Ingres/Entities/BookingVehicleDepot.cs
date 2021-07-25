using System;

using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities
{
    public class BookingVehicleDepot
    {
        public virtual int BookingNo { get; set; }
        public virtual int BookingVehicleNo { get; set; }
        public virtual string DepotCode { get; set; }
        public virtual int IsPickup { get; set; }
        public virtual string Notes { get; set; }
        public virtual string OperatorId { get; set; }
        public virtual DateTime PickupDate { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(BookingVehicleDepot))
                return false;
            return Equals((BookingVehicleDepot) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                const int hashingBase = (int) 2166136261;
                const int hashingMultiplier = 16777619;
                int hash = hashingBase;
                hash = (hash * hashingMultiplier) ^ BookingNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ BookingVehicleNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ DepotCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ IsPickup.GetHashCode();
                hash = (hash * hashingMultiplier) ^ PickupDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ Notes?.GetHashCode() ?? 0;
                return hash;
            }
        }

        protected bool Equals(BookingVehicleDepot other)
        {
            if (other == null)
                return false;

            return BookingNo.Equals(other.BookingNo)
                   && BookingVehicleNo.Equals(other.BookingVehicleNo)
                   && DepotCode.Equals(other.DepotCode)
                   && IsPickup.Equals(other.IsPickup)
                   && PickupDate.Equals(other.PickupDate)
                   && OperatorId.Equals(other.OperatorId)
                   && Notes.Equals(other.Notes);
        }
    }

    public class BookingVehicleDepotMap : ClassMap<BookingVehicleDepot>
    {
        public BookingVehicleDepotMap()
        {
            Table("bkg_veh_depot");
            CompositeId()
                .KeyProperty(x => x.IsPickup, k =>
                {
                    k.ColumnName("pkup_ind");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
                .KeyProperty(x => x.DepotCode, k =>
                {
                    k.ColumnName("chklist_tms");
                    k.Type(typeof(DateTime));
                    k.Access.Property();
                });

            Map(x => x.BookingNo, "bkg_no").Not.Nullable();
            Map(x => x.BookingVehicleNo, "bkg_veh_no").Not.Nullable();
            Map(x => x.DepotCode, "depot_abrv").Length(3).Not.Nullable().Index("bkg_veh_depot_1");
            Map(x => x.IsPickup, "pkup_ind").Not.Nullable().Index("bkg_veh_depot_1");
            Map(x => x.PickupDate, "pkup_tms").Not.Nullable();
            Map(x => x.OperatorId, "operator_id").Length(8).Not.Nullable();
            Map(x => x.Notes, "notes").Length(150).Not.Nullable();
        }
    }
}