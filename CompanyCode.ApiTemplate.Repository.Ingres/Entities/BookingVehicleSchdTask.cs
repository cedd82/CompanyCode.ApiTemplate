using System;

using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class BookingVehicleSchdTask
    {

        public virtual int BookingNo {get; set;}
        public virtual int BookingVehicleNo {get; set;}
        public virtual int ManifestId {get; set;}
        public virtual string PickupDeliveryFlg {get; set;}
        public virtual string EventCode {get; set;}
        public virtual DateTime EntryDate {get; set;}
        public virtual DateTime StartDate {get; set;}
        public virtual DateTime CompleteDate {get; set;}
        public virtual string StatusCode {get; set;}
        public virtual string IfaceStatusCode {get; set;}
        public virtual int IsVcmsExtract {get; set;}
        public virtual DateTime VcmsExtractDate {get; set;}
        public virtual string AppType {get; set;}
        public virtual string ProcessReference {get; set;}

        protected bool Equals(BookingVehicleSchdTask other)
        {
            if (other == null)
            {
                return false;
            }

            return BookingNo.Equals(other.BookingNo)
                   && BookingVehicleNo.Equals(other.BookingVehicleNo)
                   && ManifestId.Equals(other.ManifestId)
                   && PickupDeliveryFlg.Equals(other.PickupDeliveryFlg)
                   && EventCode.Equals(other.EventCode)
                   && EntryDate.Equals(other.EntryDate)
                   && StartDate.Equals(other.StartDate)
                   && CompleteDate.Equals(other.CompleteDate)
                   && StatusCode.Equals(other.StatusCode)
                   && IfaceStatusCode.Equals(other.IfaceStatusCode)
                   && IsVcmsExtract.Equals(other.IsVcmsExtract)
                   && VcmsExtractDate.Equals(other.VcmsExtractDate)
                   && AppType.Equals(other.AppType)
                   && ProcessReference.Equals(other.ProcessReference);
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
            if (obj.GetType() != typeof (BookingVehicleSchdTask))
            {
                return false;
            }
            return Equals((BookingVehicleSchdTask) obj);
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
                hash = (hash * hashingMultiplier) ^ ManifestId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ PickupDeliveryFlg?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ EventCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ EntryDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ StartDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ CompleteDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ StatusCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ IfaceStatusCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ IsVcmsExtract.GetHashCode();
                hash = (hash * hashingMultiplier) ^ VcmsExtractDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ AppType?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ ProcessReference?.GetHashCode() ?? 0;
                return hash;
            }
        }
}


    public class BookingVehicleSchdTaskMap: ClassMap<BookingVehicleSchdTask>
    {
        public BookingVehicleSchdTaskMap()
        {
            Table("bkg_veh_schd_task");
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
            Map(x => x.ManifestId, "manifest_id").Not.Nullable().Index("bkg_veh_schd_task_2");
            Map(x => x.PickupDeliveryFlg, "pkup_dlvr_flg").Length(1).Not.Nullable();
            Map(x => x.EventCode, "event_code").Length(3).Not.Nullable();
            Map(x => x.EntryDate, "entry_tms").Not.Nullable();
            Map(x => x.StartDate, "start_tms").Not.Nullable().Index("bkg_veh_schd_task_1");
            Map(x => x.CompleteDate, "complete_tms").Not.Nullable();
            Map(x => x.StatusCode, "status_code").Length(3).Not.Nullable().Index("bkg_veh_schd_task_1");
            Map(x => x.IfaceStatusCode, "iface_status_code").Length(3).Not.Nullable();
            Map(x => x.IsVcmsExtract, "vcms_extract_ind").Not.Nullable();
            Map(x => x.VcmsExtractDate, "vcms_extract_tms").Not.Nullable();
            Map(x => x.AppType, "app_type").Length(10).Not.Nullable();
            Map(x => x.ProcessReference, "app_type").Length(128).Not.Nullable();
        }
    }
}