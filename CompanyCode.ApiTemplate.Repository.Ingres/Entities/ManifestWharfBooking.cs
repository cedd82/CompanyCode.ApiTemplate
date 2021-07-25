using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class ManifestWharfBooking
    {

        public virtual int ManifestId {get; set;}
        public virtual int BookingNo {get; set;}
        public virtual int ModelCode {get; set;}
        public virtual int VehicleCode {get; set;}
        public virtual string ShipName {get; set;}
        public virtual string VehicleReference {get; set;}
        public virtual int AllocQty {get; set;}
        public virtual string LocationId {get; set;}
        public virtual int PickQty {get; set;}
        public virtual int VesselId {get; set;}

        protected bool Equals(ManifestWharfBooking other)
        {
            if (other == null)
            {
                return false;
            }

            return ManifestId.Equals(other.ManifestId)
                   && BookingNo.Equals(other.BookingNo)
                   && ModelCode.Equals(other.ModelCode)
                   && VehicleCode.Equals(other.VehicleCode)
                   && ShipName.Equals(other.ShipName)
                   && VehicleReference.Equals(other.VehicleReference)
                   && AllocQty.Equals(other.AllocQty)
                   && LocationId.Equals(other.LocationId)
                   && PickQty.Equals(other.PickQty)
                   && VesselId.Equals(other.VesselId);
        }

        
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != typeof (ManifestWharfBooking))
            {
                return false;
            }
            return Equals((ManifestWharfBooking) obj);
        }
        
        public override int GetHashCode()
        {
            unchecked
            {
                const int hashingBase = (int) 2166136261;
                const int hashingMultiplier = 16777619;
                int hash = hashingBase;
                hash = (hash * hashingMultiplier) ^ ManifestId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ BookingNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ModelCode.GetHashCode();
                hash = (hash * hashingMultiplier) ^ VehicleCode.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ShipName?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ VehicleReference?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ AllocQty.GetHashCode();
                hash = (hash * hashingMultiplier) ^ LocationId?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ PickQty.GetHashCode();
                hash = (hash * hashingMultiplier) ^ VesselId.GetHashCode();
                return hash;
            }
        }
}


    public class ManifestWharfBookingMap: ClassMap<ManifestWharfBooking>
    {
        public ManifestWharfBookingMap()
        {
            Table("mft_wharf_bkg");
            CompositeId()
                .KeyProperty(x => x.ManifestId, keyPropertyAction: k =>
                {
                    k.ColumnName("manifest_id");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
                .KeyProperty(x => x.BookingNo, keyPropertyAction: k =>
                {
                    k.ColumnName("bkg_no");
                    k.Type(typeof(int));
                    k.Access.Property();
                });

            Map(x => x.ManifestId, "manifest_id").Not.Nullable();
            Map(x => x.BookingNo, "bkg_no").Not.Nullable();
            Map(x => x.ModelCode, "model_code").Not.Nullable();
            Map(x => x.VehicleCode, "veh_code").Not.Nullable();
            Map(x => x.ShipName, "ship_name").Length(20).Not.Nullable();
            Map(x => x.VehicleReference, "veh_ref").Length(20).Not.Nullable();
            Map(x => x.AllocQty, "alloc_qty").Not.Nullable();
            Map(x => x.LocationId, "location_id").Length(30).Not.Nullable();
            Map(x => x.PickQty, "pick_qty").Not.Nullable();
            Map(x => x.VesselId, "vessel_id").Not.Nullable();
        }
    }
}