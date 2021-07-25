using System;

using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class Driver
    {
        public virtual int PartyId {get; set;}
        public virtual decimal DistanceBasePayRate {get; set;}
        public virtual DateTime LicenceExpiryDate {get; set;}
        public virtual string LicenceNo {get; set;}
        public virtual string LicenceState {get; set;}
        public virtual string EmployeeId {get; set;}
        public virtual int SubContractorPartyId {get; set;}
        public virtual string CurrentStatusCode {get; set;}
        public virtual string GPSTagNo {get; set;}
        public virtual int IsTagActive {get; set;}
    }

    public class DriverMap: ClassMap<Driver>
    {
        public DriverMap()
        {
            Table("driver");
            Id(x => x.PartyId, "party_id")
                .Access.Property()
                .GeneratedBy.Assigned();

            Map(x => x.PartyId, "party_id").Not.Nullable();
            Map(x => x.DistanceBasePayRate, "dist_base_pay_rate").Not.Nullable();
            Map(x => x.LicenceExpiryDate, "licence_expiry_date").Not.Nullable();
            Map(x => x.LicenceNo, "licence_no").Length(15).Not.Nullable();
            Map(x => x.LicenceState, "licence_state").Length(3).Not.Nullable();
            Map(x => x.EmployeeId, "employee_id").Length(10).Not.Nullable();
            Map(x => x.SubContractorPartyId, "subbie_party_id").Not.Nullable();
            Map(x => x.CurrentStatusCode, "cur_status_code").Length(3).Not.Nullable();
            Map(x => x.GPSTagNo, "gps_tag_no").Length(15).Not.Nullable();
            Map(x => x.IsTagActive, "tag_active_ind").Not.Nullable();
        }
    }
}