using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities
{
    public class AccountCustomerCeiling
    {

        public virtual int AccountCustomerNo {get; set;}
        public virtual float WeightCeiling {get; set;}
        public virtual float VolumeCeiling {get; set;}
}


    public class AccountCustomerCeilingMap: ClassMap<AccountCustomerCeiling>
    {
        public AccountCustomerCeilingMap()
        {
            Table("acc_cus_ceiling");
            Id(x => x.AccountCustomerNo, "acc_cus_no")
                .Access.Property()
                .GeneratedBy.Assigned()
                .Length(11);
            Map(x => x.VolumeCeiling, "volume_ceiling").Length(15).Not.Nullable();
            Map(x => x.WeightCeiling, "weight_ceiling").Length(15).Not.Nullable();
        }
    }
}