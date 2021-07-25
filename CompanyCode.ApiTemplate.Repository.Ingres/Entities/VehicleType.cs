using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class VehicleType
    {

        public virtual int VehicleCode {get; set;}
        public virtual string Description {get; set;}
        public virtual float Weight {get; set;}
        public virtual int IsLogDelete {get; set;}
        public virtual int IsBike {get; set;}
        public virtual int SurveyCode {get; set;}
        public virtual string OeSurveyConditionName {get; set;}
        public virtual string OeSurveyDamageName {get; set;}
        public virtual string UsedSurveyConditionName {get; set;}
        public virtual string UsedSurveyDamageName {get; set;}
        public virtual string SurveySilhouetteName {get; set;}
        public virtual int IsSilhouette {get; set;}
}


    public class VehicleTypeMap: ClassMap<VehicleType>
    {
        public VehicleTypeMap()
        {
            Table("veh_type");
            Id(x => x.VehicleCode, "veh_code")
                .Access.Property()
                .Unique()
                .GeneratedBy.Assigned();

            Map(x => x.VehicleCode, "veh_code").Not.Nullable();
            Map(x => x.Description, "description").Length(20).Not.Nullable();
            Map(x => x.Weight, "weight").Not.Nullable();
            Map(x => x.IsLogDelete, "log_del_ind").Not.Nullable();
            Map(x => x.IsBike, "bike_ind").Not.Nullable();
            Map(x => x.SurveyCode, "survey_code").Not.Nullable();
            Map(x => x.OeSurveyConditionName, "oe_survey_condition_name").Length(25).Not.Nullable();
            Map(x => x.OeSurveyDamageName, "oe_survey_damage_name").Length(25).Not.Nullable();
            Map(x => x.UsedSurveyConditionName, "used_survey_condition_name").Length(25).Not.Nullable();
            Map(x => x.UsedSurveyDamageName, "used_survey_damage_name").Length(25).Not.Nullable();
            Map(x => x.SurveySilhouetteName, "survey_silhouette_name").Length(25).Not.Nullable();
            Map(x => x.IsSilhouette, "is_silhouette").Not.Nullable();
        }
    }
}