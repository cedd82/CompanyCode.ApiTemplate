using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class RtecEventType
    {

        public virtual string EventCode {get; set;}
        public virtual string Description {get; set;}
        public virtual int IsEnabled {get; set;}
}


    public class RtecEventTypeMap: ClassMap<RtecEventType>
    {
        public RtecEventTypeMap()
        {
            Table("rtec_event_type");
            Id(x => x.EventCode, "event_code")
                .Access.Property()
                .Unique()
                .Length(3).Not.Nullable()
                .GeneratedBy.Assigned();

            Map(x => x.EventCode, "event_code").Length(3).Not.Nullable();
            Map(x => x.Description, "description").Length(50).Not.Nullable();
            Map(x => x.IsEnabled, "is_enabled").Not.Nullable();
        }
    }
}
