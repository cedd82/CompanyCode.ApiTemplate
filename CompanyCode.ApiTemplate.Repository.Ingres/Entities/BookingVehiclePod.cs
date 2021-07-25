using System;

using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class BookingVehiclePod
    {

        public virtual int BookingNo {get; set;}
        public virtual int BookingVehicleNo {get; set;}
        public virtual DateTime ActualPickupDate {get; set;}
        public virtual DateTime ActualDeliveryDate {get; set;}
        public virtual string SentByName {get; set;}
        public virtual string RecByName {get; set;}
        public virtual DateTime EntryDate {get; set;}
        public virtual string PodStatusCode {get; set;}
        public virtual string PopStatusCode {get; set;}
        public virtual string PopUpdateMode {get; set;}
        public virtual string PodUpdateMode {get; set;}
        public virtual int ManifestId {get; set;}

        protected bool Equals(BookingVehiclePod other)
        {
            if (other == null)
            {
                return false;
            }

            return BookingNo.Equals(other.BookingNo)
                   && BookingVehicleNo.Equals(other.BookingVehicleNo)
                   && ActualPickupDate.Equals(other.ActualPickupDate)
                   && ActualDeliveryDate.Equals(other.ActualDeliveryDate)
                   && SentByName.Equals(other.SentByName)
                   && RecByName.Equals(other.RecByName)
                   && EntryDate.Equals(other.EntryDate)
                   && RecByName.Equals(other.RecByName)
                   && PodStatusCode.Equals(other.PodStatusCode)
                   && PopStatusCode.Equals(other.PopStatusCode)
                   && PopUpdateMode.Equals(other.PopUpdateMode)
                   && PodUpdateMode.Equals(other.PodUpdateMode)
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
            if (obj.GetType() != typeof (BookingVehiclePod))
            {
                return false;
            }
            return Equals((BookingVehiclePod) obj);
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
                hash = (hash * hashingMultiplier) ^ ActualPickupDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ActualDeliveryDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ SentByName?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ RecByName?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ EntryDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ RecByName?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ PodStatusCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ PopStatusCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ PopUpdateMode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ PodUpdateMode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ ManifestId.GetHashCode();
                return hash;
            }
        }
}


    public class BookingVehiclePodMap: ClassMap<BookingVehiclePod>
    {
        public BookingVehiclePodMap()
        {
            Table("bkg_veh_pod");
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
                });

            Map(x => x.BookingNo, "bkg_no").Not.Nullable();
            Map(x => x.BookingVehicleNo, "bkg_veh_no").Not.Nullable();
            Map(x => x.ActualPickupDate, "act_pkup_date").Not.Nullable();
            Map(x => x.ActualDeliveryDate, "act_dlvr_date").Not.Nullable();
            Map(x => x.SentByName, "sent_by_name").Length(30).Not.Nullable();
            Map(x => x.RecByName, "rec_by_name").Length(30).Not.Nullable();
            Map(x => x.EntryDate, "entry_tms").Not.Nullable();
            Map(x => x.PodStatusCode, "pod_status_code").Length(3).Not.Nullable();
            Map(x => x.PopStatusCode, "pop_status_code").Length(3).Not.Nullable();
            Map(x => x.PopUpdateMode, "pop_update_mode").Length(3).Not.Nullable();
            Map(x => x.PodUpdateMode, "pod_update_mode").Length(3).Not.Nullable();
            Map(x => x.ManifestId, "manifest_id").Not.Nullable();
        }
    }
}