using System;

using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class Manifest
    {

        public virtual int ManifestId {get; set;}
        public virtual DateTime CreateDate {get; set;}
        public virtual DateTime DepartDate {get; set;}
        public virtual int MovementDistanceVary {get; set;}
        public virtual DateTime StatusStartDate {get; set;}
        public virtual int IsPayApprove {get; set;}
        public virtual int IsZeroApprove {get; set;}
        public virtual string ApproveDepotCode {get; set;}
        public virtual int IsPaperworkComplete {get; set;}
        public virtual string FleetConfigCode {get; set;}
        public virtual string ManifestStatusCode {get; set;}
        public virtual string PointLocationCode {get; set;}
        public virtual string DepartPointName {get; set;}
        public virtual string DepartPointAreaAddress {get; set;}
        public virtual string DepartPointAreaAddress2 {get; set;}
        public virtual string DepartPointAreaCode {get; set;}
        public virtual string DepartPointAreaClass {get; set;}
        public virtual string DepartPointAreaState {get; set;}
        public virtual string DepartPointAreaPostcode {get; set;}
        public virtual string DepartPointAreaDepotCode {get; set;}
        public virtual int FleetId {get; set;}
        public virtual string ManifestCode {get; set;}
        public virtual string DepotCode {get; set;}
        public virtual string DispatchCode {get; set;}
        public virtual string DelayReasonCode {get; set;}
        public virtual int Capacity {get; set;}
        public virtual float ProfitMargin {get; set;}
        public virtual int LongHaulKmCount {get; set;}
        public virtual int IsLongHaulKmEntered {get; set;}
        public virtual int IsManifestNote {get; set;}
        public virtual int IsManifestProfitNote {get; set;}
        public virtual int IsMiscCost {get; set;}
        public virtual int DriverPartyId {get; set;}
        public virtual decimal CurrentActualLongHaulCost {get; set;}
        public virtual decimal CurrentCalculateLongHaulCost {get; set;}
        public virtual decimal TotalManifestCost {get; set;}
        public virtual int ExtractWeek {get; set;}
        public virtual decimal TotalManifestRev {get; set;}
        public virtual decimal LongHaulGstCharge {get; set;}
        public virtual float ManifestHours {get; set;}
        public virtual int AccountCustomerNo {get; set;}
        public virtual string RouteReference {get; set;}
        public virtual string ServiceCode {get; set;}
        public virtual string RateGroupCode {get; set;}
        public virtual string ManifestReference {get; set;}
        public virtual string OperatorId {get; set;}
        public virtual int IsXdock {get; set;}
        public virtual string TrailerNo {get; set;}
        public virtual string VehicleRegoNo {get; set;}
        public virtual int IsMilkrun {get; set;}
        public virtual int FleetSeqNo {get; set;}
        public virtual DateTime SysEta {get; set;}
        public virtual decimal QuotedCharge {get; set;}
        public virtual decimal QuotedCustomerCharge {get; set;}
        public virtual int LoadId {get; set;}
        public virtual int DockNo {get; set;}
        public virtual string RunName {get; set;}
        public virtual string DriverName {get; set;}
        public virtual DateTime RevisedEta {get; set;}
        public virtual int IsGroupManifest {get; set;}
        public virtual string GLSCode {get; set;}
        public virtual decimal StandardCost {get; set;}
        public virtual DateTime TargetArrivalDate {get; set;}
        public virtual DateTime TargetDepartDate {get; set;}
        public virtual int IsCg {get; set;}
        public virtual int IsQuickManifest {get; set;}
        public virtual string TrigStatusCode {get; set;}
        public virtual decimal FSCCost {get; set;}
        public virtual float FSCPercent {get; set;}
        public virtual float ManifestKms {get; set;}
        public virtual int KmsTravelled {get; set;}
        public virtual string HoursWorked {get; set;}
        public virtual string CategoryCode {get; set;}
        public virtual string ManifestMovementCode {get; set;}
        public virtual DateTime DriverStartDate {get; set;}
        public virtual DateTime DriverCompleteDate {get; set;}
}

    public class ManifestMap: ClassMap<Manifest> 
    {
        public ManifestMap()
        {
            Table("manifest");
            Id(x => x.ManifestId, "manifest_id").Access.Property().GeneratedBy.Assigned().Index("manifest_1").Index("manifest_2").Index("manifest_6").Index("manifest_7");
            Map(x => x.CreateDate, "create_tms").Not.Nullable().Index("manifest_6");
            Map(x => x.DepartDate, "depart_tms").Not.Nullable().Index("manifest_2");
            Map(x => x.MovementDistanceVary, "mvt_dist_vary").Not.Nullable();
            Map(x => x.StatusStartDate, "status_start_tms").Not.Nullable();
            Map(x => x.IsPayApprove, "pay_approve_ind").Not.Nullable().Index("manifest_3").Index("manifest_5");
            Map(x => x.IsZeroApprove, "zero_approve_ind").Not.Nullable();
            Map(x => x.ApproveDepotCode, "approve_depot_abrv").Length(3).Not.Nullable().Index("manifest_5");
            Map(x => x.IsPaperworkComplete, "paperwork_complete_ind").Not.Nullable();
            Map(x => x.FleetConfigCode, "fleet_cnfg_code").Length(3).Not.Nullable();
            Map(x => x.ManifestStatusCode, "mft_status_code").Length(3).Not.Nullable().Index("manifest_1").Index("manifest_3").Index("manifest_4").Index("manifest_5").Index("manifest_7");
            Map(x => x.PointLocationCode, "pt_loc_code").Length(3).Not.Nullable();
            Map(x => x.DepartPointName, "depart_pt_name").Length(30).Not.Nullable();
            Map(x => x.DepartPointAreaAddress, "depart_pt_area_addr").Length(30).Not.Nullable();
            Map(x => x.DepartPointAreaAddress2, "depart_pt_area_addr_2").Length(30).Not.Nullable();
            Map(x => x.DepartPointAreaCode, "depart_pt_area_code").Length(20).Not.Nullable();
            Map(x => x.DepartPointAreaClass, "depart_pt_area_class").Length(3).Not.Nullable();
            Map(x => x.DepartPointAreaState, "depart_pt_area_state").Length(3).Not.Nullable();
            Map(x => x.DepartPointAreaPostcode, "depart_pt_area_postcode").Length(4).Not.Nullable();
            Map(x => x.DepartPointAreaDepotCode, "depart_pt_area_depot_abrv").Length(3).Not.Nullable();
            Map(x => x.FleetId, "fleet_id").Not.Nullable().Index("manifest_1").Index("manifest_3");
            Map(x => x.ManifestCode, "mft_code").Length(3).Not.Nullable();
            Map(x => x.DepotCode, "depot_abrv").Length(3).Not.Nullable().Index("manifest_3").Index("manifest_4");
            Map(x => x.DispatchCode, "desp_code").Length(3).Not.Nullable().Index("manifest_3");
            Map(x => x.DelayReasonCode, "delay_reason_code").Length(3).Not.Nullable();
            Map(x => x.Capacity, "capacity").Not.Nullable();
            Map(x => x.ProfitMargin, "profit_margin").Not.Nullable();
            Map(x => x.LongHaulKmCount, "lhl_km_count").Not.Nullable();
            Map(x => x.IsLongHaulKmEntered, "lhl_km_entered_ind").Not.Nullable();
            Map(x => x.IsManifestNote, "mft_note_ind").Not.Nullable();
            Map(x => x.IsManifestProfitNote, "mft_profit_note_ind").Not.Nullable();
            Map(x => x.IsMiscCost, "misc_cost_ind").Not.Nullable();
            Map(x => x.DriverPartyId, "driver_party_id").Not.Nullable().Index("manifest_7");
            Map(x => x.CurrentActualLongHaulCost, "cur_act_lhl_cost").Not.Nullable();
            Map(x => x.CurrentCalculateLongHaulCost, "cur_calc_lhl_cost").Not.Nullable();
            Map(x => x.TotalManifestCost, "tot_mft_cost").Not.Nullable();
            Map(x => x.ExtractWeek, "extract_wk").Not.Nullable();
            Map(x => x.TotalManifestRev, "tot_mft_rev").Not.Nullable();
            Map(x => x.LongHaulGstCharge, "lhl_gst_chrg").Not.Nullable();
            Map(x => x.ManifestHours, "mft_hrs").Not.Nullable();
            Map(x => x.AccountCustomerNo, "acc_cus_no").Not.Nullable();
            Map(x => x.RouteReference, "route_ref").Length(15).Not.Nullable();
            Map(x => x.ServiceCode, "service_code").Length(3).Not.Nullable();
            Map(x => x.RateGroupCode, "rate_group_code").Length(3).Not.Nullable();
            Map(x => x.ManifestReference, "mft_ref").Length(15).Not.Nullable().Index("manifest_8");
            Map(x => x.OperatorId, "operator_id").Length(8).Not.Nullable();
            Map(x => x.IsXdock, "xdock_ind").Not.Nullable();
            Map(x => x.TrailerNo, "trailer_no").Length(15).Not.Nullable();
            Map(x => x.VehicleRegoNo, "veh_rego_no").Length(30).Not.Nullable();
            Map(x => x.IsMilkrun, "milkrun_ind").Not.Nullable();
            Map(x => x.FleetSeqNo, "fleet_seq_no").Not.Nullable();
            Map(x => x.SysEta, "sys_eta").Not.Nullable();
            Map(x => x.QuotedCharge, "quoted_charge").Not.Nullable();
            Map(x => x.QuotedCustomerCharge, "quoted_cus_charge").Not.Nullable();
            Map(x => x.LoadId, "load_id").Not.Nullable();
            Map(x => x.DockNo, "dock_no").Not.Nullable();
            Map(x => x.RunName, "run_name").Length(15).Not.Nullable();
            Map(x => x.DriverName, "driver_name").Length(30).Not.Nullable();
            Map(x => x.RevisedEta, "revised_eta").Not.Nullable();
            Map(x => x.IsGroupManifest, "grp_mft_ind").Not.Nullable();
            Map(x => x.GLSCode, "gls_code").Length(3).Not.Nullable();
            Map(x => x.StandardCost, "std_cost").Not.Nullable();
            Map(x => x.TargetArrivalDate, "target_arrival_tms").Not.Nullable();
            Map(x => x.TargetDepartDate, "target_depart_tms").Not.Nullable();
            Map(x => x.IsCg, "cg_ind").Not.Nullable();
            Map(x => x.IsQuickManifest, "quick_mft_ind").Not.Nullable();
            Map(x => x.TrigStatusCode, "trig_status_code").Length(3).Not.Nullable();
            Map(x => x.FSCCost, "fsc_cost").Not.Nullable();
            Map(x => x.FSCPercent, "fsc_percent").Not.Nullable();
            Map(x => x.ManifestKms, "mft_kms").Not.Nullable();
            Map(x => x.KmsTravelled, "kms_travelled").Not.Nullable();
            Map(x => x.HoursWorked, "hrs_worked").Length(20).Not.Nullable();
            Map(x => x.CategoryCode, "category_code").Length(3).Not.Nullable();
            Map(x => x.ManifestMovementCode, "mft_mvt_code").Length(3).Not.Nullable();
            Map(x => x.DriverStartDate, "driver_start_tms").Not.Nullable();
            Map(x => x.DriverCompleteDate, "driver_complete_tms").Not.Nullable();
        }
    }
}