using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class BookingVehiclePodSignature
    {

        public virtual int BookingNo {get; set;}
        public virtual int BookingVehicleNo {get; set;}
        public virtual string PickupDeliveryFlag {get; set;}
        public virtual string PodSignature {get; set;}
        public virtual int ManifestId {get; set;}

        protected bool Equals(BookingVehiclePodSignature other)
        {
            if (other == null)
            {
                return false;
            }

            return BookingNo.Equals(other.BookingNo)
                   && BookingVehicleNo.Equals(other.BookingVehicleNo)
                   && PickupDeliveryFlag.Equals(other.PickupDeliveryFlag)
                   && PodSignature.Equals(other.PodSignature)
                   && ManifestId.Equals(other.ManifestId);
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
            if (obj.GetType() != typeof (BookingVehiclePodSignature))
            {
                return false;
            }
            return Equals((BookingVehiclePodSignature) obj);
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
                hash = (hash * hashingMultiplier) ^ PickupDeliveryFlag?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ PodSignature?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ ManifestId.GetHashCode();
                return hash;
            }
        }
}


    public class BookingVehiclePodSignatureMap: ClassMap<BookingVehiclePodSignature>
    {
        public BookingVehiclePodSignatureMap()
        {
            Table("bkg_veh_pod_signature");
            CompositeId()
                .KeyProperty(x => x.BookingNo, keyPropertyAction: k =>
                {
                    k.ColumnName("bkg_no");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
                .KeyProperty(x => x.BookingVehicleNo, keyPropertyAction: k =>
                {
                    k.ColumnName("bkg_veh_no");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
                .KeyProperty(x => x.BookingVehicleNo, keyPropertyAction: k =>
                {
                    k.ColumnName("pkup_dlvr_flag");
                    k.Type(typeof(string)).Length(1);
                    k.Access.Property();
                });

            Map(x => x.BookingNo, "bkg_no").Not.Nullable();
            Map(x => x.BookingVehicleNo, "bkg_veh_no").Not.Nullable();
            Map(x => x.PickupDeliveryFlag, "pkup_dlvr_flag").Length(1).Not.Nullable();
            Map(x => x.PodSignature, "pod_signature").Length(3000).Not.Nullable();
            Map(x => x.ManifestId, "manifest_id").Not.Nullable();
        }
    }
}