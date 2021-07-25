using System;

using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class BookingVehicleSurvey
    {

        public virtual int BookingNo {get; set;}
        public virtual int BookingVehicleNo {get; set;}
        public virtual int ManifestId {get; set;}
        public virtual string PickupDeliveryFlg {get; set;}
        public virtual DateTime SurveyDate {get; set;}
        public virtual string NonStandardFtngs {get; set;}
        public virtual int IsDeviceVga {get; set;}
        public virtual int IsVehicleDamage {get; set;}
        public virtual int VehicleType {get; set;}
        public virtual string SurveyRec {get; set;}
        public virtual string LoadType {get; set;}
        public virtual int IsCustSurvey {get; set;}
        public virtual string PodName {get; set;}

        protected bool Equals(BookingVehicleSurvey other)
        {
            if (other == null)
            {
                return false;
            }

            return BookingNo.Equals(other.BookingNo)
                   && BookingVehicleNo.Equals(other.BookingVehicleNo)
                   && ManifestId.Equals(other.ManifestId)
                   && PickupDeliveryFlg.Equals(other.PickupDeliveryFlg)
                   && SurveyDate.Equals(other.SurveyDate)
                   && NonStandardFtngs.Equals(other.NonStandardFtngs)
                   && IsDeviceVga.Equals(other.IsDeviceVga)
                   && IsVehicleDamage.Equals(other.IsVehicleDamage)
                   && VehicleType.Equals(other.VehicleType)
                   && SurveyRec.Equals(other.SurveyRec)
                   && LoadType.Equals(other.LoadType)
                   && IsCustSurvey.Equals(other.IsCustSurvey)
                   && PodName.Equals(other.PodName);
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
            if (obj.GetType() != typeof (BookingVehicleSurvey))
            {
                return false;
            }
            return Equals((BookingVehicleSurvey) obj);
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
                hash = (hash * hashingMultiplier) ^ SurveyDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ NonStandardFtngs?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ IsDeviceVga.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsVehicleDamage.GetHashCode();
                hash = (hash * hashingMultiplier) ^ VehicleType.GetHashCode();
                hash = (hash * hashingMultiplier) ^ SurveyRec?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ LoadType?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ IsCustSurvey.GetHashCode();
                hash = (hash * hashingMultiplier) ^ PodName?.GetHashCode() ?? 0;
                return hash;
            }
        }
}


    public class BookingVehicleSurveyMap: ClassMap<BookingVehicleSurvey>
    {
        public BookingVehicleSurveyMap()
        {
            Table("bkg_veh_survey");
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
                .KeyProperty(x => x.ManifestId, keyPropertyAction: k =>
                {
                    k.ColumnName("manifest_id");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
                .KeyProperty(x => x.PickupDeliveryFlg, keyPropertyAction: k =>
                {
                    k.ColumnName("pkup_dlvr_flg");
                    k.Type(typeof(string)).Length(1);
                    k.Access.Property();
                });

            Map(x => x.BookingNo, "bkg_no").Not.Nullable();
            Map(x => x.BookingVehicleNo, "bkg_veh_no").Not.Nullable();
            Map(x => x.ManifestId, "manifest_id").Not.Nullable();
            Map(x => x.PickupDeliveryFlg, "pkup_dlvr_flg").Length(1).Not.Nullable();
            Map(x => x.SurveyDate, "survey_tms").Not.Nullable();
            Map(x => x.NonStandardFtngs, "non_std_ftngs").Length(100).Not.Nullable();
            Map(x => x.IsDeviceVga, "device_vga_ind").Not.Nullable();
            Map(x => x.IsVehicleDamage, "veh_dmg_ind").Not.Nullable();
            Map(x => x.VehicleType, "veh_type").Not.Nullable();
            Map(x => x.SurveyRec, "survey_rec").Length(700).Not.Nullable();
            Map(x => x.LoadType, "load_type").Length(1).Not.Nullable();
            Map(x => x.IsCustSurvey, "cust_survey_ind").Not.Nullable();
            Map(x => x.PodName, "pod_name").Length(30).Not.Nullable();
        }
    }
}