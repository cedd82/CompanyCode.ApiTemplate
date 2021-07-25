using System;

using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class BookingVehicle
    {

        public virtual int BookingNo {get; set;}
        public virtual int BookingVehicleNo {get; set;}
        public virtual int IsExec {get; set;}
        public virtual decimal EstimatedMovementCost {get; set;}
        public virtual decimal ActualLongHaulCharge {get; set;}
        public virtual decimal ActualInsCharge {get; set;}
        public virtual decimal CalculateLongHaulCharge {get; set;}
        public virtual decimal CalculateInsCharge {get; set;}
        public virtual decimal CalculateFuelSurchrg {get; set;}
        public virtual decimal TotalMiscCharge {get; set;}
        public virtual decimal VehicleValue {get; set;}
        public virtual int IsDriveable {get; set;}
        public virtual string OtherId {get; set;}
        public virtual string VehicleId {get; set;}
        public virtual int VehicleCode {get; set;}
        public virtual int ModelCode {get; set;}
        public virtual string RateCode {get; set;}
        public virtual string RateRouteCode {get; set;}
        public virtual string DepotCode1 {get; set;}
        public virtual string DepotCode2 {get; set;}
        public virtual string DistanceRangeCode {get; set;}
        public virtual int IsDisc {get; set;}
        public virtual string BookingVehicleStatusCode {get; set;}
        public virtual int IsNilExcessIns {get; set;}
        public virtual int DamageId {get; set;}
        public virtual decimal GstCharge {get; set;}
        public virtual DateTime RevisedDeliveryDate {get; set;}
        public virtual int FleetId {get; set;}
        public virtual string ClientVehicleId {get; set;}
        public virtual string ClientModelCode {get; set;}
        public virtual decimal ClientVehicleCost {get; set;}
        public virtual int CustModelCode {get; set;}
        public virtual int CustVehicleCode {get; set;}
        public virtual int IsAgentPickup {get; set;}
        public virtual string VehicleColour {get; set;}
        public virtual int IsActualVin {get; set;}
        public virtual string ShipName {get; set;}
        public virtual int WharfManifestId {get; set;}
        public virtual int DeliveryTimeSlot {get; set;}
        public virtual int IsMessageSent {get; set;}
        public virtual string VehicleBarcode {get; set;}
        public virtual string VcmsLocationName {get; set;}
        public virtual int VcmsLocationSeqNo {get; set;}
        public virtual int IsOeSurvey {get; set;}
        public virtual int OePickupScan {get; set;}
        public virtual string OeSurveyType {get; set;}
        public virtual int IsOe {get; set;}
        public virtual int IsScannable {get; set;}
        public virtual string SurveyConditionName {get; set;}
        public virtual string SurveyDamageName {get; set;}
        public virtual int IsSilhouette {get; set;}
        public virtual string SurveySilhouetteName {get; set;}
        public virtual string StatusCode {get; set;}
        public virtual DateTime UpdateTime {get; set;}
        public virtual int IsDamaged {get; set;}
        public virtual DateTime ActualPickupDate {get; set;}
        public virtual DateTime ActualDeliveryDate {get; set;}
        public virtual string UpdateBy {get; set;}
        public virtual DateTime ActualPickupDepartDate {get; set;}

        protected bool Equals(BookingVehicle other)
        {
            if (other == null)
            {
                return false;
            }

            return BookingNo.Equals(other.BookingNo)
                   && BookingVehicleNo.Equals(other.BookingVehicleNo)
                   && IsExec.Equals(other.IsExec)
                   && EstimatedMovementCost.Equals(other.EstimatedMovementCost)
                   && ActualLongHaulCharge.Equals(other.ActualLongHaulCharge)
                   && ActualInsCharge.Equals(other.ActualInsCharge)
                   && CalculateLongHaulCharge.Equals(other.CalculateLongHaulCharge)
                   && CalculateInsCharge.Equals(other.CalculateInsCharge)
                   && CalculateFuelSurchrg.Equals(other.CalculateFuelSurchrg)
                   && TotalMiscCharge.Equals(other.TotalMiscCharge)
                   && VehicleValue.Equals(other.VehicleValue)
                   && IsDriveable.Equals(other.IsDriveable)
                   && OtherId.Equals(other.OtherId)
                   && VehicleId.Equals(other.VehicleId)
                   && VehicleCode.Equals(other.VehicleCode)
                   && ModelCode.Equals(other.ModelCode)
                   && RateCode.Equals(other.RateCode)
                   && RateRouteCode.Equals(other.RateRouteCode)
                   && DepotCode1.Equals(other.DepotCode1)
                   && DepotCode2.Equals(other.DepotCode2)
                   && DistanceRangeCode.Equals(other.DistanceRangeCode)
                   && IsDisc.Equals(other.IsDisc)
                   && BookingVehicleStatusCode.Equals(other.BookingVehicleStatusCode)
                   && IsNilExcessIns.Equals(other.IsNilExcessIns)
                   && DamageId.Equals(other.DamageId)
                   && GstCharge.Equals(other.GstCharge)
                   && RevisedDeliveryDate.Equals(other.RevisedDeliveryDate)
                   && FleetId.Equals(other.FleetId)
                   && ClientVehicleId.Equals(other.ClientVehicleId)
                   && ClientModelCode.Equals(other.ClientModelCode)
                   && ClientVehicleCost.Equals(other.ClientVehicleCost)
                   && CustModelCode.Equals(other.CustModelCode)
                   && CustVehicleCode.Equals(other.CustVehicleCode)
                   && IsAgentPickup.Equals(other.IsAgentPickup)
                   && VehicleColour.Equals(other.VehicleColour)
                   && IsActualVin.Equals(other.IsActualVin)
                   && ShipName.Equals(other.ShipName)
                   && WharfManifestId.Equals(other.WharfManifestId)
                   && DeliveryTimeSlot.Equals(other.DeliveryTimeSlot)
                   && IsMessageSent.Equals(other.IsMessageSent)
                   && VehicleBarcode.Equals(other.VehicleBarcode)
                   && VcmsLocationName.Equals(other.VcmsLocationName)
                   && VcmsLocationSeqNo.Equals(other.VcmsLocationSeqNo)
                   && IsOeSurvey.Equals(other.IsOeSurvey)
                   && OePickupScan.Equals(other.OePickupScan)
                   && IsOe.Equals(other.IsOe)
                   && IsScannable.Equals(other.IsScannable)
                   && SurveyConditionName.Equals(other.SurveyConditionName)
                   && SurveyDamageName.Equals(other.SurveyDamageName)
                   && IsSilhouette.Equals(other.IsSilhouette)
                   && SurveySilhouetteName.Equals(other.SurveySilhouetteName)
                   && StatusCode.Equals(other.StatusCode)
                   && UpdateTime.Equals(other.UpdateTime)
                   && IsDamaged.Equals(other.IsDamaged)
                   && ActualPickupDate.Equals(other.ActualPickupDate)
                   && ActualDeliveryDate.Equals(other.ActualDeliveryDate)
                   && UpdateBy.Equals(other.UpdateBy)
                   && ActualPickupDepartDate.Equals(other.ActualPickupDepartDate);
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
            if (obj.GetType() != typeof (BookingVehicle))
            {
                return false;
            }
            return Equals((BookingVehicle) obj);
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
                hash = (hash * hashingMultiplier) ^ IsExec.GetHashCode();
                hash = (hash * hashingMultiplier) ^ EstimatedMovementCost.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ActualLongHaulCharge.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ActualInsCharge.GetHashCode();
                hash = (hash * hashingMultiplier) ^ CalculateLongHaulCharge.GetHashCode();
                hash = (hash * hashingMultiplier) ^ CalculateInsCharge.GetHashCode();
                hash = (hash * hashingMultiplier) ^ CalculateFuelSurchrg.GetHashCode();
                hash = (hash * hashingMultiplier) ^ TotalMiscCharge.GetHashCode();
                hash = (hash * hashingMultiplier) ^ VehicleValue.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsDriveable.GetHashCode();
                hash = (hash * hashingMultiplier) ^ OtherId?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ VehicleId?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ VehicleCode.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ModelCode.GetHashCode();
                hash = (hash * hashingMultiplier) ^ RateCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ RateRouteCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ DepotCode1?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ DepotCode2?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ DistanceRangeCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ IsDisc.GetHashCode();
                hash = (hash * hashingMultiplier) ^ BookingVehicleStatusCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ IsNilExcessIns.GetHashCode();
                hash = (hash * hashingMultiplier) ^ DamageId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ GstCharge.GetHashCode();
                hash = (hash * hashingMultiplier) ^ RevisedDeliveryDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ FleetId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ClientVehicleId?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ ClientModelCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ ClientVehicleCost.GetHashCode();
                hash = (hash * hashingMultiplier) ^ CustModelCode.GetHashCode();
                hash = (hash * hashingMultiplier) ^ CustVehicleCode.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsAgentPickup.GetHashCode();
                hash = (hash * hashingMultiplier) ^ VehicleColour?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ IsActualVin.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ShipName?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ WharfManifestId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ DeliveryTimeSlot.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsMessageSent.GetHashCode();
                hash = (hash * hashingMultiplier) ^ VehicleBarcode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ VcmsLocationName?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ VcmsLocationSeqNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsOeSurvey.GetHashCode();
                hash = (hash * hashingMultiplier) ^ OePickupScan.GetHashCode();
                hash = (hash * hashingMultiplier) ^ OeSurveyType?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ IsOe.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsScannable.GetHashCode();
                hash = (hash * hashingMultiplier) ^ SurveyConditionName?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ SurveyDamageName?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ IsSilhouette.GetHashCode();
                hash = (hash * hashingMultiplier) ^ SurveySilhouetteName?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ StatusCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ UpdateTime.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsDamaged.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ActualPickupDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ActualDeliveryDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ UpdateBy?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ ActualPickupDepartDate.GetHashCode();
                return hash;
            }
        }
    }

    public class BookingVehicleMap: ClassMap<BookingVehicle>
    {
        public BookingVehicleMap()
        {
            Table("bkg_veh");
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
            
            Map(x => x.BookingNo, "bkg_no").Not.Nullable().Index("bkg_veh_1").Index("bkg_veh_2").Index("bkg_veh_3");
            Map(x => x.BookingVehicleNo, "bkg_veh_no").Not.Nullable();
            Map(x => x.IsExec, "exec_ind").Not.Nullable();
            Map(x => x.EstimatedMovementCost, "est_mvt_cost").Not.Nullable();
            Map(x => x.ActualLongHaulCharge, "act_lhl_chrg").Not.Nullable();
            Map(x => x.ActualInsCharge, "act_ins_chrg").Not.Nullable();
            Map(x => x.CalculateLongHaulCharge, "calc_lhl_chrg").Not.Nullable();
            Map(x => x.CalculateInsCharge, "calc_ins_chrg").Not.Nullable();
            Map(x => x.CalculateFuelSurchrg, "calc_fuel_surchrg").Not.Nullable();
            Map(x => x.TotalMiscCharge, "tot_misc_chrg").Not.Nullable();
            Map(x => x.VehicleValue, "veh_value").Not.Nullable();
            Map(x => x.IsDriveable, "driveable_ind").Not.Nullable();
            Map(x => x.OtherId, "other_id").Length(20).Not.Nullable().Index("bkg_veh_2");
            Map(x => x.VehicleId, "veh_id").Length(20).Not.Nullable();
            Map(x => x.VehicleCode, "veh_code").Not.Nullable();
            Map(x => x.ModelCode, "model_code").Not.Nullable();
            Map(x => x.RateCode, "rate_code").Length(3).Not.Nullable();
            Map(x => x.RateRouteCode, "rate_route_code").Length(3).Not.Nullable();
            Map(x => x.DepotCode1, "depot_abrv1").Length(3).Not.Nullable();
            Map(x => x.DepotCode2, "depot_abrv2").Length(3).Not.Nullable();
            Map(x => x.DistanceRangeCode, "dist_rng_code").Length(3).Not.Nullable();
            Map(x => x.IsDisc, "disc_ind").Not.Nullable();
            Map(x => x.BookingVehicleStatusCode, "bkg_veh_status_code").Length(3).Not.Nullable();
            Map(x => x.IsNilExcessIns, "nil_excess_ins_ind").Not.Nullable();
            Map(x => x.DamageId, "dmg_id").Not.Nullable();
            Map(x => x.GstCharge, "gst_chrg").Not.Nullable();
            Map(x => x.RevisedDeliveryDate, "revised_dlvr_date").Not.Nullable();
            Map(x => x.FleetId, "fleet_id").Not.Nullable();
            Map(x => x.ClientVehicleId, "client_veh_id").Length(20).Not.Nullable().Index("bkg_veh_1");;
            Map(x => x.ClientModelCode, "client_model_code").Length(16).Not.Nullable();
            Map(x => x.ClientVehicleCost, "client_veh_cost").Not.Nullable();
            Map(x => x.CustModelCode, "cust_model_code").Not.Nullable();
            Map(x => x.CustVehicleCode, "cust_veh_code").Not.Nullable();
            Map(x => x.IsAgentPickup, "agent_pickup_ind").Not.Nullable();
            Map(x => x.VehicleColour, "veh_colour").Length(20).Not.Nullable();
            Map(x => x.IsActualVin, "actual_vin_ind").Not.Nullable();
            Map(x => x.ShipName, "ship_name").Length(20).Not.Nullable();
            Map(x => x.WharfManifestId, "whf_manifest_id").Not.Nullable();
            Map(x => x.DeliveryTimeSlot, "dlvr_time_slot").Not.Nullable();
            Map(x => x.IsMessageSent, "msg_sent_ind").Not.Nullable();
            Map(x => x.VehicleBarcode, "veh_barcode").Length(20).Not.Nullable().Index("bkg_veh_3");;
            Map(x => x.VcmsLocationName, "vcms_locn_name").Length(50).Not.Nullable();
            Map(x => x.VcmsLocationSeqNo, "vcms_locn_seq_no").Not.Nullable();
            Map(x => x.IsOeSurvey, "oe_survey_ind").Not.Nullable();
            Map(x => x.OePickupScan, "oe_pickup_scan").Not.Nullable();
            Map(x => x.OeSurveyType, "oe_survey_type").Length(5).Not.Nullable();
            Map(x => x.IsOe, "is_oe").Not.Nullable();
            Map(x => x.IsScannable, "is_scannable").Not.Nullable();
            Map(x => x.SurveyConditionName, "survey_condition_name").Length(25).Not.Nullable();
            Map(x => x.SurveyDamageName, "survey_damage_name").Length(25).Not.Nullable();
            Map(x => x.IsSilhouette, "is_silhouette").Not.Nullable();
            Map(x => x.SurveySilhouetteName, "survey_silhouette_name").Length(25).Not.Nullable();
            Map(x => x.StatusCode, "status_code").Length(3).Not.Nullable();
            Map(x => x.UpdateTime, "update_tms").Not.Nullable();
            Map(x => x.IsDamaged, "damaged_ind").Not.Nullable();
            Map(x => x.ActualPickupDate, "actual_pkup_date").Not.Nullable();
            Map(x => x.ActualDeliveryDate, "actual_dlvr_date").Not.Nullable();
            Map(x => x.UpdateBy, "update_by").Length(8).Not.Nullable();
            Map(x => x.ActualPickupDepartDate, "actual_pkup_depart_date").Not.Nullable();
        }
    }
}

