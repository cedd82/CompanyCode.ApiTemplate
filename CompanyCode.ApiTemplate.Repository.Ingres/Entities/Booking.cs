using System;

using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class Booking
    {

        public virtual int BookingNo {get; set;}
        public virtual string ContactStandardNo {get; set;}
        public virtual string ContactPhoneNo {get; set;}
        public virtual string ContactTitle {get; set;}
        public virtual string ContactFirstName {get; set;}
        public virtual string ContactSurname {get; set;}
        public virtual int PickupTime {get; set;}
        public virtual string PickupContactName {get; set;}
        public virtual int IsPickupPhone {get; set;}
        public virtual int IsPickupCallCompliant {get; set;}
        public virtual string PickupUtcTime {get; set;}
        public virtual DateTime PickupDate {get; set;}
        public virtual string PickupName {get; set;}
        public virtual string PickupStreet {get; set;}
        public virtual string PickupSuburb {get; set;}
        public virtual string PickupState {get; set;}
        public virtual string PickupStandardNo {get; set;}
        public virtual string PickupPhoneNo {get; set;}
        public virtual string PickupMobileNo {get; set;}
        public virtual string PickupDepotCode {get; set;}
        public virtual string PickupLocationCode {get; set;}
        public virtual int IsPickupInstruction {get; set;}
        public virtual int IsPickupSpl {get; set;}
        public virtual string PickupCode {get; set;}
        public virtual string DeliveryContactName {get; set;}
        public virtual int IsDeliveryPhone {get; set;}
        public virtual int IsDeliveryCallCompliant {get; set;}
        public virtual string DeliveryUtcTime {get; set;}
        public virtual int DeliveryTime {get; set;}
        public virtual DateTime DeliveryDate {get; set;}
        public virtual string DeliveryName {get; set;}
        public virtual string DeliveryStreet {get; set;}
        public virtual string DeliverySuburb {get; set;}
        public virtual string DeliveryState {get; set;}
        public virtual string DeliveryStandardNo {get; set;}
        public virtual string DeliveryPhoneNo {get; set;}
        public virtual string DeliveryMobileNo {get; set;}
        public virtual string DeliveryDepotCode {get; set;}
        public virtual string DeliveryLocationCode {get; set;}
        public virtual int IsDeliveryInstruction {get; set;}
        public virtual int IsDeliverySpl {get; set;}
        public virtual string DeliveryCode {get; set;}
        public virtual int IsSpotSpecial {get; set;}
        public virtual int IsCasCustomer {get; set;}
        public virtual string ServiceCode {get; set;}
        public virtual int SwapBookingNo {get; set;}
        public virtual string PayMethodCode {get; set;}
        public virtual int AccountCustomerNo {get; set;}
        public virtual string MovementCode {get; set;}
        public virtual string CurrentBookingStatusCode {get; set;}
        public virtual int VehicleCount {get; set;}
        public virtual decimal TotalBookingCharge {get; set;}
        public virtual int InvoiceReferenceCode {get; set;}
        public virtual string OperatorId {get; set;}
        public virtual DateTime BookingDate {get; set;}
        public virtual string OrderNo {get; set;}
        public virtual string RateGroupCode {get; set;}
        public virtual string CustomerCode {get; set;}
        public virtual int ExtractWeek {get; set;}
        public virtual decimal ActualCost {get; set;}
        public virtual decimal AccruedCost {get; set;}
        public virtual string InvoiceNo {get; set;}
        public virtual decimal GstCharge {get; set;}
        public virtual string ContactMobileNo {get; set;}
        public virtual int IsPayment {get; set;}
        public virtual string PaymentDepot {get; set;}
        public virtual int MarketCode {get; set;}
        public virtual string PickupEmailId {get; set;}
        public virtual string DeliveryEmailId {get; set;}
        public virtual string ContactEmailId {get; set;}
        public virtual string DeliveryDealerId {get; set;}
        public virtual string PickupDealerId {get; set;}
        public virtual int TransitDays {get; set;}
        public virtual string DispatchDepotCode {get; set;}
        public virtual string GlbuCode {get; set;}
        public virtual string GloCode {get; set;}
        public virtual string GLSCode {get; set;}
        public virtual int IsMessageSent {get; set;}
        public virtual int PickupTimeSlot {get; set;}
        public virtual int IsVoiceAlert {get; set;}
        public virtual string WebLogin {get; set;}
        public virtual int SuburbPoolInd {get; set;}
}


    public class BookingMap: ClassMap<Booking>
    {
        public BookingMap()
        {
            Table("booking");
            Id(x => x.BookingNo, "bkg_no")
                .Access.Property()
                .Unique().Not.Nullable()
                .Index("booking_1").Index("booking_6")
                .GeneratedBy.Assigned();

            Map(x => x.BookingNo, "bkg_no").Not.Nullable().Index("booking_1");
            Map(x => x.ContactStandardNo, "cont_std_no").Length(4).Not.Nullable();
            Map(x => x.ContactPhoneNo, "cont_phone_no").Length(8).Not.Nullable();
            Map(x => x.ContactTitle, "cont_title").Length(6).Not.Nullable();
            Map(x => x.ContactFirstName, "cont_first_name").Length(30).Not.Nullable();
            Map(x => x.ContactSurname, "cont_surname").Length(30).Not.Nullable();
            Map(x => x.PickupTime, "pkup_time").Not.Nullable();
            Map(x => x.PickupContactName, "pkup_cont_name").Length(30).Not.Nullable();
            Map(x => x.IsPickupPhone, "pkup_phone_ind").Not.Nullable();
            Map(x => x.IsPickupCallCompliant, "pkup_call_cmpl_ind").Not.Nullable();
            Map(x => x.PickupUtcTime, "pkup_mrdn_time").Length(2).Not.Nullable();
            Map(x => x.PickupDate, "pkup_date").Not.Nullable();
            Map(x => x.PickupName, "pkup_name").Length(30).Not.Nullable();
            Map(x => x.PickupStreet, "pkup_street").Length(30).Not.Nullable();
            Map(x => x.PickupSuburb, "pkup_suburb").Length(20).Not.Nullable();
            Map(x => x.PickupState, "pkup_state").Length(3).Not.Nullable();
            Map(x => x.PickupStandardNo, "pkup_std_no").Length(4).Not.Nullable();
            Map(x => x.PickupPhoneNo, "pkup_phone_no").Length(8).Not.Nullable();
            Map(x => x.PickupMobileNo, "pkup_mobile_no").Length(15).Not.Nullable();
            Map(x => x.PickupDepotCode, "pkup_depot_abrv").Length(3).Not.Nullable();
            Map(x => x.PickupLocationCode, "pkup_location_code").Length(3).Not.Nullable();
            Map(x => x.IsPickupInstruction, "pkup_instr_ind").Not.Nullable();
            Map(x => x.IsPickupSpl, "pkup_spl_ind").Not.Nullable();
            Map(x => x.PickupCode, "pkup_code").Length(25).Not.Nullable();
            Map(x => x.DeliveryContactName, "dlvr_cont_name").Length(30).Not.Nullable();
            Map(x => x.IsDeliveryPhone, "dlvr_phone_ind").Not.Nullable();
            Map(x => x.IsDeliveryCallCompliant, "dlvr_call_cmpl_ind").Not.Nullable();
            Map(x => x.DeliveryUtcTime, "dlvr_mrdn_time").Length(2).Not.Nullable();
            Map(x => x.DeliveryTime, "dlvr_time").Not.Nullable();
            Map(x => x.DeliveryDate, "dlvr_date").Not.Nullable();
            Map(x => x.DeliveryName, "dlvr_name").Length(30).Not.Nullable();
            Map(x => x.DeliveryStreet, "dlvr_street").Length(30).Not.Nullable();
            Map(x => x.DeliverySuburb, "dlvr_suburb").Length(20).Not.Nullable();
            Map(x => x.DeliveryState, "dlvr_state").Length(3).Not.Nullable();
            Map(x => x.DeliveryStandardNo, "dlvr_std_no").Length(4).Not.Nullable();
            Map(x => x.DeliveryPhoneNo, "dlvr_phone_no").Length(8).Not.Nullable();
            Map(x => x.DeliveryMobileNo, "dlvr_mobile_no").Length(15).Not.Nullable();
            Map(x => x.DeliveryDepotCode, "dlvr_depot_abrv").Length(3).Not.Nullable();
            Map(x => x.DeliveryLocationCode, "dlvr_location_code").Length(3).Not.Nullable();
            Map(x => x.IsDeliveryInstruction, "dlvr_instr_ind").Not.Nullable();
            Map(x => x.IsDeliverySpl, "dlvr_spl_ind").Not.Nullable();
            Map(x => x.DeliveryCode, "dlvr_code").Length(25).Not.Nullable();
            Map(x => x.IsSpotSpecial, "spot_spcl_ind").Not.Nullable();
            Map(x => x.IsCasCustomer, "cas_cus_ind").Not.Nullable();
            Map(x => x.ServiceCode, "service_code").Length(3).Not.Nullable();
            Map(x => x.SwapBookingNo, "swap_bkg_no").Not.Nullable();
            Map(x => x.PayMethodCode, "pay_mthd_code").Length(3).Not.Nullable();
            Map(x => x.AccountCustomerNo, "acc_cus_no").Not.Nullable().Index("booking_4");
            Map(x => x.MovementCode, "mvt_code").Length(3).Not.Nullable();
            Map(x => x.CurrentBookingStatusCode, "cur_bkg_status_code").Length(3).Not.Nullable().Index("booking_1");
            Map(x => x.VehicleCount, "veh_count").Not.Nullable();
            Map(x => x.TotalBookingCharge, "tot_bkg_chrg").Not.Nullable();
            Map(x => x.InvoiceReferenceCode, "inv_ref_code").Not.Nullable();
            Map(x => x.OperatorId, "operator_id").Length(8).Not.Nullable();
            Map(x => x.BookingDate, "bkg_tms").Not.Nullable().Index("booking_2");
            Map(x => x.OrderNo, "order_no").Length(15).Not.Nullable().Index("booking_6");
            Map(x => x.RateGroupCode, "rate_group_code").Length(3).Not.Nullable();
            Map(x => x.CustomerCode, "cus_abrv").Length(10).Not.Nullable();
            Map(x => x.ExtractWeek, "extract_wk").Not.Nullable().Index("booking_3");
            Map(x => x.ActualCost, "actual_cost").Not.Nullable();
            Map(x => x.AccruedCost, "accrued_cost").Not.Nullable();
            Map(x => x.InvoiceNo, "invoice_no").Length(20).Not.Nullable();
            Map(x => x.GstCharge, "gst_chrg").Not.Nullable();
            Map(x => x.ContactMobileNo, "cont_mobile_no").Length(15).Not.Nullable();
            Map(x => x.IsPayment, "payment_ind").Not.Nullable();
            Map(x => x.PaymentDepot, "payment_depot").Length(3).Not.Nullable();
            Map(x => x.MarketCode, "mkt_code").Not.Nullable();
            Map(x => x.PickupEmailId, "pkup_email_id").Length(70).Not.Nullable();
            Map(x => x.DeliveryEmailId, "dlvr_email_id").Length(70).Not.Nullable();
            Map(x => x.ContactEmailId, "cont_email_id").Length(70).Not.Nullable();
            Map(x => x.DeliveryDealerId, "dlvr_dealer_id").Length(25).Not.Nullable();
            Map(x => x.PickupDealerId, "pkup_dealer_id").Length(25).Not.Nullable();
            Map(x => x.TransitDays, "transit_days").Not.Nullable();
            Map(x => x.DispatchDepotCode, "desp_depot_abrv").Length(3).Not.Nullable();
            Map(x => x.GlbuCode, "glbu_code").Length(12).Not.Nullable();
            Map(x => x.GloCode, "glo_code").Length(6).Not.Nullable();
            Map(x => x.GLSCode, "gls_code").Length(8).Not.Nullable();
            Map(x => x.IsMessageSent, "msg_sent_ind").Not.Nullable();
            Map(x => x.PickupTimeSlot, "pkup_time_slot").Not.Nullable();
            Map(x => x.IsVoiceAlert, "voice_alert_ind").Not.Nullable();
            Map(x => x.WebLogin, "web_login").Length(20).Not.Nullable();
            Map(x => x.SuburbPoolInd, "suburb_pool_ind").Not.Nullable();
        }
    }
}

