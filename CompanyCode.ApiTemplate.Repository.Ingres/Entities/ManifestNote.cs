using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities
{
    public class ManifestNote
    {

        public virtual int ManifestId { get; set; }
        public virtual string Note { get; set; }
    }


    public class ManifestNoteMap : ClassMap<ManifestNote>
    {
        public ManifestNoteMap()
        {
            Table("manifest_note");
            Id(x => x.ManifestId, "manifest_id")
                .Unique().Access.Property()
                .GeneratedBy.Assigned();

            Map(x => x.ManifestId, "manifest_id").Not.Nullable();
            Map(x => x.Note, "note").Length(150).Not.Nullable();
        }
    }
}