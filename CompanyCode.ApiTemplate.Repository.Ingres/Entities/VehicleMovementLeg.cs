using System;

using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class VehicleMovementLeg
    {

        public virtual int BookingNo {get; set;}
        public virtual int BookingVehicleNo {get; set;}
        public virtual int VehicleMovementLegId {get; set;}
        public virtual DateTime VehicleAvailableDate {get; set;}
        public virtual DateTime RequiredDeliveryDate {get; set;}
        public virtual string DepotCode {get; set;}
        public virtual string DispatchCode {get; set;}
        public virtual DateTime CriticalDate {get; set;}
        public virtual int IsPriority {get; set;}
        public virtual string CurrentMovementStatusCode {get; set;}
        public virtual string PickupSuburb {get; set;}
        public virtual string PickupState {get; set;}
        public virtual string PickupPointLocationCode {get; set;}
        public virtual string DeliverySuburb {get; set;}
        public virtual string DeliveryState {get; set;}
        public virtual string DeliveryPointLocationCode {get; set;}
        public virtual int IsBackload {get; set;}
        public virtual string ModPartyOprId {get; set;}
        public virtual string ModPartyReason {get; set;}
        public virtual string FleetDistanceRangeCode {get; set;}
        public virtual decimal ActualCost {get; set;}
        public virtual decimal AccruedCost {get; set;}
        public virtual string PickupDispatchAreaId {get; set;}
        public virtual string DeliveryDispatchAreaId {get; set;}
        public virtual int CurrentManifestId {get; set;}
        public virtual string PickupCity {get; set;}
        public virtual string DeliveryCity {get; set;}
        public virtual decimal ActualGstCharge {get; set;}
        public virtual int IsStkHide {get; set;}
        public virtual string PreviousLegStatus {get; set;}
        public virtual DateTime ActualDeliveryDate {get; set;}
        public virtual string PickupDeliveryStatusCode {get; set;}
        public virtual DateTime DriverPickupDate {get; set;}
        public virtual DateTime DriverDeliveryDate {get; set;}
        public virtual int IsLastLeg {get; set;}
        public virtual string DeliveryLocationCode {get; set;}
        public virtual string PickupLocationCode {get; set;}


        protected bool Equals(VehicleMovementLeg other)
        {
            if (other == null)
            {
                return false;
            }

            return BookingNo.Equals(other.BookingNo)
                   && BookingVehicleNo.Equals(other.BookingVehicleNo)
                   && VehicleMovementLegId.Equals(other.VehicleMovementLegId)
                   && VehicleAvailableDate.Equals(other.VehicleAvailableDate)
                   && RequiredDeliveryDate.Equals(other.RequiredDeliveryDate)
                   && DepotCode.Equals(other.DepotCode)
                   && DispatchCode.Equals(other.DispatchCode)
                   && CriticalDate.Equals(other.CriticalDate)
                   && IsPriority.Equals(other.IsPriority)
                   && CurrentMovementStatusCode.Equals(other.CurrentMovementStatusCode)
                   && PickupSuburb.Equals(other.PickupSuburb)
                   && PickupState.Equals(other.PickupState)
                   && PickupPointLocationCode.Equals(other.PickupPointLocationCode)
                   && DeliverySuburb.Equals(other.DeliverySuburb)
                   && DeliveryState.Equals(other.DeliveryState)
                   && DeliveryPointLocationCode.Equals(other.DeliveryPointLocationCode)
                   && IsBackload.Equals(other.IsBackload)
                   && ModPartyOprId.Equals(other.ModPartyOprId)
                   && ModPartyReason.Equals(other.ModPartyReason)
                   && FleetDistanceRangeCode.Equals(other.FleetDistanceRangeCode)
                   && ActualCost.Equals(other.ActualCost)
                   && AccruedCost.Equals(other.AccruedCost)
                   && PickupDispatchAreaId.Equals(other.PickupDispatchAreaId)
                   && DeliveryDispatchAreaId.Equals(other.DeliveryDispatchAreaId)
                   && CurrentManifestId.Equals(other.CurrentManifestId)
                   && PickupCity.Equals(other.PickupCity)
                   && DeliveryCity.Equals(other.DeliveryCity)
                   && ActualGstCharge.Equals(other.ActualGstCharge)
                   && IsStkHide.Equals(other.IsStkHide)
                   && PreviousLegStatus.Equals(other.PreviousLegStatus)
                   && ActualDeliveryDate.Equals(other.ActualDeliveryDate)
                   && PickupDeliveryStatusCode.Equals(other.PickupDeliveryStatusCode)
                   && DriverPickupDate.Equals(other.DriverPickupDate)
                   && DriverDeliveryDate.Equals(other.DriverDeliveryDate)
                   && IsLastLeg.Equals(other.IsLastLeg)
                   && DeliveryLocationCode.Equals(other.DeliveryLocationCode)
                   && PickupLocationCode.Equals(other.PickupLocationCode);
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
                hash = (hash * hashingMultiplier) ^ BookingNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ BookingVehicleNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ VehicleMovementLegId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ VehicleAvailableDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ RequiredDeliveryDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ DepotCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ DispatchCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ CriticalDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsPriority.GetHashCode();
                hash = (hash * hashingMultiplier) ^ CurrentMovementStatusCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ PickupSuburb?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ PickupState?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ PickupPointLocationCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ DeliverySuburb?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ DeliveryState?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ DeliveryPointLocationCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ IsBackload.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ModPartyOprId?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ ModPartyReason?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ FleetDistanceRangeCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ ActualCost.GetHashCode();
                hash = (hash * hashingMultiplier) ^ AccruedCost.GetHashCode();
                hash = (hash * hashingMultiplier) ^ PickupDispatchAreaId?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ DeliveryDispatchAreaId?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ CurrentManifestId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ PickupCity?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ DeliveryCity?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ ActualGstCharge.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsStkHide.GetHashCode();
                hash = (hash * hashingMultiplier) ^ PreviousLegStatus?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ ActualDeliveryDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ PickupDeliveryStatusCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ DriverPickupDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ DriverDeliveryDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsLastLeg.GetHashCode();
                hash = (hash * hashingMultiplier) ^ DeliveryLocationCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ PickupLocationCode?.GetHashCode() ?? 0;
                return hash;
            }
        }
    }

    //	CONSTRAINT VEH_MVT_LEG_PK PRIMARY KEY (cur_manifest_id,bkg_no,bkg_veh_no,veh_mvt_leg_id)
    //);
    //CREATE UNIQUE INDEX veh_mvt_leg_1 ON dba.veh_mvt_leg (cur_manifest_id,bkg_no,bkg_veh_no,veh_mvt_leg_id);
    //CREATE INDEX veh_mvt_leg_2 ON dba.veh_mvt_leg (desp_code,depot_abrv,cur_mvt_status_code,veh_avlb_tms,critical_tms);

    public class VehicleMovementLegMap: ClassMap<VehicleMovementLeg>
    {
        public VehicleMovementLegMap()
        {
            Table("veh_mvt_leg");
            CompositeId()
                .KeyProperty(x => x.CurrentManifestId, keyPropertyAction: k =>
                {
                    k.ColumnName("cur_manifest_id");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
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
                .KeyProperty(x => x.VehicleMovementLegId, keyPropertyAction: k =>
                {
                    k.ColumnName("veh_mvt_leg_id");
                    k.Type(typeof(int));
                    k.Access.Property();
                });

            Map(x => x.BookingNo, "bkg_no").Not.Nullable().Index("veh_mvt_leg_1");
            Map(x => x.BookingVehicleNo, "bkg_veh_no").Not.Nullable().Index("veh_mvt_leg_1");
            Map(x => x.VehicleMovementLegId, "veh_mvt_leg_id").Not.Nullable().Index("veh_mvt_leg_1");
            Map(x => x.VehicleAvailableDate, "veh_avlb_tms").Not.Nullable().Index("veh_mvt_leg_2");
            Map(x => x.RequiredDeliveryDate, "rqr_dlvr_tms").Not.Nullable();
            Map(x => x.DepotCode, "depot_abrv").Length(3).Not.Nullable().Index("veh_mvt_leg_2");
            Map(x => x.DispatchCode, "desp_code").Length(3).Not.Nullable().Index("veh_mvt_leg_2");
            Map(x => x.CriticalDate, "critical_tms").Not.Nullable();
            Map(x => x.IsPriority, "priority_ind").Not.Nullable();
            Map(x => x.CurrentMovementStatusCode, "cur_mvt_status_code").Length(3).Not.Nullable().Index("veh_mvt_leg_2");
            Map(x => x.PickupSuburb, "pkup_suburb").Length(20).Not.Nullable();
            Map(x => x.PickupState, "pkup_state").Length(3).Not.Nullable();
            Map(x => x.PickupPointLocationCode, "pkup_pt_loc_code").Length(3).Not.Nullable();
            Map(x => x.DeliverySuburb, "dlvr_suburb").Length(20).Not.Nullable();
            Map(x => x.DeliveryState, "dlvr_state").Length(3).Not.Nullable();
            Map(x => x.DeliveryPointLocationCode, "dlvr_pt_loc_code").Length(3).Not.Nullable();
            Map(x => x.IsBackload, "backload_ind").Not.Nullable();
            Map(x => x.ModPartyOprId, "mod_prty_opr_id").Length(8).Not.Nullable();
            Map(x => x.ModPartyReason, "mod_prty_reason").Length(20).Not.Nullable();
            Map(x => x.FleetDistanceRangeCode, "fleet_dist_rng_code").Length(3).Not.Nullable();
            Map(x => x.ActualCost, "actual_cost").Not.Nullable();
            Map(x => x.AccruedCost, "accrued_cost").Not.Nullable();
            Map(x => x.PickupDispatchAreaId, "pkup_desp_area_id").Length(10).Not.Nullable();
            Map(x => x.DeliveryDispatchAreaId, "dlvr_desp_area_id").Length(10).Not.Nullable();
            Map(x => x.CurrentManifestId, "cur_manifest_id").Not.Nullable().Index("veh_mvt_leg_1");
            Map(x => x.PickupCity, "pkup_city").Length(20).Not.Nullable();
            Map(x => x.DeliveryCity, "dlvr_city").Length(20).Not.Nullable();
            Map(x => x.ActualGstCharge, "actual_gst_chrg").Not.Nullable();
            Map(x => x.IsStkHide, "stk_hide_ind").Not.Nullable();
            Map(x => x.PreviousLegStatus, "prev_leg_status").Length(3).Not.Nullable();
            Map(x => x.ActualDeliveryDate, "act_dlvr_tms").Not.Nullable();
            Map(x => x.PickupDeliveryStatusCode, "pkup_dlvr_status_code").Length(3).Not.Nullable();
            Map(x => x.DriverPickupDate, "driver_pkup_tms").Not.Nullable();
            Map(x => x.DriverDeliveryDate, "driver_dlvr_tms").Not.Nullable();
            Map(x => x.IsLastLeg, "is_last_leg").Not.Nullable();
            Map(x => x.DeliveryLocationCode, "dlvr_loc_code").Length(3).Not.Nullable();
            Map(x => x.PickupLocationCode, "pkup_loc_code").Length(3).Not.Nullable();
        }
    }
}