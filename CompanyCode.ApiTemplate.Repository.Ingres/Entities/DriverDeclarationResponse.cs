using System;

using FluentNHibernate.Mapping;

namespace CompanyCode.ApiTemplate.Repository.Ingres.Entities {
    public class DriverDeclarationResponse
    {

        public virtual int DriverId {get; set;}
        public virtual int SeqNo {get; set;}
        public virtual DateTime ResponseTimeStamp {get; set;}
        public virtual int QuestionId {get; set;}
        public virtual string Response {get; set;}

        protected bool Equals(DriverDeclarationResponse other)
        {
            if (other == null)
            {
                return false;
            }

            return DriverId.Equals(other.DriverId)
                   && SeqNo.Equals(other.SeqNo)
                   && ResponseTimeStamp.Equals(other.ResponseTimeStamp)
                   && QuestionId.Equals(other.QuestionId)
                   && Response.Equals(other.Response);
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
            if (obj.GetType() != typeof (DriverDeclarationResponse))
            {
                return false;
            }
            return Equals((DriverDeclarationResponse) obj);
        }
        
        public override int GetHashCode()
        {
            unchecked
            {
                const int hashingBase = (int) 2166136261;
                const int hashingMultiplier = 16777619;
                int hash = hashingBase;
                hash = (hash * hashingMultiplier) ^ (DriverId.GetHashCode());
                hash = (hash * hashingMultiplier) ^ (SeqNo.GetHashCode());
                hash = (hash * hashingMultiplier) ^ (ResponseTimeStamp.GetHashCode());
                hash = (hash * hashingMultiplier) ^ (QuestionId.GetHashCode());
                hash = (hash * hashingMultiplier) ^ (Response?.GetHashCode() ?? 0);
                return hash;
            }
        }
}


    public class DriverDeclarationResponseMap: ClassMap<DriverDeclarationResponse>
    {
        public DriverDeclarationResponseMap()
        {
            Table("driver_declaration_resp");
            CompositeId()
                .KeyProperty(x => x.DriverId, keyPropertyAction: k =>
                {
                    k.ColumnName("driver_id");
                    k.Type(typeof(int));
                    k.Access.Property();
                    k.Length(3);
                })
                .KeyProperty(x => x.SeqNo, keyPropertyAction: k =>
                {
                    k.ColumnName("fleet_id");
                    k.Type(typeof(int));
                    k.Access.Property();

                })
                .KeyProperty(x => x.ResponseTimeStamp, keyPropertyAction: k =>
                {
                    k.ColumnName("response_tms");
                    k.Type(typeof(DateTime));
                    k.Access.Property();

                });

            Map(x => x.DriverId, "driver_id").Not.Nullable();
            Map(x => x.SeqNo, "seq_no").Not.Nullable();
            Map(x => x.ResponseTimeStamp, "response_tms").Not.Nullable();
            Map(x => x.QuestionId, "question_id").Not.Nullable();
            Map(x => x.Response, "response").Length(200).Not.Nullable();
        }
    }
}