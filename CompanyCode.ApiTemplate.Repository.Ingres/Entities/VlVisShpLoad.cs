using System;

using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class VlVisShpLoad
    {

        public virtual string VinNo {get; set;}
        public virtual string ShipName {get; set;}
        public virtual string CustCode {get; set;}
        public virtual string StateCode {get; set;}
        public virtual string PortName {get; set;}
        public virtual string ModelManCode {get; set;}
        public virtual string ModelDesc {get; set;}
        public virtual string VehicleType {get; set;}
        public virtual string Color {get; set;}
        public virtual int StockNo {get; set;}
        public virtual int CaseNo {get; set;}
        public virtual string VoyageNo {get; set;}
        public virtual DateTime SchdArrivalDate {get; set;}
        public virtual string DealerCode {get; set;}
        public virtual string VehicleStatusCode {get; set;}
        public virtual int IsDirectDelivery {get; set;}
        public virtual DateTime VehicleCutOffDate {get; set;}
        public virtual DateTime ActualArrivalDate {get; set;}
        public virtual DateTime AvailableDate {get; set;}
        public virtual int AccountCustomerNo {get; set;}
        public virtual int MakeCode {get; set;}
        public virtual int ModelCode {get; set;}
        public virtual int VehicleCode {get; set;}
        public virtual int IsVehicleSwap {get; set;}
        public virtual string VinStatusCode {get; set;}
        public virtual string DepotCode {get; set;}
        public virtual DateTime LoadDate {get; set;}
        public virtual DateTime UpdateDate {get; set;}
        public virtual int IsLogDelete {get; set;}
        public virtual string CustomerModelDesc {get; set;}
        public virtual int ItemId {get; set;}
        public virtual string Lplate {get; set;}
        public virtual int VoyageId {get; set;}
        public virtual string VehicleStatusCodeOriginal {get; set;}
        public virtual int DirectDeliveryIsOriginal {get; set;}
        public virtual int BookingNo {get; set;}
        public virtual int BookingVehicleNo {get; set;}
        public virtual int ManifestId {get; set;}
        public virtual string ScanVinNo {get; set;}
        public virtual string StockStatus {get; set;}
        public virtual string OrderStatus {get; set;}
        public virtual string Reference {get; set;}
        public virtual int LoadId {get; set;}
        public virtual DateTime DeliveryDate {get; set;}
        public virtual int OrderId {get; set;}
        public virtual string WhCode {get; set;}
        public virtual DateTime LastWashDate {get; set;}
        public virtual int TotalWashes {get; set;}
        public virtual int IsScanned {get; set;}
        public virtual DateTime ScannedDate {get; set;}
        public virtual string ScannedBy {get; set;}
        public virtual string VehicleId {get; set;}
        public virtual int BookingAccountCustomerNo {get; set;}
        public virtual int IsHold {get; set;}
        public virtual string PickupLocationCode {get; set;}
        public virtual DateTime StorEndDate {get; set;}
        public virtual DateTime StorStartDate {get; set;}
        public virtual string Instructions {get; set;}
        public virtual int IsStock {get; set;}
        public virtual string DamageCode {get; set;}
        public virtual int PutLocationId {get; set;}
        public virtual int LocationId {get; set;}
        public virtual DateTime ShpAvailableDate {get; set;}
        public virtual string VehicleBarcode {get; set;}
        public virtual int VlAccountCustomerNo {get; set;}
        public virtual string InvoiceAccountType {get; set;}
        public virtual string OeSurveyType {get; set;}
        public virtual DateTime VehicleAvailableDate {get; set;}
        public virtual int IsDow {get; set;}
        public virtual string LoadReferenceNo {get; set;}
        public virtual int IsXdock {get; set;}
        public virtual int IsOriginalDirectDelivery {get; set;}
        public virtual int IsTransit {get; set;}
        public virtual DateTime LastInspDate {get; set;}
        public virtual int IsDewholesale {get; set;}
        public virtual int IsStorage {get; set;}
        public virtual int IsExtract {get; set;}
        public virtual DateTime ExtractDate {get; set;}
        public virtual string CustomerAlias {get; set;}
        public virtual string MakeName {get; set;}
        public virtual string ModelName {get; set;}
        public virtual string VehicleTypeName {get; set;}
        public virtual string SurveyCode {get; set;}
        public virtual string VehicleSurveyInspectionCode {get; set;}
        public virtual DateTime ExpVehicleAvailableDate {get; set;}
        public virtual string DeliveryCode {get; set;}
        public virtual string LocationName {get; set;}
        public virtual int LocationSeqNo {get; set;}
        public virtual DateTime CreateDate {get; set;}
        public virtual string ParentWhCode {get; set;}
        public virtual string SecondaryWhCode {get; set;}
        public virtual int VesselId {get; set;}
        public virtual string OriginalDealerCode {get; set;}
        public virtual string ProcessCode {get; set;}

         protected bool Equals(VlVisShpLoad other)
        {
            if (other == null)
            {
                return false;
            }

            return VinNo.Equals(other.VinNo)
                && ShipName.Equals(other.ShipName)
                && CustCode.Equals(other.CustCode)
                && StateCode.Equals(other.StateCode)
                && PortName.Equals(other.PortName)
                && ModelManCode.Equals(other.ModelManCode)
                && ModelDesc.Equals(other.ModelDesc)
                && VehicleType.Equals(other.VehicleType)
                && Color.Equals(other.Color)
                && StockNo.Equals(other.StockNo)
                && CaseNo.Equals(other.CaseNo)
                && VoyageNo.Equals(other.VoyageNo)
                && SchdArrivalDate.Equals(other.SchdArrivalDate)
                && DealerCode.Equals(other.DealerCode)
                && VehicleStatusCode.Equals(other.VehicleStatusCode)
                && IsDirectDelivery.Equals(other.IsDirectDelivery)
                && VehicleCutOffDate.Equals(other.VehicleCutOffDate)
                && ActualArrivalDate.Equals(other.ActualArrivalDate)
                && AvailableDate.Equals(other.AvailableDate)
                && AccountCustomerNo.Equals(other.AccountCustomerNo)
                && MakeCode.Equals(other.MakeCode)
                && ModelCode.Equals(other.ModelCode)
                && VehicleCode.Equals(other.VehicleCode)
                && IsVehicleSwap.Equals(other.IsVehicleSwap)
                && VinStatusCode.Equals(other.VinStatusCode)
                && DepotCode.Equals(other.DepotCode)
                && LoadDate.Equals(other.LoadDate)
                && UpdateDate.Equals(other.UpdateDate)
                && IsLogDelete.Equals(other.IsLogDelete)
                && CustomerModelDesc.Equals(other.CustomerModelDesc)
                && ItemId.Equals(other.ItemId)
                && Lplate.Equals(other.Lplate)
                && VoyageId.Equals(other.VoyageId)
                && VehicleStatusCodeOriginal.Equals(other.VehicleStatusCodeOriginal)
                && DirectDeliveryIsOriginal.Equals(other.DirectDeliveryIsOriginal)
                && BookingNo.Equals(other.BookingNo)
                && BookingVehicleNo.Equals(other.BookingVehicleNo)
                && ManifestId.Equals(other.ManifestId)
                && ScanVinNo.Equals(other.ScanVinNo)
                && StockStatus.Equals(other.StockStatus)
                && OrderStatus.Equals(other.OrderStatus)
                && Reference.Equals(other.Reference)
                && LoadId.Equals(other.LoadId)
                && DeliveryDate.Equals(other.DeliveryDate)
                && OrderId.Equals(other.OrderId)
                && WhCode.Equals(other.WhCode)
                && LastWashDate.Equals(other.LastWashDate)
                && TotalWashes.Equals(other.TotalWashes)
                && IsScanned.Equals(other.IsScanned)
                && ScannedDate.Equals(other.ScannedDate)
                && ScannedBy.Equals(other.ScannedBy)
                && VehicleId.Equals(other.VehicleId)
                && BookingAccountCustomerNo.Equals(other.BookingAccountCustomerNo)
                && IsHold.Equals(other.IsHold)
                && PickupLocationCode.Equals(other.PickupLocationCode)
                && StorEndDate.Equals(other.StorEndDate)
                && StorStartDate.Equals(other.StorStartDate)
                && Instructions.Equals(other.Instructions)
                && IsStock.Equals(other.IsStock)
                && DamageCode.Equals(other.DamageCode)
                && PutLocationId.Equals(other.PutLocationId)
                && LocationId.Equals(other.LocationId)
                && ShpAvailableDate.Equals(other.ShpAvailableDate)
                && VehicleBarcode.Equals(other.VehicleBarcode)
                && VlAccountCustomerNo.Equals(other.VlAccountCustomerNo)
                && InvoiceAccountType.Equals(other.InvoiceAccountType)
                && OeSurveyType.Equals(other.OeSurveyType)
                && VehicleAvailableDate.Equals(other.VehicleAvailableDate)
                && IsDow.Equals(other.IsDow)
                && LoadReferenceNo.Equals(other.LoadReferenceNo)
                && IsXdock.Equals(other.IsXdock)
                && IsOriginalDirectDelivery.Equals(other.IsOriginalDirectDelivery)
                && IsTransit.Equals(other.IsTransit)
                && LastInspDate.Equals(other.LastInspDate)
                && IsDewholesale.Equals(other.IsDewholesale)
                && IsStorage.Equals(other.IsStorage)
                && IsExtract.Equals(other.IsExtract)
                && ExtractDate.Equals(other.ExtractDate)
                && CustomerAlias.Equals(other.CustomerAlias)
                && MakeName.Equals(other.MakeName)
                && ModelName.Equals(other.ModelName)
                && VehicleTypeName.Equals(other.VehicleTypeName)
                && SurveyCode.Equals(other.SurveyCode)
                && VehicleSurveyInspectionCode.Equals(other.VehicleSurveyInspectionCode)
                && ExpVehicleAvailableDate.Equals(other.ExpVehicleAvailableDate)
                && DeliveryCode.Equals(other.DeliveryCode)
                && LocationName.Equals(other.LocationName)
                && LocationSeqNo.Equals(other.LocationSeqNo)
                && CreateDate.Equals(other.CreateDate)
                && ParentWhCode.Equals(other.ParentWhCode)
                && SecondaryWhCode.Equals(other.SecondaryWhCode)
                && VesselId.Equals(other.VesselId)
                && OriginalDealerCode.Equals(other.OriginalDealerCode)
                && ProcessCode.Equals(other.ProcessCode);
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
                hash = (hash * hashingMultiplier) ^ VinNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ShipName?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ CustCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ StateCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ PortName?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ ModelManCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ ModelDesc?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ VehicleType?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ Color?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ StockNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ CaseNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ VoyageNo?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ SchdArrivalDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ DealerCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ VehicleStatusCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ IsDirectDelivery.GetHashCode();
                hash = (hash * hashingMultiplier) ^ VehicleCutOffDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ActualArrivalDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ AvailableDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ AccountCustomerNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ MakeCode.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ModelCode.GetHashCode();
                hash = (hash * hashingMultiplier) ^ VehicleCode.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsVehicleSwap.GetHashCode();
                hash = (hash * hashingMultiplier) ^ VinStatusCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ DepotCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ LoadDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ UpdateDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsLogDelete.GetHashCode();
                hash = (hash * hashingMultiplier) ^ CustomerModelDesc?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ ItemId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ Lplate?.GetHashCode() ?? 0;;
                hash = (hash * hashingMultiplier) ^ VoyageId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ VehicleStatusCodeOriginal?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ DirectDeliveryIsOriginal.GetHashCode();
                hash = (hash * hashingMultiplier) ^ BookingNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ BookingVehicleNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ManifestId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ScanVinNo?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ StockStatus?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ OrderStatus?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ Reference?.GetHashCode()  ?? 0;
                hash = (hash * hashingMultiplier) ^ LoadId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ DeliveryDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ OrderId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ WhCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ LastWashDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ TotalWashes.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsScanned.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ScannedDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ScannedBy?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ VehicleId?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ BookingAccountCustomerNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsHold.GetHashCode();
                hash = (hash * hashingMultiplier) ^ PickupLocationCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ StorEndDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ StorStartDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ Instructions?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ IsStock.GetHashCode();
                hash = (hash * hashingMultiplier) ^ DamageCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ PutLocationId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ LocationId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ShpAvailableDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ VehicleBarcode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ VlAccountCustomerNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ InvoiceAccountType?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ OeSurveyType?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ VehicleAvailableDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsDow.GetHashCode();
                hash = (hash * hashingMultiplier) ^ LoadReferenceNo?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ IsXdock.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsOriginalDirectDelivery.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsTransit.GetHashCode();
                hash = (hash * hashingMultiplier) ^ LastInspDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsDewholesale.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsStorage.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsExtract.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ExtractDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ CustomerAlias?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ MakeName?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ ModelName?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ VehicleTypeName?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ SurveyCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ VehicleSurveyInspectionCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ ExpVehicleAvailableDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ DeliveryCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ LocationName?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ LocationSeqNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ CreateDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ParentWhCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ SecondaryWhCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ VesselId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ OriginalDealerCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ ProcessCode?.GetHashCode() ?? 0;
                return hash;
            }
        }
}


    public class VlVisShpLoadMap: ClassMap<VlVisShpLoad>
    {
        public VlVisShpLoadMap()
        {
            Table("vl_vis_shp_load");
            Id(x => x.MakeCode, "make_code")
                .Access.Property()
                .Unique()
                .Not.Nullable()
                .GeneratedBy.Assigned();

            Map(x => x.VinNo, "vin_no").Length(30).Not.Nullable();
            Map(x => x.ShipName, "ship_name").Length(20).Not.Nullable();
            Map(x => x.CustCode, "cust_code").Length(3).Not.Nullable();
            Map(x => x.StateCode, "state_code").Length(3).Not.Nullable();
            Map(x => x.PortName, "port_name").Length(20).Not.Nullable();
            Map(x => x.ModelManCode, "model_man_code").Length(15).Not.Nullable();
            Map(x => x.ModelDesc, "model_desc").Length(50).Not.Nullable();
            Map(x => x.VehicleType, "veh_type").Length(10).Not.Nullable();
            Map(x => x.Color, "color").Length(25).Not.Nullable();
            Map(x => x.StockNo, "stock_no").Not.Nullable();
            Map(x => x.CaseNo, "case_no").Not.Nullable();
            Map(x => x.VoyageNo, "voyage_no").Length(20).Not.Nullable();
            Map(x => x.SchdArrivalDate, "schd_arrival_tms").Not.Nullable();
            Map(x => x.DealerCode, "dealer_code").Length(25).Not.Nullable();
            Map(x => x.VehicleStatusCode, "veh_status_code").Length(10).Not.Nullable();
            Map(x => x.IsDirectDelivery, "direct_dlvr_ind").Not.Nullable();
            Map(x => x.VehicleCutOffDate, "veh_cut_off_tms").Not.Nullable();
            Map(x => x.ActualArrivalDate, "act_arrival_tms").Not.Nullable();
            Map(x => x.AvailableDate, "avlb_tms").Not.Nullable();
            Map(x => x.AccountCustomerNo, "acc_cus_no").Not.Nullable();
            Map(x => x.MakeCode, "make_code").Not.Nullable();
            Map(x => x.ModelCode, "model_code").Not.Nullable();
            Map(x => x.VehicleCode, "veh_code").Not.Nullable();
            Map(x => x.IsVehicleSwap, "veh_swap_ind").Not.Nullable();
            Map(x => x.VinStatusCode, "vin_status_code").Length(3).Not.Nullable();
            Map(x => x.DepotCode, "depot_abrv").Length(3).Not.Nullable();
            Map(x => x.LoadDate, "load_tms").Not.Nullable();
            Map(x => x.UpdateDate, "update_tms").Not.Nullable();
            Map(x => x.IsLogDelete, "log_del_ind").Not.Nullable();
            Map(x => x.CustomerModelDesc, "cus_model_desc").Length(50).Not.Nullable();
            Map(x => x.ItemId, "item_id").Not.Nullable();
            Map(x => x.Lplate, "lplate").Length(15).Not.Nullable();
            Map(x => x.VoyageId, "voyage_id").Not.Nullable();
            Map(x => x.VehicleStatusCodeOriginal, "veh_status_code_orig").Length(10).Not.Nullable();
            Map(x => x.DirectDeliveryIsOriginal, "direct_dlvr_ind_orig").Not.Nullable();
            Map(x => x.BookingNo, "bkg_no").Not.Nullable();
            Map(x => x.BookingVehicleNo, "bkg_veh_no").Not.Nullable();
            Map(x => x.ManifestId, "manifest_id").Not.Nullable();
            Map(x => x.ScanVinNo, "scan_vin_no").Length(30).Not.Nullable();
            Map(x => x.StockStatus, "stock_status").Length(15).Not.Nullable();
            Map(x => x.OrderStatus, "order_status").Length(15).Not.Nullable();
            Map(x => x.Reference, "reference").Length(15).Not.Nullable();
            Map(x => x.LoadId, "load_id").Not.Nullable();
            Map(x => x.DeliveryDate, "dlvr_date").Not.Nullable();
            Map(x => x.OrderId, "order_id").Not.Nullable();
            Map(x => x.WhCode, "wh_abrv").Length(3).Not.Nullable();
            Map(x => x.LastWashDate, "last_wash_date").Not.Nullable();
            Map(x => x.TotalWashes, "total_washes").Not.Nullable();
            Map(x => x.IsScanned, "scanned_ind").Not.Nullable();
            Map(x => x.ScannedDate, "scanned_tms").Not.Nullable();
            Map(x => x.ScannedBy, "scanned_by").Length(15).Not.Nullable();
            Map(x => x.VehicleId, "veh_id").Length(20).Not.Nullable();
            Map(x => x.BookingAccountCustomerNo, "bkg_acc_cus_no").Not.Nullable();
            Map(x => x.IsHold, "hold_ind").Not.Nullable();
            Map(x => x.PickupLocationCode, "pkup_locn_code").Length(25).Not.Nullable();
            Map(x => x.StorEndDate, "stor_end_date").Not.Nullable();
            Map(x => x.StorStartDate, "stor_start_date").Not.Nullable();
            Map(x => x.Instructions, "instructions").Length(300).Not.Nullable();
            Map(x => x.IsStock, "stock_ind").Not.Nullable();
            Map(x => x.DamageCode, "damage_code").Length(300).Not.Nullable();
            Map(x => x.PutLocationId, "put_locn_id").Not.Nullable();
            Map(x => x.LocationId, "locn_id").Not.Nullable();
            Map(x => x.ShpAvailableDate, "shp_avlb_tms").Not.Nullable();
            Map(x => x.VehicleBarcode, "veh_barcode").Length(30).Not.Nullable();
            Map(x => x.VlAccountCustomerNo, "vl_acc_cus_no").Not.Nullable();
            Map(x => x.InvoiceAccountType, "inv_acc_type").Length(3).Not.Nullable();
            Map(x => x.OeSurveyType, "oe_survey_type").Length(5).Not.Nullable();
            Map(x => x.VehicleAvailableDate, "veh_avlb_tms").Not.Nullable();
            Map(x => x.IsDow, "dow_ind").Not.Nullable();
            Map(x => x.LoadReferenceNo, "load_ref_no").Length(25).Not.Nullable();
            Map(x => x.IsXdock, "xdock_ind").Not.Nullable();
            Map(x => x.IsOriginalDirectDelivery, "orig_direct_dlvr_ind").Not.Nullable();
            Map(x => x.IsTransit, "transit_ind").Not.Nullable();
            Map(x => x.LastInspDate, "last_insp_date").Not.Nullable();
            Map(x => x.IsDewholesale, "dewholesale_ind").Not.Nullable();
            Map(x => x.IsStorage, "storage_ind").Not.Nullable();
            Map(x => x.IsExtract, "extract_ind").Not.Nullable();
            Map(x => x.ExtractDate, "extract_date").Not.Nullable();
            Map(x => x.CustomerAlias, "cus_alias").Length(6).Not.Nullable();
            Map(x => x.MakeName, "make_name").Length(50).Not.Nullable();
            Map(x => x.ModelName, "model_name").Length(50).Not.Nullable();
            Map(x => x.VehicleTypeName, "veh_type_name").Length(50).Not.Nullable();
            Map(x => x.SurveyCode, "survey_code").Length(15).Not.Nullable();
            Map(x => x.VehicleSurveyInspectionCode, "vehicle_survey_inspection_code").Length(15).Not.Nullable();
            Map(x => x.ExpVehicleAvailableDate, "exp_veh_avlb_tms").Not.Nullable();
            Map(x => x.DeliveryCode, "delivery_code").Length(3).Not.Nullable();
            Map(x => x.LocationName, "location_name").Length(50).Not.Nullable();
            Map(x => x.LocationSeqNo, "location_seq_no").Not.Nullable();
            Map(x => x.CreateDate, "create_tms").Not.Nullable();
            Map(x => x.ParentWhCode, "parent_wh_abrv").Length(3).Not.Nullable();
            Map(x => x.SecondaryWhCode, "secondary_wh_abrv").Length(3).Not.Nullable();
            Map(x => x.VesselId, "vessel_id").Not.Nullable();
            Map(x => x.OriginalDealerCode, "orig_dealer_code").Length(25).Not.Nullable();
            Map(x => x.ProcessCode, "process_code").Length(3).Not.Nullable();
        }
    }
}