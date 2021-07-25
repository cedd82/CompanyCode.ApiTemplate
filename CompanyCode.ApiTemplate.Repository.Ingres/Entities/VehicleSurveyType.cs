using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class VehicleSurveyType
    {

        public virtual int SurveyCode {get; set;}
        public virtual string Description {get; set;}
        public virtual int IsOe {get; set;}
        public virtual int IsEnabled {get; set;}
        public virtual string CategoryCode {get; set;}
        public virtual string SurveyConditionName {get; set;}
        public virtual string SurveyDescription {get; set;}
        public virtual string SurveyDamageName {get; set;}
        public virtual int IsSilhouette {get; set;}
        public virtual string SurveySilhouetteName {get; set;}
}


    public class VehicleSurveyTypeMap: ClassMap<VehicleSurveyType>
    {
        public VehicleSurveyTypeMap()
        {
            Table("veh_survey_type");
            Id(x => x.SurveyCode, "survey_code")
                .Access.Property()
                .Unique()
                .Not.Nullable()
                .GeneratedBy.Assigned();

            Map(x => x.SurveyCode, "survey_code").Not.Nullable();
            Map(x => x.Description, "description").Length(20).Not.Nullable();
            Map(x => x.IsOe, "is_oe").Not.Nullable();
            Map(x => x.IsEnabled, "is_enabled").Not.Nullable();
            Map(x => x.CategoryCode, "category_code").Length(3).Not.Nullable();
            Map(x => x.SurveyConditionName, "survey_condition_name").Length(25).Not.Nullable();
            Map(x => x.SurveyDescription, "survey_description").Length(35).Not.Nullable();
            Map(x => x.SurveyDamageName, "survey_damage_name").Length(25).Not.Nullable();
            Map(x => x.IsSilhouette, "is_silhouette").Not.Nullable();
            Map(x => x.SurveySilhouetteName, "survey_silhouette_name").Length(25).Not.Nullable();
        }
    }
}