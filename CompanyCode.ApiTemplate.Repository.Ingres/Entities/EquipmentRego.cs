using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities
{
    public class EquipmentRego
    {

        public virtual string EquipmentType { get; set; }
        public virtual string EquipmentNo { get; set; }

        protected bool Equals(EquipmentRego other)
        {
            if (other == null)
            {
                return false;
            }

            return EquipmentType.Equals(other.EquipmentType)
                   && EquipmentNo.Equals(other.EquipmentNo);
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

            if (obj.GetType() != typeof(RtecAudit))
            {
                return false;
            }

            return Equals((RtecAudit) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                const int hashingBase = (int) 2166136261;
                const int hashingMultiplier = 16777619;
                int hash = hashingBase;
                hash = (hash * hashingMultiplier) ^ EquipmentType?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ EquipmentNo?.GetHashCode() ?? 0;
                return hash;
            }
        }

        public class EquipmentRegoMap : ClassMap<EquipmentRego>
        {
            public EquipmentRegoMap()
            {
                Table("eqp_rego");
                CompositeId()
                    .KeyProperty(x => x.EquipmentType, keyPropertyAction: k =>
                    {
                        k.ColumnName("eqp_type");
                        k.Type(typeof(string));
                        k.Access.Property();
                    })
                    .KeyProperty(x => x.EquipmentNo, keyPropertyAction: k =>
                    {
                        k.ColumnName("eqp_no");
                        k.Type(typeof(string));
                        k.Access.Property();
                    });

                Map(x => x.EquipmentType, "eqp_type").Length(3).Not.Nullable();
                Map(x => x.EquipmentNo, "eqp_no").Length(20).Not.Nullable();
            }
        }
    }
}