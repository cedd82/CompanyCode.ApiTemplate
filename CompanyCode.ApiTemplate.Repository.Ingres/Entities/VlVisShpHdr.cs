using System;

using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class VlVisShpHdr
    {

        public virtual int VoyageId {get; set;}
        public virtual string ShipName {get; set;}
        public virtual int WharfCode {get; set;}
        public virtual DateTime SchdArrivalDate {get; set;}
        public virtual DateTime ActualArrivalDate {get; set;}
        public virtual DateTime ShpAvailableDate {get; set;}
        public virtual DateTime VehicleAvailableDate {get; set;}
        public virtual string VoyageNo {get; set;}
        public virtual int OrderId {get; set;}
        public virtual string StatusCode {get; set;}
        public virtual string RouteId {get; set;}
        public virtual string WhCode {get; set;}
        public virtual int VlAccountCustomerNo {get; set;}
        public virtual DateTime PostgresUpdateDate {get; set;}
        public virtual int IsExtract {get; set;}
        public virtual int VesselId {get; set;}
        public virtual string ProcessCode {get; set;}

        protected bool Equals(VlVisShpHdr other)
        {
            if (other == null)
            {
                return false;
            }

            return VoyageId.Equals(other.VoyageId)
                   && ShipName.Equals(other.ShipName)
                   && WharfCode.Equals(other.WharfCode)
                   && SchdArrivalDate.Equals(other.SchdArrivalDate)
                   && ActualArrivalDate.Equals(other.ActualArrivalDate)
                   && ShpAvailableDate.Equals(other.ShpAvailableDate)
                   && VehicleAvailableDate.Equals(other.VehicleAvailableDate)
                   && VoyageNo.Equals(other.VoyageNo)
                   && OrderId.Equals(other.OrderId)
                   && StatusCode.Equals(other.StatusCode)
                   && RouteId.Equals(other.RouteId)
                   && WhCode.Equals(other.WhCode)
                   && VlAccountCustomerNo.Equals(other.VlAccountCustomerNo)
                   && PostgresUpdateDate.Equals(other.PostgresUpdateDate)
                   && IsExtract.Equals(other.IsExtract)
                   && VesselId.Equals(other.VesselId)
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
            if (obj.GetType() != typeof (VlVisShpHdr))
            {
                return false;
            }
            return Equals((VlVisShpHdr) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                const int hashingBase = (int) 2166136261;
                const int hashingMultiplier = 16777619;
                int hash = hashingBase;
                hash = (hash * hashingMultiplier) ^ VoyageId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ShipName?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ WharfCode.GetHashCode();
                hash = (hash * hashingMultiplier) ^ SchdArrivalDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ActualArrivalDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ShpAvailableDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ VehicleAvailableDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ VoyageNo?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ OrderId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ StatusCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ RouteId?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ WhCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ VlAccountCustomerNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ PostgresUpdateDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsExtract.GetHashCode();
                hash = (hash * hashingMultiplier) ^ VesselId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ProcessCode?.GetHashCode() ?? 0;

                return hash;
            }
        }

    }


    public class VlVisShpHdrMap: ClassMap<VlVisShpHdr>
    {
        public VlVisShpHdrMap()
        {
            Table("vl_vis_shp_hdr");
            Id(x => x.VoyageId, "voyage_id")
                .Access.Property()
                .Unique()
                .Not.Nullable()
                .GeneratedBy.Assigned();

            Map(x => x.VoyageId, "voyage_id").Not.Nullable();
            Map(x => x.ShipName, "ship_name").Length(20).Not.Nullable();
            Map(x => x.WharfCode, "wharf_code").Not.Nullable();
            Map(x => x.SchdArrivalDate, "schd_arrival_tms").Not.Nullable();
            Map(x => x.ActualArrivalDate, "act_arrival_tms").Not.Nullable();
            Map(x => x.ShpAvailableDate, "shp_avlb_tms").Not.Nullable();
            Map(x => x.VehicleAvailableDate, "veh_avlb_tms").Not.Nullable();
            Map(x => x.VoyageNo, "voyage_no").Length(20).Not.Nullable();
            Map(x => x.OrderId, "order_id").Not.Nullable();
            Map(x => x.StatusCode, "status_code").Length(3).Not.Nullable();
            Map(x => x.RouteId, "route_id").Length(10).Not.Nullable();
            Map(x => x.WhCode, "wh_abrv").Length(3).Not.Nullable();
            Map(x => x.VlAccountCustomerNo, "vl_acc_cus_no").Not.Nullable();
            Map(x => x.PostgresUpdateDate, "postgres_update_tms").Not.Nullable();
            Map(x => x.IsExtract, "extract_ind").Not.Nullable();
            Map(x => x.VesselId, "vessel_id").Not.Nullable();
            Map(x => x.ProcessCode, "process_code").Length(3).Not.Nullable();
        }
    }
}