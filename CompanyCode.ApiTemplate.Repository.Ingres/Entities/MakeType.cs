using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class MakeType
    {

        public virtual int MakeCode {get; set;}
        public virtual string Description {get; set;}
        public virtual int IsLogDelete {get; set;}
        public virtual int IsWeb {get; set;}
        public virtual int ScanPrefixLength {get; set;}
        public virtual int ScanSuffixLength {get; set;}
        public virtual int ScanVinLength {get; set;}
    }


    public class MakeTypeMap: ClassMap<MakeType>
    {
        public MakeTypeMap()
        {
            Table("make_type");
            Id(x => x.MakeCode, "make_code")
                .Access.Property()
                .Unique()
                .Not.Nullable()
                .GeneratedBy.Assigned();

            Map(x => x.MakeCode, "make_code").Not.Nullable();
            Map(x => x.Description, "description").Length(20).Not.Nullable();
            Map(x => x.IsLogDelete, "log_del_ind").Not.Nullable();
            Map(x => x.IsWeb, "web_ind").Not.Nullable();
            Map(x => x.ScanPrefixLength, "scan_prefix_length").Not.Nullable();
            Map(x => x.ScanSuffixLength, "scan_suffix_length").Not.Nullable();
            Map(x => x.ScanVinLength, "scan_vin_length").Not.Nullable();
        }
    }
}