using System;

using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class RtecAudit
    {

        public virtual int ManifestId {get; set;}
        public virtual int LoadId {get; set;}
        public virtual int LoadItemNo {get; set;}
        public virtual string EventCode {get; set;}
        public virtual int DriverId {get; set;}
        public virtual DateTime EventTimestamp {get; set;}
        public virtual DateTime EventDate1 {get; set;}
        public virtual DateTime EventDate2 {get; set;}
        public virtual DateTime EventDate3 {get; set;}
        public virtual DateTime EventDate4 {get; set;}
        public virtual DateTime SystemDate {get; set;}
        public virtual string XCoordinate {get; set;}
        public virtual string YCoordinate {get; set;}
        public virtual string XCoordinate1 {get; set;}
        public virtual string YCoordinate1 {get; set;}
        public virtual string XCoordinate2 {get; set;}
        public virtual string YCoordinate2 {get; set;}
        public virtual string XCoordinate3 {get; set;}
        public virtual string YCoordinate3 {get; set;}
        public virtual string XCoordinate4 {get; set;}
        public virtual string YCoordinate4 {get; set;}
        public virtual string DeviceId {get; set;}
        public virtual string VersionNo {get; set;}
        public virtual string Comments {get; set;}
        public virtual string OperatorId {get; set;}
        public virtual string AppType {get; set;}
        public virtual string AppVersion {get; set;}
        public virtual string VehicleBarcode {get; set;}
        public virtual string VehicleId {get; set;}
        public virtual int IsOe {get; set;}
        public virtual int IsScannable {get; set;}
        public virtual string SurveyConditionName {get; set;}
        public virtual string SurveyDamageName {get; set;}
        public virtual string SurveySilhouetteName {get; set;}
        public virtual string SurveyReference {get; set;}
        public virtual int IsDamaged {get; set;}
        public virtual int IsSilhouette {get; set;}

        protected bool Equals(RtecAudit other)
        {
            if (other == null)
            {
                return false;
            }

            return DriverId.Equals(other.DriverId)
                   && ManifestId.Equals(other.ManifestId)
                   && LoadId.Equals(other.LoadId)
                   && LoadItemNo.Equals(other.LoadItemNo)
                   && EventCode.Equals(other.EventCode)
                   && DriverId.Equals(other.DriverId)
                   && EventTimestamp.Equals(other.EventTimestamp)
                   && EventDate1.Equals(other.EventDate1)
                   && EventDate2.Equals(other.EventDate2)
                   && EventDate3.Equals(other.EventDate3)
                   && EventDate4.Equals(other.EventDate4)
                   && SystemDate.Equals(other.SystemDate)
                   && XCoordinate.Equals(other.XCoordinate)
                   && YCoordinate.Equals(other.YCoordinate)
                   && XCoordinate1.Equals(other.XCoordinate1)
                   && YCoordinate1.Equals(other.YCoordinate1)
                   && XCoordinate2.Equals(other.XCoordinate2)
                   && YCoordinate2.Equals(other.YCoordinate2)
                   && XCoordinate3.Equals(other.XCoordinate3)
                   && YCoordinate3.Equals(other.YCoordinate3)
                   && XCoordinate4.Equals(other.XCoordinate4)
                   && YCoordinate4.Equals(other.YCoordinate4)
                   && DeviceId.Equals(other.DeviceId)
                   && VersionNo.Equals(other.VersionNo)
                   && Comments.Equals(other.Comments)
                   && OperatorId.Equals(other.OperatorId)
                   && OperatorId.Equals(other.AppType)
                   && OperatorId.Equals(other.AppVersion)
                   && OperatorId.Equals(other.VehicleId)
                   && OperatorId.Equals(other.VehicleBarcode)
                   && IsOe.Equals(other.IsOe)
                   && IsScannable.Equals(other.IsScannable)
                   && SurveyConditionName.Equals(other.SurveyConditionName)
                   && SurveyDamageName.Equals(other.SurveyDamageName)
                   && SurveySilhouetteName.Equals(other.SurveySilhouetteName)
                   && SurveyReference.Equals(other.SurveyReference)
                   && IsDamaged.Equals(other.IsDamaged)
                   && IsSilhouette.Equals(other.IsSilhouette);
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
             if (obj.GetType() != typeof (RtecAudit))
             {
                 return false;
             }
             return Equals((RtecAudit) obj);
         }

         public override int GetHashCode()
         {
             unchecked
             {
                 const int hashingBase = (int) 2166136261;
                 const int hashingMultiplier = 16777619;
                 int hash = hashingBase;
                 hash = (hash * hashingMultiplier) ^ ManifestId.GetHashCode();
                 hash = (hash * hashingMultiplier) ^ LoadId.GetHashCode();
                 hash = (hash * hashingMultiplier) ^ LoadItemNo.GetHashCode();
                 hash = (hash * hashingMultiplier) ^ EventCode?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ DriverId.GetHashCode();
                 hash = (hash * hashingMultiplier) ^ EventTimestamp.GetHashCode();
                 hash = (hash * hashingMultiplier) ^ EventDate1.GetHashCode();
                 hash = (hash * hashingMultiplier) ^ EventDate2.GetHashCode();
                 hash = (hash * hashingMultiplier) ^ EventDate3.GetHashCode();
                 hash = (hash * hashingMultiplier) ^ EventDate4.GetHashCode();
                 hash = (hash * hashingMultiplier) ^ SystemDate.GetHashCode();
                 hash = (hash * hashingMultiplier) ^ XCoordinate?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ YCoordinate?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ XCoordinate1?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ YCoordinate1?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ XCoordinate2?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ YCoordinate2?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ XCoordinate3?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ YCoordinate3?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ XCoordinate4?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ YCoordinate4?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ DeviceId?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ VersionNo?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ Comments?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ OperatorId?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ AppType?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ AppVersion?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ VehicleBarcode?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ VehicleId?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ IsOe.GetHashCode();
                 hash = (hash * hashingMultiplier) ^ IsScannable.GetHashCode();
                 hash = (hash * hashingMultiplier) ^ SurveyConditionName?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ SurveyDamageName?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ SurveySilhouetteName?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ SurveyReference?.GetHashCode() ?? 0;
                 hash = (hash * hashingMultiplier) ^ IsDamaged.GetHashCode();
                 hash = (hash * hashingMultiplier) ^ IsSilhouette.GetHashCode();
                 return hash;
             }
         }
    }


    public class RtecAuditMap: ClassMap<RtecAudit>
    {
        public RtecAuditMap()
        {
            Table("rtec_audit");
            CompositeId()
                .KeyProperty(x => x.ManifestId, keyPropertyAction: k =>
                {
                    k.ColumnName("manifest_id");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
                .KeyProperty(x => x.LoadId, keyPropertyAction: k =>
                {
                    k.ColumnName("load_id");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
                .KeyProperty(x => x.LoadItemNo, keyPropertyAction: k =>
                {
                    k.ColumnName("load_item_no");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
                .KeyProperty(x => x.EventCode, keyPropertyAction: k =>
                {
                    k.ColumnName("event_code");
                    k.Type(typeof(string));
                    k.Access.Property();
                    k.Length(3);
                });
            //	CONSTRAINT RTEC_AUDIT_PK PRIMARY KEY (manifest_id,load_id,load_item_no,event_code)
            //);
            //CREATE INDEX rtec_audit_1 ON dba.rtec_audit (event_code,event_tms);
            Map(x => x.ManifestId, "manifest_id").Not.Nullable();
            Map(x => x.LoadId, "load_id").Not.Nullable();
            Map(x => x.LoadItemNo, "load_item_no").Not.Nullable();
            Map(x => x.EventCode, "event_code").Length(3).Not.Nullable().Index("rtec_audit_1");
            Map(x => x.DriverId, "driver_id").Not.Nullable();
            Map(x => x.EventTimestamp, "event_tms").Not.Nullable().Index("rtec_audit_1");;
            Map(x => x.EventDate1, "event_tms_1").Not.Nullable();
            Map(x => x.EventDate2, "event_tms_2").Not.Nullable();
            Map(x => x.EventDate3, "event_tms_3").Not.Nullable();
            Map(x => x.EventDate4, "event_tms_4").Not.Nullable();
            Map(x => x.SystemDate, "system_tms").Not.Nullable();
            Map(x => x.XCoordinate, "x_coordinate").Length(20).Not.Nullable();
            Map(x => x.YCoordinate, "y_coordinate").Length(20).Not.Nullable();
            Map(x => x.XCoordinate1, "x_coordinate_1").Length(20).Not.Nullable();
            Map(x => x.YCoordinate1, "y_coordinate_1").Length(20).Not.Nullable();
            Map(x => x.XCoordinate2, "x_coordinate_2").Length(20).Not.Nullable();
            Map(x => x.YCoordinate2, "y_coordinate_2").Length(20).Not.Nullable();
            Map(x => x.XCoordinate3, "x_coordinate_3").Length(20).Not.Nullable();
            Map(x => x.YCoordinate3, "y_coordinate_3").Length(20).Not.Nullable();
            Map(x => x.XCoordinate4, "x_coordinate_4").Length(20).Not.Nullable();
            Map(x => x.YCoordinate4, "y_coordinate_4").Length(20).Not.Nullable();
            Map(x => x.DeviceId, "device_id").Length(10).Not.Nullable();
            Map(x => x.VersionNo, "version_no").Length(5).Not.Nullable();
            Map(x => x.Comments, "comments").Length(100).Not.Nullable();
            Map(x => x.OperatorId, "operator_id").Length(8).Not.Nullable();
            Map(x => x.AppType, "app_type").Length(10).Not.Nullable();
            Map(x => x.AppVersion, "app_version").Length(10).Not.Nullable();
            Map(x => x.VehicleBarcode, "veh_barcode").Length(20).Not.Nullable();
            Map(x => x.VehicleId, "veh_id").Length(20).Not.Nullable();
            Map(x => x.IsOe, "is_oe").Not.Nullable();
            Map(x => x.IsScannable, "is_scannable").Not.Nullable();
            Map(x => x.SurveyConditionName, "survey_condition_name").Length(25).Not.Nullable();
            Map(x => x.SurveyDamageName, "survey_damage_name").Length(25).Not.Nullable();
            Map(x => x.SurveySilhouetteName, "survey_silhouette_name").Length(25).Not.Nullable();
            Map(x => x.SurveyReference, "survey_reference").Length(150).Not.Nullable();
            Map(x => x.IsDamaged, "is_damaged").Not.Nullable();
            Map(x => x.IsSilhouette, "is_silhouette").Not.Nullable();
        }
    }
}