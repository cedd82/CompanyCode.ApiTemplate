using System;

using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities
{
    public class BecAuditEvent
    {
        public virtual string BusinessTypeCode { get; set; }
        public virtual string Comments { get; set; }
        public virtual DateTime EventTimeStamp { get; set; }
        public virtual int IsShowExt { get; set; }
        public virtual int LoadId { get; set; }
        public virtual int LoadItemNo { get; set; }
        public virtual DateTime SystemDate { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(BecAuditEvent))
                return false;
            return Equals((BecAuditEvent) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                const int hashingBase = (int) 2166136261;
                const int hashingMultiplier = 16777619;
                int hash = hashingBase;
                hash = (hash * hashingMultiplier) ^ (BusinessTypeCode?.GetHashCode() ?? 0);
                hash = (hash * hashingMultiplier) ^ LoadId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ LoadItemNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ EventTimeStamp.GetHashCode();
                hash = (hash * hashingMultiplier) ^ SystemDate.GetHashCode();
                hash = (hash * hashingMultiplier) ^ IsShowExt.GetHashCode();
                hash = (hash * hashingMultiplier) ^ (Comments?.GetHashCode() ?? 0);
                return hash;
            }
        }

        protected bool Equals(BecAuditEvent other)
        {
            if (other == null)
                return false;

            return BusinessTypeCode == other.BusinessTypeCode
                   && LoadId == other.LoadId
                   && LoadItemNo.Equals(other.LoadItemNo)
                   && EventTimeStamp.Equals(other.EventTimeStamp)
                   && SystemDate.Equals(other.SystemDate)
                   && IsShowExt.Equals(other.IsShowExt)
                   && Comments.Equals(other.Comments);
        }
    }

    public class BecAuditEventMap : ClassMap<BecAuditEvent>
    {
        public BecAuditEventMap()
        {
            Table("bec_audit_event");
            //CONSTRAINT BEC_AUDIT_EVENT_PK PRIMARY KEY (bus_type_code,load_id,load_item_no,event_tms)
            CompositeId()
                .KeyProperty(x => x.BusinessTypeCode, k =>
                {
                    k.ColumnName("bus_type_code");
                    k.Type(typeof(string));
                    k.Access.Property();
                    k.Length(2);
                })
                .KeyProperty(x => x.LoadId, k =>
                {
                    k.ColumnName("load_id");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
                .KeyProperty(x => x.LoadItemNo, k =>
                {
                    k.ColumnName("load_item_no");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
                .KeyProperty(x => x.EventTimeStamp, k =>
                {
                    k.ColumnName("event_tms");
                    k.Type(typeof(DateTime));
                    k.Access.Property();
                });

            Map(x => x.BusinessTypeCode, "bus_type_code").Length(2).Not.Nullable();
            Map(x => x.LoadId, "load_id").Not.Nullable();
            Map(x => x.LoadItemNo, "load_item_no").Not.Nullable();
            Map(x => x.EventTimeStamp, "event_tms").Not.Nullable();
            Map(x => x.SystemDate, "system_tms").Not.Nullable();
            Map(x => x.IsShowExt, "show_ext_ind").Not.Nullable();
            Map(x => x.Comments, "comments").Length(100).Not.Nullable();
        }
    }
}