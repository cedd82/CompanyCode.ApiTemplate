using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class Party
    {
        public virtual int PartyId {get; set;}
        public virtual string FirstName {get; set;}
        public virtual string Surname {get; set;}
        public virtual string TradingName {get; set;}
        public virtual int FatigueManaged {get; set;}
        public virtual Fleet Fleet {get; set;}
    }

    public class PartyMap: ClassMap<Party>
    {
        public PartyMap()
        {
            Table("party");
            Id(x => x.PartyId, "party_id")
                .Access.Property()
                .GeneratedBy.Assigned();
            
            HasOne( x => x.Fleet ).PropertyRef(x => x.PartyId);
            Map(x => x.PartyId, "party_id").Not.Nullable();
            Map(x => x.FirstName, "first_name").Length(30).Not.Nullable();
            Map(x => x.Surname, "surname").Length(30).Not.Nullable();
            Map(x => x.TradingName, "trading_name").Length(45).Not.Nullable();
            Map(x => x.FatigueManaged, "fatigue_managed").Not.Nullable();
        }
    }
}