//CREATE TABLE dba.booking (
//	bkg_no INTEGER NOT NULL,
//	cont_std_no CHAR(4) NOT NULL,
//	cont_phone_no CHAR(8) NOT NULL,
//	cont_title CHAR(6) NOT NULL,
//	cont_first_name VARCHAR(30) NOT NULL,
//	cont_surname VARCHAR(30) NOT NULL,
//	pkup_time INTEGER NOT NULL,
//	pkup_cont_name VARCHAR(30) NOT NULL,
//	pkup_phone_ind INTEGER NOT NULL,
//	pkup_call_cmpl_ind INTEGER NOT NULL,
//	pkup_mrdn_time CHAR(2) NOT NULL,
//	pkup_date INGRESDATE NOT NULL,
//	pkup_name VARCHAR(30) NOT NULL,
//	pkup_street VARCHAR(30) NOT NULL,
//	pkup_suburb VARCHAR(20) NOT NULL,
//	pkup_state CHAR(3) NOT NULL,
//	pkup_std_no CHAR(4) NOT NULL,
//	pkup_phone_no CHAR(8) NOT NULL,
//	pkup_mobile_no VARCHAR(15) NOT NULL,
//	pkup_depot_abrv CHAR(3) NOT NULL,
//	pkup_location_code CHAR(3) NOT NULL,
//	pkup_instr_ind INTEGER NOT NULL,
//	pkup_spl_ind INTEGER NOT NULL,
//	pkup_code VARCHAR(25) NOT NULL,
//	dlvr_cont_name VARCHAR(30) NOT NULL,
//	dlvr_phone_ind INTEGER NOT NULL,
//	dlvr_call_cmpl_ind INTEGER NOT NULL,
//	dlvr_mrdn_time CHAR(2) NOT NULL,
//	dlvr_time INTEGER NOT NULL,
//	dlvr_date INGRESDATE NOT NULL,
//	dlvr_name VARCHAR(30) NOT NULL,
//	dlvr_street VARCHAR(30) NOT NULL,
//	dlvr_suburb VARCHAR(20) NOT NULL,
//	dlvr_state CHAR(3) NOT NULL,
//	dlvr_std_no CHAR(4) NOT NULL,
//	dlvr_phone_no CHAR(8) NOT NULL,
//	dlvr_mobile_no VARCHAR(15) NOT NULL,
//	dlvr_depot_abrv CHAR(3) NOT NULL,
//	dlvr_location_code CHAR(3) NOT NULL,
//	dlvr_instr_ind INTEGER NOT NULL,
//	dlvr_spl_ind INTEGER NOT NULL,
//	dlvr_code VARCHAR(25) NOT NULL,
//	spot_spcl_ind INTEGER NOT NULL,
//	cas_cus_ind INTEGER NOT NULL,
//	service_code CHAR(3) NOT NULL,
//	swap_bkg_no INTEGER NOT NULL,
//	pay_mthd_code CHAR(3) NOT NULL,
//	acc_cus_no INTEGER NOT NULL,
//	mvt_code CHAR(3) NOT NULL,
//	cur_bkg_status_code CHAR(3) NOT NULL,
//	veh_count INTEGER NOT NULL,
//	tot_bkg_chrg MONEY NOT NULL,
//	inv_ref_code INTEGER NOT NULL,
//	operator_id CHAR(8) NOT NULL,
//	bkg_tms INGRESDATE NOT NULL,
//	order_no VARCHAR(15) NOT NULL,
//	rate_group_code CHAR(3) NOT NULL,
//	cus_abrv CHAR(10) NOT NULL,
//	extract_wk INTEGER NOT NULL,
//	actual_cost MONEY NOT NULL,
//	accrued_cost MONEY NOT NULL,
//	invoice_no VARCHAR(20) NOT NULL,
//	gst_chrg MONEY NOT NULL,
//	cont_mobile_no VARCHAR(15) NOT NULL,
//	payment_ind INTEGER NOT NULL,
//	payment_depot CHAR(3) NOT NULL,
//	mkt_code INTEGER NOT NULL,
//	pkup_email_id VARCHAR(70) NOT NULL,
//	dlvr_email_id VARCHAR(70) NOT NULL,
//	cont_email_id VARCHAR(70) NOT NULL,
//	dlvr_dealer_id VARCHAR(25) NOT NULL,
//	pkup_dealer_id VARCHAR(25) NOT NULL,
//	transit_days INTEGER NOT NULL,
//	desp_depot_abrv CHAR(3) NOT NULL,
//	glbu_code CHAR(12) NOT NULL,
//	glo_code CHAR(6) NOT NULL,
//	gls_code CHAR(8) NOT NULL,
//	msg_sent_ind INTEGER NOT NULL,
//	pkup_time_slot INTEGER NOT NULL,
//	voice_alert_ind INTEGER NOT NULL,
//	web_login VARCHAR(20) NOT NULL,
//	suburb_pool_ind INTEGER NOT NULL,
//	CONSTRAINT "BOOKING_PK" PRIMARY KEY (bkg_no)
//);
//CREATE INDEX booking_1 ON dba.booking (cur_bkg_status_code,bkg_no);
//CREATE INDEX booking_2 ON dba.booking (bkg_tms);
//CREATE INDEX booking_3 ON dba.booking (extract_wk);
//CREATE INDEX booking_4 ON dba.booking (acc_cus_no);
//CREATE INDEX booking_6 ON dba.booking (order_no,bkg_no);