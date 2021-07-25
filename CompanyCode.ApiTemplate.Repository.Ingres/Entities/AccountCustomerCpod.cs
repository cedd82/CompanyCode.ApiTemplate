using System;

using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities
{
    public class AccountCustomerCpod
    {
        public virtual int AccountCustomerNo { get; set; }
        public virtual string AlertMessageGroup { get; set; }
        public virtual int BookingConf { get; set; }
        public virtual int DamageAlert { get; set; }
        public virtual int DeliveryConf { get; set; }
        public virtual int DeliveryPhotoCount { get; set; }
        public virtual int DisableEbkgEdit { get; set; }
        public virtual string GroupAccountName { get; set; }
        public virtual string InterfaceType { get; set; }
        public virtual int IsGeofence { get; set; }
        public virtual int IsOeSurvey { get; set; }
        public virtual int IsVinScan { get; set; }
        public virtual int IsVsr { get; set; }
        public virtual int OePickupScan { get; set; }
        public virtual string OeSurveyConditionName { get; set; }
        public virtual string OeSurveyDamageName { get; set; }
        public virtual string OeSurveyType { get; set; }
        public virtual string OperatorId { get; set; }
        public virtual int PickupConf { get; set; }
        public virtual int PickupPhotoCount { get; set; }
        public virtual int PreDeliveryConf { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual string UsedSurveyConditionName { get; set; }
        public virtual string UsedSurveyDamageName { get; set; }
    }

    public class AccountCustomerCpodMap : ClassMap<AccountCustomerCpod>
    {
        public AccountCustomerCpodMap()
        {
            Table("acc_cus_cpod");
            Id(x => x.AccountCustomerNo, "acc_cus_no")
                .Access.Property()
                .Unique()
                .Not.Nullable()
                .GeneratedBy.Assigned();

            Map(x => x.AccountCustomerNo, "acc_cus_no").Not.Nullable();
            Map(x => x.IsOeSurvey, "oe_survey_ind").Not.Nullable();
            Map(x => x.BookingConf, "bkg_conf").Not.Nullable();
            Map(x => x.DeliveryConf, "dlvr_conf").Not.Nullable();
            Map(x => x.DeliveryPhotoCount, "dlvr_photo_count").Not.Nullable();
            Map(x => x.DamageAlert, "dmg_alert").Not.Nullable();
            Map(x => x.PickupConf, "pkup_conf").Not.Nullable();
            Map(x => x.PickupPhotoCount, "pkup_photo_count").Not.Nullable();
            Map(x => x.PreDeliveryConf, "pre_dlvr_conf").Not.Nullable();
            Map(x => x.DisableEbkgEdit, "disable_ebkg_edit").Not.Nullable();
            Map(x => x.InterfaceType, "interface_type").Length(3).Not.Nullable();
            Map(x => x.GroupAccountName, "group_account_name").Length(20).Not.Nullable();
            Map(x => x.AlertMessageGroup, "alert_msg_group").Length(3).Not.Nullable();
            Map(x => x.IsVinScan, "vin_scan_ind").Not.Nullable();
            Map(x => x.OperatorId, "operator_id").Length(8).Not.Nullable();
            Map(x => x.UpdateDate, "update_tms").Not.Nullable();
            Map(x => x.OePickupScan, "oe_pickup_scan").Not.Nullable();
            Map(x => x.IsVsr, "vsr_ind").Not.Nullable();
            Map(x => x.IsGeofence, "geofence_ind").Not.Nullable();
            Map(x => x.OeSurveyType, "oe_survey_type").Length(5).Not.Nullable();
            Map(x => x.OeSurveyConditionName, "oe_survey_condition_name").Length(25).Not.Nullable();
            Map(x => x.OeSurveyDamageName, "oe_survey_damage_name").Length(25).Not.Nullable();
            Map(x => x.UsedSurveyConditionName, "used_survey_condition_name").Length(25).Not.Nullable();
            Map(x => x.UsedSurveyDamageName, "used_survey_damage_name").Length(25).Not.Nullable();
        }
    }
}