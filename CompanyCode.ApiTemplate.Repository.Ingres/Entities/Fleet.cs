using System;

using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities
{
    public class Fleet
    {
        public virtual int AlternateFleetId { get; set; }
        public virtual string BusinessServiceCode { get; set; }
        public virtual int Capacity { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string CurrentState { get; set; }
        public virtual string CurrentStatusCode { get; set; }
        public virtual string CurrentSuburb { get; set; }
        public virtual int DefCapacity { get; set; }
        public virtual string DepotCode { get; set; }
        public virtual string EmailId1 { get; set; }
        public virtual string EmailId2 { get; set; }
        public virtual string EmailId3 { get; set; }
        public virtual string EquipmentType { get; set; }
        public virtual string FleetCode { get; set; }
        public virtual string FleetConfigCode { get; set; }
        public virtual int FleetGroupId { get; set; }
        public virtual int FleetId { get; set; }
        public virtual string FleetPoolCode { get; set; }
        public virtual string GloCode { get; set; }
        public virtual int IsApplySeq { get; set; }
        public virtual int IsExtCarrier { get; set; }
        public virtual int IsIgnorePsPrint { get; set; }
        public virtual int IsLockout { get; set; }
        public virtual int IsLogDelete { get; set; }
        public virtual int IsPlanFull { get; set; }
        public virtual int IsPlanRurTrip { get; set; }
        public virtual int IsPodReq { get; set; }
        public virtual int IsVirtualFleet { get; set; }
        public virtual int IsVlStor { get; set; }
        public virtual int NumberTrips { get; set; }
        public virtual string OperatorId { get; set; }
        public virtual string OriginalRailDepotId { get; set; }

        public virtual Party Party { get; set; }
        public virtual int PartyId { get; set; }
        public virtual string PlanLocation { get; set; }
        public virtual string ResponseRailDepotId { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual string Url { get; set; }
        public virtual DateTime WrkEta { get; set; }
    }

    public class FleetMap : ClassMap<Fleet>
    {
        public FleetMap()
        {
            Table("fleet");
            Id(x => x.FleetId, "fleet_id")
                .Access.Property()
                .GeneratedBy.Assigned();

            // works
            References(x => x.Party).Column("party_id");
            // worked sorta b4
            //References(x => x.Party, "party_id").Unique();

            //References(x => x.Party).Not.Nullable().Column("party_id").PropertyRef(x => x.PartyId).ForeignKey("none");
            //HasOne( x => x.Party ).PropertyRef(x=>x.PartyId);
            //References(x => x.ProductDescription).Not.Nullable().Column("ItemId").PropertyRef(x => x.ItemId).ForeignKey("none");
            //References(x => x.Party).Column("party_id").PropertyRef(x => x.PartyId).ForeignKey("none").ReadOnly();

            //	CONSTRAINT FLEET_PK PRIMARY KEY (fleet_id)
            //);
            //CREATE INDEX fleet_1 ON dba.fleet (fleet_pool_code,fleet_id,party_id);
            Map(x => x.FleetId, "fleet_id").Not.Nullable().Index("fleet_1");
            Map(x => x.FleetPoolCode, "fleet_pool_code").Length(3).Not.Nullable().Index("fleet_1");
            Map(x => x.PartyId, "party_id").Not.Nullable().Index("fleet_1");
            Map(x => x.OriginalRailDepotId, "orig_rail_depot_id").Length(5).Not.Nullable();
            Map(x => x.ResponseRailDepotId, "resp_rail_depot_id").Length(5).Not.Nullable();
            Map(x => x.DepotCode, "depot_abrv").Length(3).Not.Nullable();
            Map(x => x.FleetCode, "fleet_code").Length(3).Not.Nullable();
            Map(x => x.FleetConfigCode, "fleet_cnfg_code").Length(3).Not.Nullable();
            Map(x => x.CurrentStatusCode, "cur_status_code").Length(3).Not.Nullable();
            Map(x => x.CurrentState, "cur_state").Length(3).Not.Nullable();
            Map(x => x.CurrentSuburb, "cur_suburb").Length(20).Not.Nullable();
            Map(x => x.Capacity, "capacity").Not.Nullable();
            Map(x => x.IsPlanRurTrip, "pln_rur_trip_ind").Not.Nullable();
            Map(x => x.WrkEta, "wrk_eta").Not.Nullable();
            Map(x => x.NumberTrips, "num_trips").Not.Nullable();
            Map(x => x.PlanLocation, "pln_location").Length(20).Not.Nullable();
            Map(x => x.IsPlanFull, "pln_full_ind").Not.Nullable();
            Map(x => x.AlternateFleetId, "alternate_fleet_id").Not.Nullable();
            Map(x => x.IsVirtualFleet, "virtual_fleet_ind").Not.Nullable();
            Map(x => x.BusinessServiceCode, "bus_service_code").Length(2).Not.Nullable();
            Map(x => x.OperatorId, "operator_id").Length(8).Not.Nullable();
            Map(x => x.CreateDate, "create_date").Not.Nullable();
            Map(x => x.UpdateDate, "update_date").Not.Nullable();
            Map(x => x.FleetGroupId, "fleet_group_id").Not.Nullable();
            Map(x => x.IsApplySeq, "apply_seq_ind").Not.Nullable();
            Map(x => x.IsLogDelete, "log_del_ind").Not.Nullable();
            Map(x => x.IsIgnorePsPrint, "ignore_ps_print_ind").Not.Nullable();
            Map(x => x.DefCapacity, "def_capacity").Not.Nullable();
            Map(x => x.EquipmentType, "eqp_type").Length(3).Not.Nullable();
            Map(x => x.GloCode, "glo_code").Length(6).Not.Nullable();
            Map(x => x.IsPodReq, "pod_req_ind").Not.Nullable();
            Map(x => x.IsExtCarrier, "ext_carrier_ind").Not.Nullable();
            Map(x => x.EmailId1, "email_id_1").Length(50).Not.Nullable();
            Map(x => x.EmailId2, "email_id_2").Length(50).Not.Nullable();
            Map(x => x.EmailId3, "email_id_3").Length(50).Not.Nullable();
            Map(x => x.Url, "url").Length(100).Not.Nullable();
            Map(x => x.IsVlStor, "vl_stor_ind").Not.Nullable();
            Map(x => x.IsLockout, "lockout_ind").Not.Nullable();
        }
    }
}