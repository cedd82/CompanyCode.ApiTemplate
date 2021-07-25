using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class ManifestStatusType
    {

        public virtual string ManifestStatusCode {get; set;}
        public virtual string Description {get; set;}
        public virtual string PartsJourneyPlanDesc {get; set;}
}


    public class ManifestStatusTypeMap: ClassMap<ManifestStatusType>
    {
        public ManifestStatusTypeMap()
        {
            Table("mft_status_type");
            Id(x => x.ManifestStatusCode, "mft_status_code")
                .Access.Property()
                //.Unique()
                .GeneratedBy.Assigned();

            Map(x => x.ManifestStatusCode, "mft_status_code").Length(3).Not.Nullable();
            Map(x => x.Description, "description").Length(20).Not.Nullable();
            Map(x => x.PartsJourneyPlanDesc, "p2_jp_desc").Length(30).Not.Nullable();
        }
    }
}