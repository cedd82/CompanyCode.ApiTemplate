using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class ModelType
    {

        public virtual int ModelCode {get; set;}
        public virtual string Description {get; set;}
        public virtual int MakeCode {get; set;}
        public virtual int IsLogDelete {get; set;}
        public virtual int IsWeb {get; set;}
        public virtual string StartChars {get; set;}
        public virtual int StartPos {get; set;}
        public virtual int EndPos {get; set;}
        public virtual int VinLength {get; set;}
}


    public class ModelTypeMap: ClassMap<ModelType>
    {
        public ModelTypeMap()
        {
            Table("model_type");
            Id(x => x.ModelCode, "model_code")
                .Access.Property()
                .Unique()
                .GeneratedBy.Assigned();

            Map(x => x.ModelCode, "model_code").Not.Nullable();
            Map(x => x.Description, "description").Length(20).Not.Nullable();
            Map(x => x.MakeCode, "make_code").Not.Nullable();
            Map(x => x.IsLogDelete, "log_del_ind").Not.Nullable();
            Map(x => x.IsWeb, "web_ind").Not.Nullable();
            Map(x => x.StartChars, "start_chars").Length(20).Not.Nullable();
            Map(x => x.StartPos, "start_pos").Not.Nullable();
            Map(x => x.EndPos, "end_pos").Not.Nullable();
            Map(x => x.VinLength, "vin_length").Not.Nullable();
        }
    }
}