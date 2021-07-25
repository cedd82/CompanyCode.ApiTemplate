using System;

using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class VlVisLoadPlan
    {

        public virtual string DepotCode {get; set;}
        public virtual int LoadId {get; set;}
        public virtual string DealerCode {get; set;}
        public virtual DateTime AvailableTime {get; set;}
        public virtual int NoOfVehicle {get; set;}
        public virtual int 	ManifestId  {get; set;}
        public virtual string OperatorId {get; set;}
        public virtual DateTime StatusDate {get; set;}
        public virtual string Suburb {get; set;}
        public virtual string State {get; set;}
        public virtual string Name {get; set;}
        public virtual int NoOfVehicleScanned {get; set;}

         protected bool Equals(VlVisLoadPlan other)
        {
            if (other == null)
            {
                return false;
            }

            return DepotCode.Equals(other.DepotCode)
                   && LoadId.Equals(other.LoadId)
                   && DealerCode.Equals(other.DealerCode)
                   && AvailableTime.Equals(other.AvailableTime)
                   && NoOfVehicle.Equals(other.NoOfVehicle)
                   && ManifestId.Equals(other.ManifestId)
                   && OperatorId.Equals(other.OperatorId)
                   && StatusDate.Equals(other.StatusDate)
                   && Suburb.Equals(other.Suburb)
                   && State.Equals(other.State)
                   && Name.Equals(other.Name)
                   && NoOfVehicleScanned.Equals(other.NoOfVehicleScanned);

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
            if (obj.GetType() != typeof (VlVisLoadPlan))
            {
                return false;
            }
            return Equals((VlVisLoadPlan) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                const int hashingBase = (int) 2166136261;
                const int hashingMultiplier = 16777619;
                int hash = hashingBase;
                hash = (hash * hashingMultiplier) ^ DepotCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ LoadId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ DealerCode?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ NoOfVehicle.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ManifestId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ OperatorId?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ AvailableTime.GetHashCode();
                hash = (hash * hashingMultiplier) ^ StatusDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ Suburb?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ State?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ Name?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ NoOfVehicleScanned;
                return hash;
            }
        }
}


    public class VlVisLoadPlanMap: ClassMap<VlVisLoadPlan>
    {
        public VlVisLoadPlanMap()
        {
            Table("vl_vis_load_plan");
            CompositeId()
                .KeyProperty(x => x.DepotCode, keyPropertyAction: k =>
                {
                    k.ColumnName("depot_abrv");
                    k.Type(typeof(string));
                    k.Access.Property();
                })
                .KeyProperty(x => x.LoadId, keyPropertyAction: k =>
                {
                    k.ColumnName("load_id");
                    k.Type(typeof(int));
                    k.Access.Property();
                });

            Map(x => x.DepotCode, "depot_abrv").Length(3).Not.Nullable();
            Map(x => x.LoadId, "load_id").Not.Nullable();
            Map(x => x.DealerCode, "dealer_code").Length(8).Not.Nullable();
            Map(x => x.AvailableTime, "avlb_tms").Not.Nullable();
            Map(x => x.NoOfVehicle, "no_of_veh").Not.Nullable();
            Map(x => x.ManifestId, "manifest_id").Not.Nullable();
            Map(x => x.OperatorId, "operator_id").Length(8).Not.Nullable();
            Map(x => x.StatusDate, "status_tms").Not.Nullable();
            Map(x => x.Suburb, "suburb").Length(20).Not.Nullable();
            Map(x => x.State, "state").Length(3).Not.Nullable();
            Map(x => x.Name, "name").Length(30).Not.Nullable();
            Map(x => x.NoOfVehicleScanned, "no_of_veh_scanned").Not.Nullable();
        }
    }
}