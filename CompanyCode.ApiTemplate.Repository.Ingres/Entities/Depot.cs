using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities
{
    public class Depot
    {
        public virtual int BusinessEndTime { get; set; }
        public virtual int BusinessStartTime { get; set; }
        public virtual string BusinessUnitCode { get; set; }
        public virtual string ContactEmailid { get; set; }
        public virtual string DepotAlias { get; set; }
        public virtual string DepotCode { get; set; }
        public virtual string FaxNo { get; set; }
        public virtual int FCLAccountCustomerNo { get; set; }
        public virtual float GFLatitude { get; set; }
        public virtual float GFLongitude { get; set; }
        public virtual float GFRadius { get; set; }
        public virtual string GlbuCode { get; set; }
        public virtual int IsCg { get; set; }
        public virtual int IsDefTpgDepot { get; set; }
        public virtual int IsGFEnable { get; set; }
        public virtual int IsLogDelete { get; set; }
        public virtual int LocationId { get; set; }
        public virtual int MetCutOffTime { get; set; }
        public virtual int MetRunTime { get; set; }
        public virtual string Mobile { get; set; }
        public virtual string Name { get; set; }
        public virtual string PhoneNo { get; set; }
        public virtual string PlanGroupCode { get; set; }
        public virtual string Postcode { get; set; }
        public virtual int RurCutOffTime { get; set; }
        public virtual int RurRunTime { get; set; }
        public virtual string StandardNo { get; set; }
        public virtual int StartTime { get; set; }
        public virtual string State { get; set; }
        public virtual string Street { get; set; }
        public virtual string Suburb { get; set; }
        public virtual string TpgCode { get; set; }
        public virtual string WebName { get; set; }
        public virtual int XdockTime { get; set; }
    }

    public class DepotMap : ClassMap<Depot>
    {
        public DepotMap()
        {
            Table("depot");
            Id(x => x.DepotCode, "depot_abrv")
                .Access.Property()
                .Unique()
                .Length(3)
                .Not.Nullable()
                .GeneratedBy.Assigned();

            Map(x => x.DepotCode, "depot_abrv").Unique().Length(3).Not.Nullable();
            Map(x => x.TpgCode, "tpg_abrv").Length(3).Not.Nullable();
            Map(x => x.DepotAlias, "dep_alias").Length(6).Not.Nullable();
            Map(x => x.Name, "name").Length(30).Not.Nullable();
            Map(x => x.BusinessEndTime, "bus_end_time").Not.Nullable();
            Map(x => x.BusinessStartTime, "bus_start_time").Not.Nullable();
            Map(x => x.FaxNo, "fax_no").Length(8).Not.Nullable();
            Map(x => x.FCLAccountCustomerNo, "fcl_acc_cus_no").Not.Nullable();
            Map(x => x.IsLogDelete, "log_del_ind").Not.Nullable();
            Map(x => x.PhoneNo, "phone_no").Length(8).Not.Nullable();
            Map(x => x.StandardNo, "std_no").Length(4).Not.Nullable();
            Map(x => x.Street, "street").Length(30).Not.Nullable();
            Map(x => x.Suburb, "suburb").Length(20).Not.Nullable();
            Map(x => x.State, "state").Length(3).Not.Nullable();
            Map(x => x.Postcode, "postcode").Length(4).Not.Nullable();
            Map(x => x.LocationId, "locn_id").Not.Nullable();
            Map(x => x.PlanGroupCode, "pln_grp_code").Length(3).Not.Nullable();
            Map(x => x.IsDefTpgDepot, "def_tpg_depot_ind").Not.Nullable();
            Map(x => x.BusinessUnitCode, "bus_unit_code").Length(3).Not.Nullable();
            Map(x => x.WebName, "web_name").Length(30).Not.Nullable();
            Map(x => x.MetCutOffTime, "met_cut_off_time").Not.Nullable();
            Map(x => x.MetRunTime, "met_run_time").Not.Nullable();
            Map(x => x.RurCutOffTime, "rur_cut_off_time").Not.Nullable();
            Map(x => x.RurRunTime, "rur_run_time").Not.Nullable();
            Map(x => x.StartTime, "start_time").Not.Nullable();
            Map(x => x.XdockTime, "xdock_time").Not.Nullable();
            Map(x => x.IsCg, "cg_ind").Not.Nullable();
            Map(x => x.GlbuCode, "glbu_code").Length(12).Not.Nullable();
            Map(x => x.GFLatitude, "gf_latitude").Not.Nullable();
            Map(x => x.GFLongitude, "gf_longitude").Not.Nullable();
            Map(x => x.GFRadius, "gf_radius").Not.Nullable();
            Map(x => x.IsGFEnable, "gf_enable_ind").Not.Nullable();
            Map(x => x.ContactEmailid, "cont_emailid").Length(75).Not.Nullable();
            Map(x => x.Mobile, "mobile").Length(15).Not.Nullable();
        }
    }
}