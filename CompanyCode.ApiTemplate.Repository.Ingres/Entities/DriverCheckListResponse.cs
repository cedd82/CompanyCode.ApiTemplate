using System;

using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class DriverCheckListResponse
    {
        public virtual int DriverId {get; set;}
        public virtual DateTime CheckListTimeStamp {get; set;}
        public virtual int CheckListSeqNo {get; set;}
        public virtual int Capacity {get; set;}
        public virtual int IsAllOk {get; set;}
        public virtual string EquipmentNo {get; set;}
        public virtual string CheckListQuestion {get; set;}
        public virtual string DriverResponse {get; set;}
        public virtual DateTime SystemTimeStamp {get; set;}
        public virtual string Signature {get; set;}

        protected bool Equals(DriverCheckListResponse other)
        {
            if (other == null)
            {
                return false;
            }

            return DriverId.Equals(other.DriverId)
                   && CheckListTimeStamp.Equals(other.CheckListTimeStamp)
                   && CheckListSeqNo.Equals(other.CheckListSeqNo)
                   && Capacity.Equals(other.Capacity)
                   && IsAllOk.Equals(other.IsAllOk)
                   && EquipmentNo.Equals(other.EquipmentNo)
                   && CheckListQuestion.Equals(other.CheckListQuestion)
                   && DriverResponse.Equals(other.DriverResponse)
                   && SystemTimeStamp.Equals(other.SystemTimeStamp)
                   && Signature.Equals(other.Signature);
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
            if (obj.GetType() != typeof (DriverCheckListResponse))
            {
                return false;
            }
            return Equals((DriverCheckListResponse) obj);
        }
        
        public override int GetHashCode()
        {
            unchecked
            {
                const int hashingBase = (int) 2166136261;
                const int hashingMultiplier = 16777619;
                int hash = hashingBase;
                hash = (hash * hashingMultiplier) ^ DriverId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ CheckListTimeStamp.GetHashCode();
                hash = (hash * hashingMultiplier) ^ CheckListSeqNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ Capacity.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsAllOk.GetHashCode();
                hash = (hash * hashingMultiplier) ^ EquipmentNo?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ CheckListQuestion?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ DriverResponse?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ SystemTimeStamp.GetHashCode();
                hash = (hash * hashingMultiplier) ^ Signature?.GetHashCode() ?? 0;
                return hash;
            }
        }
}


    public class DriverCheckListResponseMap: ClassMap<DriverCheckListResponse>
    {
        public DriverCheckListResponseMap()
        {
            Table("driver_chklist_resp");
            CompositeId()
                .KeyProperty(x => x.DriverId, keyPropertyAction: k =>
                {
                    k.ColumnName("driver_id");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
                .KeyProperty(x => x.CheckListTimeStamp, keyPropertyAction: k =>
                {
                    k.ColumnName("chklist_tms");
                    k.Type(typeof(DateTime));
                    k.Access.Property();
                })
                .KeyProperty(x => x.CheckListSeqNo, keyPropertyAction: k =>
                {
                    k.ColumnName("chklist_seq_no");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
                .KeyProperty(x => x.Capacity, keyPropertyAction: k =>
                {
                    k.ColumnName("capacity");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
                .KeyProperty(x => x.IsAllOk, keyPropertyAction: k =>
                {
                    k.ColumnName("is_all_ok");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
                .KeyProperty(x => x.EquipmentNo, keyPropertyAction: k =>
                {
                    k.ColumnName("equipment_no");
                    k.Type(typeof(string));
                    k.Access.Property();
                    k.Length(30);
                })
                .KeyProperty(x => x.CheckListQuestion, keyPropertyAction: k =>
                {
                    k.ColumnName("chklist_question");
                    k.Type(typeof(string));
                    k.Access.Property();
                    k.Length(300);
                })
                .KeyProperty(x => x.DriverResponse, keyPropertyAction: k =>
                {
                    k.ColumnName("driver_resp");
                    k.Type(typeof(string));
                    k.Access.Property();
                    k.Length(10);
                })
                .KeyProperty(x => x.SystemTimeStamp, keyPropertyAction: k =>
                {
                    k.ColumnName("system_tms");
                    k.Type(typeof(DateTime));
                    k.Access.Property();
                    k.Length(3);
                })
                .KeyProperty(x => x.Signature, keyPropertyAction: k =>
                {
                    k.ColumnName("signature");
                    k.Type(typeof(string));
                    k.Access.Property();
                    k.Length(3000);
                });
            Map(x => x.DriverId, "driver_id").Not.Nullable();
            Map(x => x.CheckListTimeStamp, "chklist_tms").Not.Nullable();
            Map(x => x.CheckListSeqNo, "chklist_seq_no").Not.Nullable();
            Map(x => x.Capacity, "capacity").Not.Nullable();
            Map(x => x.IsAllOk, "is_all_ok").Not.Nullable();
            Map(x => x.EquipmentNo, "equipment_no").Length(30).Not.Nullable();
            Map(x => x.CheckListQuestion, "chklist_question").Length(300).Not.Nullable();
            Map(x => x.DriverResponse, "driver_resp").Length(10).Not.Nullable();
            Map(x => x.SystemTimeStamp, "system_tms").Not.Nullable();
            Map(x => x.Signature, "signature").Length(3000).Not.Nullable();
        }
    }
}