//CREATE TABLE dba.bkg_veh (
//	bkg_no INTEGER NOT NULL,
//	bkg_veh_no INTEGER NOT NULL,
//	exec_ind INTEGER NOT NULL,
//	est_mvt_cost MONEY NOT NULL,
//	act_lhl_chrg MONEY NOT NULL,
//	act_ins_chrg MONEY NOT NULL,
//	calc_lhl_chrg MONEY NOT NULL,
//	calc_ins_chrg MONEY NOT NULL,
//	calc_fuel_surchrg MONEY NOT NULL,
//	tot_misc_chrg MONEY NOT NULL,
//	veh_value MONEY NOT NULL,
//	driveable_ind INTEGER NOT NULL,
//	other_id VARCHAR(20) NOT NULL,
//	veh_id VARCHAR(20) NOT NULL,
//	veh_code INTEGER NOT NULL,
//	model_code INTEGER NOT NULL,
//	rate_code CHAR(3) NOT NULL,
//	rate_route_code CHAR(3) NOT NULL,
//	depot_abrv1 CHAR(3) NOT NULL,
//	depot_abrv2 CHAR(3) NOT NULL,
//	dist_rng_code CHAR(3) NOT NULL,
//	disc_ind INTEGER NOT NULL,
//	bkg_veh_status_code CHAR(3) NOT NULL,
//	nil_excess_ins_ind INTEGER NOT NULL,
//	dmg_id INTEGER NOT NULL,
//	gst_chrg MONEY NOT NULL,
//	revised_dlvr_date INGRESDATE NOT NULL,
//	fleet_id INTEGER NOT NULL,
//	client_veh_id VARCHAR(20) NOT NULL,
//	client_model_code VARCHAR(16) NOT NULL,
//	client_veh_cost MONEY NOT NULL,
//	cust_model_code INTEGER NOT NULL,
//	cust_veh_code INTEGER NOT NULL,
//	agent_pickup_ind INTEGER NOT NULL,
//	veh_colour VARCHAR(20) NOT NULL,
//	actual_vin_ind INTEGER NOT NULL,
//	ship_name VARCHAR(20) NOT NULL,
//	whf_manifest_id INTEGER NOT NULL,
//	dlvr_time_slot INTEGER NOT NULL,
//	msg_sent_ind INTEGER NOT NULL,
//	veh_barcode VARCHAR(20) NOT NULL,
//	vcms_locn_name VARCHAR(50) NOT NULL,
//	vcms_locn_seq_no INTEGER NOT NULL,
//	oe_survey_ind INTEGER NOT NULL,
//	oe_pickup_scan INTEGER NOT NULL,
//	oe_survey_type CHAR(5) NOT NULL,
//	is_oe INTEGER NOT NULL,
//	is_scannable INTEGER NOT NULL,
//	survey_condition_name VARCHAR(25) NOT NULL,
//	survey_damage_name VARCHAR(25) NOT NULL,
//	is_silhouette INTEGER NOT NULL,
//	survey_silhouette_name VARCHAR(25) NOT NULL,
//	status_code CHAR(3) NOT NULL,
//	update_tms INGRESDATE NOT NULL,
//	damaged_ind INTEGER NOT NULL,
//	actual_pkup_date INGRESDATE NOT NULL,
//	actual_dlvr_date INGRESDATE NOT NULL,
//	update_by CHAR(8) NOT NULL,
//	actual_pkup_depart_date INGRESDATE NOT NULL
//	CONSTRAINT BKG_VEH_PK PRIMARY KEY (bkg_no,bkg_veh_no)
//);
//CREATE INDEX bkg_veh_1 ON dba.bkg_veh (veh_id,bkg_no);
//CREATE INDEX bkg_veh_2 ON dba.bkg_veh (other_id,bkg_no);
//CREATE INDEX bkg_veh_3 ON dba.bkg_veh (veh_barcode,bkg_no);
