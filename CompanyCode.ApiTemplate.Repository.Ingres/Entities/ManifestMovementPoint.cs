using System;

using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class ManifestMovementPoint
    {
        public virtual int ManifestId {get; set;}
        public virtual int ManifestMovementPointSeqNo {get; set;}
        public virtual DateTime ActualArrivalTimeStamp {get; set;}
        public virtual DateTime ChangeEtaTimeStamp {get; set;}
        public virtual DateTime Eta {get; set;}
        public virtual string MovementPointName {get; set;}
        public virtual string MovementPointAreaAddress {get; set;}
        public virtual string MovementPointAreaAddress2 {get; set;}
        public virtual string MovementPointAreaCode {get; set;}
        public virtual string MovementPointAreaState {get; set;}
        public virtual string MovementPointAreaPostcode {get; set;}
        public virtual string MovementPointAreaClass {get; set;}
        public virtual string MovementPointCode {get; set;}
        public virtual string PointLocationCode {get; set;}
        public virtual DateTime SysEta {get; set;}
        public virtual string DepotCode {get; set;}
        public virtual int ConsignmentId {get; set;}

        protected bool Equals(ManifestMovementPoint other)
        {
            if (other == null)
            {
                return false;
            }

            return ManifestId == other.ManifestId
                   && ManifestMovementPointSeqNo == other.ManifestMovementPointSeqNo
                   && ActualArrivalTimeStamp.Equals(other.ActualArrivalTimeStamp)
                   && ChangeEtaTimeStamp.Equals(other.ChangeEtaTimeStamp)
                   && Eta.Equals(other.Eta)
                   && MovementPointName.Equals(other.MovementPointName)
                   && MovementPointAreaAddress.Equals(other.MovementPointAreaAddress)
                   && MovementPointAreaAddress2.Equals(other.MovementPointAreaAddress2)
                   && MovementPointAreaCode.Equals(other.MovementPointAreaCode)
                   && MovementPointAreaState.Equals(other.MovementPointAreaState)
                   && MovementPointAreaPostcode.Equals(other.MovementPointAreaPostcode)
                   && MovementPointAreaClass.Equals(other.MovementPointAreaClass)
                   && MovementPointCode.Equals(other.MovementPointCode)
                   && PointLocationCode.Equals(other.PointLocationCode)
                   && SysEta.Equals(other.SysEta)
                   && DepotCode.Equals(other.DepotCode)
                   && ConsignmentId.Equals(other.ConsignmentId)
                ;
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
            if (obj.GetType() != typeof (AccountCustomerBusinessUnit))
            {
                return false;
            }
            return Equals((AccountCustomerBusinessUnit) obj);
        }
        
        public override int GetHashCode()
        {
            unchecked
            {
                const int hashingBase = (int) 2166136261;
                const int hashingMultiplier = 16777619;
                int hash = hashingBase;
                hash = (hash * hashingMultiplier) ^ (ManifestId.GetHashCode());
                hash = (hash * hashingMultiplier) ^ (ManifestMovementPointSeqNo.GetHashCode());
                hash = (hash * hashingMultiplier) ^ (ActualArrivalTimeStamp.GetHashCode());
                hash = (hash * hashingMultiplier) ^ (ChangeEtaTimeStamp.GetHashCode());
                hash = (hash * hashingMultiplier) ^ (Eta.GetHashCode());
                hash = (hash * hashingMultiplier) ^ (MovementPointName?.GetHashCode() ?? 0);
                hash = (hash * hashingMultiplier) ^ (MovementPointAreaAddress?.GetHashCode() ?? 0);
                hash = (hash * hashingMultiplier) ^ (MovementPointAreaAddress2?.GetHashCode() ?? 0);
                hash = (hash * hashingMultiplier) ^ (MovementPointAreaCode?.GetHashCode() ?? 0);
                hash = (hash * hashingMultiplier) ^ (MovementPointAreaPostcode?.GetHashCode() ?? 0);
                hash = (hash * hashingMultiplier) ^ (MovementPointAreaClass?.GetHashCode() ?? 0);
                hash = (hash * hashingMultiplier) ^ (PointLocationCode?.GetHashCode() ?? 0);
                hash = (hash * hashingMultiplier) ^ (DepotCode?.GetHashCode() ?? 0);
                hash = (hash * hashingMultiplier) ^ (SysEta.GetHashCode());
                hash = (hash * hashingMultiplier) ^ (ConsignmentId.GetHashCode());
                return hash;
            }
        }
}


    public class ManifestMovementPointMap: ClassMap<ManifestMovementPoint>
    {
        public ManifestMovementPointMap()
        {
            Table("mft_mvt_pt");
            CompositeId()
                .KeyProperty(x => x.ManifestId, keyPropertyAction: k =>
                {
                    k.ColumnName("manifest_id");
                    k.Type(typeof(int));
                    k.Access.Property();
                    k.Length(3);
                })
                .KeyProperty(x => x.ManifestMovementPointSeqNo, keyPropertyAction: k =>
                {
                    k.ColumnName("mft_mvt_pt_seq_no");
                    k.Type(typeof(int));
                    k.Access.Property();

                });

            Map(x => x.ManifestId, "manifest_id").Not.Nullable().Index("mft_mvt_pt_2").Index("mft_mvt_pt_3");
            Map(x => x.ManifestMovementPointSeqNo, "mft_mvt_pt_seq_no").Not.Nullable();
            Map(x => x.ActualArrivalTimeStamp, "act_arrival_tms").Not.Nullable();
            Map(x => x.ChangeEtaTimeStamp, "chng_eta_tms").Not.Nullable();
            Map(x => x.Eta, "eta").Not.Nullable().Index("mft_mvt_pt_3");
            Map(x => x.MovementPointName, "mvt_point_name").Length(30).Not.Nullable();
            Map(x => x.MovementPointAreaAddress, "mvt_point_area_addr").Length(30).Not.Nullable();
            Map(x => x.MovementPointAreaAddress2, "mvt_point_area_addr_2").Length(30).Not.Nullable();
            Map(x => x.MovementPointAreaCode, "mvt_point_area_code").Length(20).Not.Nullable().Index("mft_mvt_pt_2");
            Map(x => x.MovementPointAreaState, "mvt_point_area_state").Length(3).Not.Nullable().Index("mft_mvt_pt_2");
            Map(x => x.MovementPointAreaPostcode, "mvt_point_area_postcode").Length(4).Not.Nullable();
            Map(x => x.MovementPointAreaClass, "mvt_point_area_class").Length(3).Not.Nullable();
            Map(x => x.MovementPointCode, "mvt_pt_code").Length(3).Not.Nullable().Index("mft_mvt_pt_2");
            Map(x => x.PointLocationCode, "pt_loc_code").Length(3).Not.Nullable();
            Map(x => x.SysEta, "sys_eta").Not.Nullable();
            Map(x => x.DepotCode, "depot_abrv").Length(3).Not.Nullable();
            Map(x => x.ConsignmentId, "cnm_id").Not.Nullable();
        }
    }
}