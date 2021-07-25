using System;

using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class ManifestLocationSeq
    {

        public virtual int ManifestId {get; set;}
        public virtual string LocationId {get; set;}
        public virtual string LocationCode {get; set;}
        public virtual string PickupDeliveryCode {get; set;}
        public virtual int LocationSeq {get; set;}
        public virtual string LocationName {get; set;}
        public virtual string LocationAddress {get; set;}
        public virtual string LocationSuburb {get; set;}
        public virtual string LocationState {get; set;}
        public virtual string StatusCode {get; set;}
        public virtual DateTime ProcessDate {get; set;}
        public virtual int IsDamaged {get; set;}
        public virtual int IsGroupSignature {get; set;}
        public virtual DateTime PickupDeliveryDate {get; set;}

        protected bool Equals(ManifestLocationSeq other)
        {
            if (other == null)
            {
                return false;
            }

            return ManifestId.Equals(other.ManifestId)
                   && LocationId.Equals(other.LocationId)
                   && LocationCode.Equals(other.LocationCode)
                   && PickupDeliveryCode.Equals(other.PickupDeliveryCode)
                   && LocationSeq.Equals(other.LocationSeq)
                   && LocationName.Equals(other.LocationName)
                   && LocationAddress.Equals(other.LocationAddress)
                   && LocationSuburb.Equals(other.LocationSuburb)
                   && LocationState.Equals(other.LocationState)
                   && StatusCode.Equals(other.StatusCode)
                   && ProcessDate.Equals(other.ProcessDate)
                   && IsDamaged.Equals(other.IsDamaged)
                   && IsGroupSignature.Equals(other.IsGroupSignature)
                   && PickupDeliveryDate.Equals(other.PickupDeliveryDate);
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
            if (obj.GetType() != typeof (ManifestLocationSeq))
            {
                return false;
            }
            return Equals((ManifestLocationSeq) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                const int hashingBase = (int) 2166136261;
                const int hashingMultiplier = 16777619;
                int hash = hashingBase;
                hash = (hash * hashingMultiplier) ^ ManifestId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ LocationId?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ LocationCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ PickupDeliveryCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ LocationSeq.GetHashCode();
                hash = (hash * hashingMultiplier) ^ LocationName?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ LocationAddress?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ LocationSuburb?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ LocationState?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ StatusCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ ProcessDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsDamaged.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsGroupSignature.GetHashCode();
                hash = (hash * hashingMultiplier) ^ PickupDeliveryDate.GetHashCode();
                return hash;
            }
        }
}


    public class ManifestLocationSeqMap: ClassMap<ManifestLocationSeq>
    {
        public ManifestLocationSeqMap()
        {
            Table("mft_location_seq");
            CompositeId()
                .KeyProperty(x => x.ManifestId, keyPropertyAction: k =>
                {
                    k.ColumnName("manifest_id");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
                .KeyProperty(x => x.LocationId, keyPropertyAction: k =>
                {
                    k.ColumnName("location_id");
                    k.Type(typeof(string));
                    k.Access.Property();
                });

            Map(x => x.ManifestId, "manifest_id").Not.Nullable();
            Map(x => x.LocationId, "location_id").Length(30).Not.Nullable();
            Map(x => x.LocationCode, "location_code").Length(3).Not.Nullable();
            Map(x => x.PickupDeliveryCode, "pkup_dlvr_code").Length(1).Not.Nullable();
            Map(x => x.LocationSeq, "location_seq").Not.Nullable();
            Map(x => x.LocationName, "location_name").Length(30).Not.Nullable();
            Map(x => x.LocationAddress, "location_address").Length(30).Not.Nullable();
            Map(x => x.LocationSuburb, "location_suburb").Length(30).Not.Nullable();
            Map(x => x.LocationState, "location_state").Length(3).Not.Nullable();
            Map(x => x.StatusCode, "status_code").Length(3).Not.Nullable();
            Map(x => x.ProcessDate, "process_tms").Not.Nullable();
            Map(x => x.IsDamaged, "is_damaged").Not.Nullable();
            Map(x => x.IsGroupSignature, "is_group_signature").Not.Nullable();
            Map(x => x.PickupDeliveryDate, "pkup_dlvr_date").Not.Nullable();
        }
    }
}