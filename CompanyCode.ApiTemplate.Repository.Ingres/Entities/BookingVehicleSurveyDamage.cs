using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities
{
    public class BookingVehicleSurveyDamage
    {
        public virtual int BookingNo { get; set; }
        public virtual int BookingVehicleNo { get; set; }
        public virtual string DamageRec { get; set; }
        public virtual int LineNo { get; set; }
        public virtual int ManifestId { get; set; }
        public virtual string PickupDeliveryFlg { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(BookingVehicleSurveyDamage))
                return false;
            return Equals((BookingVehicleSurveyDamage) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                const int hashingBase = (int) 2166136261;
                const int hashingMultiplier = 16777619;
                int hash = hashingBase;
                hash = (hash * hashingMultiplier) ^ BookingNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ BookingVehicleNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ ManifestId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ PickupDeliveryFlg?.GetHashCode() ?? 0;
                hash = (hash * hashingMultiplier) ^ LineNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ DamageRec?.GetHashCode() ?? 0;
                return hash;
            }
        }

        protected bool Equals(BookingVehicleSurveyDamage other)
        {
            if (other == null)
                return false;

            return BookingNo.Equals(other.BookingNo)
                   && BookingVehicleNo.Equals(other.BookingVehicleNo)
                   && ManifestId.Equals(other.ManifestId)
                   && PickupDeliveryFlg.Equals(other.PickupDeliveryFlg)
                   && LineNo.Equals(other.LineNo)
                   && DamageRec.Equals(other.DamageRec);
        }
    }

    public class BookingVehicleSurveyDamageMap : ClassMap<BookingVehicleSurveyDamage>
    {
        public BookingVehicleSurveyDamageMap()
        {
            Table("bkg_veh_survey_dmg");
            CompositeId()
                .KeyProperty(x => x.BookingNo, k =>
                {
                    k.ColumnName("bkg_no");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
                .KeyProperty(x => x.BookingVehicleNo, k =>
                {
                    k.ColumnName("bkg_veh_no");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
                .KeyProperty(x => x.ManifestId, k =>
                {
                    k.ColumnName("manifest_id");
                    k.Type(typeof(int)).Length(1);
                    k.Access.Property();
                })
                .KeyProperty(x => x.PickupDeliveryFlg, k =>
                {
                    k.ColumnName("pkup_dlvr_flg");
                    k.Type(typeof(string)).Length(1);
                    k.Access.Property();
                });

            Map(x => x.BookingNo, "bkg_no").Not.Nullable();
            Map(x => x.BookingVehicleNo, "bkg_veh_no").Not.Nullable();
            Map(x => x.ManifestId, "manifest_id").Not.Nullable();
            Map(x => x.PickupDeliveryFlg, "pkup_dlvr_flg").Length(1).Not.Nullable();
            Map(x => x.LineNo, "line_no").Not.Nullable();
            Map(x => x.DamageRec, "dmg_rec").Length(100).Not.Nullable();
        }
    }
}