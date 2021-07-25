using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities
{
    public class FleetDriverUser
    {
	    public virtual string BusinessUnitCode {get; set;}
        public virtual int FleetId { get; set; }
	    public virtual int DriverId {get; set;}
        public virtual string UserCode { get; set; }
        public virtual int IsEnabled { get; set; }

        protected bool Equals(FleetDriverUser other)
        {
            if (other == null)
            {
                return false;
            }

            return FleetId == other.FleetId 
                   && DriverId == other.DriverId
                   && IsEnabled == other.IsEnabled
                   && UserCode.Equals(other.UserCode)
                   && BusinessUnitCode.Equals(other.BusinessUnitCode);
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
                hash = (hash * hashingMultiplier) ^ (BusinessUnitCode?.GetHashCode() ?? 0);
                hash = (hash * hashingMultiplier) ^ (FleetId.GetHashCode());
                hash = (hash * hashingMultiplier) ^ (DriverId.GetHashCode());
                hash = (hash * hashingMultiplier) ^ (UserCode?.GetHashCode() ?? 0);
                hash = (hash * hashingMultiplier) ^ (IsEnabled.GetHashCode());
                return hash;
            }
        }
    }

    public class FleetDriverOperatorMap : ClassMap<FleetDriverUser>
    {
        public FleetDriverOperatorMap()
        {
            //	CONSTRAINT FLEET_DRIVER_OPERATOR_PK PRIMARY KEY (bus_unit_code,fleet_id,driver_id,operator_id)
            Table("fleet_driver_operator");
            CompositeId()
                .KeyProperty(x => x.BusinessUnitCode, keyPropertyAction: k =>
                {
                    k.ColumnName("bus_unit_code");
                    k.Type(typeof(string));
                    k.Access.Property();
                    k.Length(3);
                })
                .KeyProperty(x => x.FleetId, keyPropertyAction: k =>
                {
                    k.ColumnName("fleet_id");
                    k.Type(typeof(int));
                    k.Access.Property();

                })
                .KeyProperty(x => x.DriverId, keyPropertyAction: k =>
                {
                    k.ColumnName("driver_id");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
            
            .KeyProperty(x => x.UserCode, keyPropertyAction: k =>
            {
                k.ColumnName("operator_id");
                k.Type(typeof(string));
                k.Access.Property();
                k.Length(8);
            });
            Map(x => x.IsEnabled, "is_enabled").Not.Nullable();
        }
    }
}