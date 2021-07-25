using System;

using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {

    public class ManifestDropSeq
    {
        public virtual int ManifestId {get; set;}
        public virtual int SeqNo {get; set;}
        public virtual int BookingNo {get; set;}
        public virtual int BookingVehicleNo {get; set;}
        public virtual string StopPointName {get; set;}
        public virtual string StopPointSuburb {get; set;}
        public virtual string StopPointState {get; set;}
        public virtual string StopPointType {get; set;}
        public virtual DateTime EntryDate {get; set;}
        public virtual string OperatorId {get; set;}
        public virtual string LocationId {get; set;}
        public virtual int IsSurveyRequired {get; set;}
        public virtual string StopPointAddress {get; set;}
        public virtual string StatusCode {get; set;}
        public virtual DateTime StatusDate {get; set;}
        public virtual int IsDamaged {get; set;}
      
        protected bool Equals(ManifestDropSeq other)
        {
            if (other == null)
            {
                return false;
            }

            return ManifestId.Equals(other.ManifestId)
                   && SeqNo.Equals(other.SeqNo)
                   && BookingNo.Equals(other.BookingNo)
                   && BookingVehicleNo.Equals(other.BookingVehicleNo)
                   && StopPointName.Equals(other.StopPointName)
                   && StopPointSuburb.Equals(other.StopPointSuburb)
                   && StopPointState.Equals(other.StopPointState)
                   && StopPointType.Equals(other.StopPointType)
                   && StopPointState.Equals(other.StopPointState)
                   && EntryDate.Equals(other.EntryDate)
                   && OperatorId.Equals(other.OperatorId)
                   && LocationId.Equals(other.LocationId)
                   && IsSurveyRequired.Equals(other.IsSurveyRequired)
                   && StopPointAddress.Equals(other.StopPointAddress)
                   && StatusCode.Equals(other.StatusCode)
                   && StatusDate.Equals(other.StatusDate)
                   && IsDamaged.Equals(other.IsDamaged);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != typeof (ManifestDropSeq))
            {
                return false;
            }
            return Equals((ManifestDropSeq) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                const int hashingBase = (int) 2166136261;
                const int hashingMultiplier = 16777619;
                int hash = hashingBase;
                hash = (hash * hashingMultiplier) ^ ManifestId.GetHashCode();
                hash = (hash * hashingMultiplier) ^ SeqNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ BookingNo.GetHashCode();
                hash = (hash * hashingMultiplier) ^ BookingVehicleNo.GetHashCode();
                //hash = (hash * hashingMultiplier) ^ StopPointName?.GetHashCode() ?? 0;
                //hash = (hash * hashingMultiplier) ^ StopPointSuburb?.GetHashCode() ?? 0;
                //hash = (hash * hashingMultiplier) ^ StopPointState?.GetHashCode() ?? 0;
                //hash = (hash * hashingMultiplier) ^ StopPointType?.GetHashCode() ?? 0;
                //hash = (hash * hashingMultiplier) ^ EntryDate.GetHashCode();
                //hash = (hash * hashingMultiplier) ^ OperatorId?.GetHashCode() ?? 0;
                //hash = (hash * hashingMultiplier) ^ LocationId?.GetHashCode() ?? 0;
                //hash = (hash * hashingMultiplier) ^ IsSurveyRequired.GetHashCode();
                //hash = (hash * hashingMultiplier) ^ StopPointAddress?.GetHashCode() ?? 0;
                return hash;
            }
        }
    }
    
    public class ManifestDropSeqMap: ClassMap<ManifestDropSeq>
    {
        public ManifestDropSeqMap()
        {
            Table("mft_drop_seq");
            CompositeId()
                .KeyProperty(x => x.ManifestId, keyPropertyAction: k =>
                {
                    k.ColumnName("manifest_id");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
                .KeyProperty(x => x.SeqNo, keyPropertyAction: k =>
                {
                    k.ColumnName("seq_no");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
                .KeyProperty(x => x.BookingNo, keyPropertyAction: k =>
                {
                    k.ColumnName("bkg_no");
                    k.Type(typeof(int));
                    k.Access.Property();
                })
                .KeyProperty(x => x.BookingVehicleNo, keyPropertyAction: k =>
                {
                    k.ColumnName("bkg_veh_no");
                    k.Type(typeof(int));
                    k.Access.Property();
                });

            //Map(x => x.ManifestId, "manifest_id").Not.Nullable();
            //Map(x => x.SeqNo, "seq_no").Not.Nullable();
            //Map(x => x.BookingNo, "bkg_no").Not.Nullable();
            //Map(x => x.BookingVehicleNo, "bkg_veh_no").Not.Nullable();
            Map(x => x.StopPointName, "stop_pt_name").Length(30).Not.Nullable();
            Map(x => x.StopPointSuburb, "stop_pt_suburb").Length(20).Not.Nullable();
            Map(x => x.StopPointState, "stop_pt_state").Length(3).Not.Nullable();
            Map(x => x.StopPointType, "stop_pt_type").Length(3).Not.Nullable();
            Map(x => x.EntryDate, "entry_tms").Not.Nullable();
            Map(x => x.OperatorId, "operator_id").Length(8).Not.Nullable();
            Map(x => x.LocationId, "location_id").Length(30).Not.Nullable();
            Map(x => x.IsSurveyRequired, "is_survey_required").Not.Nullable();
            Map(x => x.StopPointAddress, "stop_pt_address").Length(35).Not.Nullable();
            Map(x => x.StatusCode, "status_code").Length(3).Not.Nullable();
            Map(x => x.StatusDate, "status_tms").Not.Nullable();
            Map(x => x.IsDamaged, "is_damaged").Not.Nullable();

        }
    }
}