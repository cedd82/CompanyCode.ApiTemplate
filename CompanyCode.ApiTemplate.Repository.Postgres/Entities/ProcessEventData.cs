using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyCode.ApiTemplate.Repository.Postgres.Entities
{
    [Table("process_event_data")]
    public class ProcessEventData
    {
        [Required]
        [Column("app_name")]
        [StringLength(50)]
        public string AppName { get; set; }

        [Required]
        [Column("create_date")]
        public DateTime CreateDate { get; set; }

        [Required]
        [Column("event_name")]
        [StringLength(50)]
        public string EventName { get; set; }

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("process_data", TypeName = "jsonb")]
        public string ProcessData { get; set; }

        [Column("process_data_output", TypeName = "jsonb")]
        public string ProcessDataOutput { get; set; }

        [Required]
        [Column("process_url")]
        [StringLength(150)]
        public string ProcessUrl { get; set; }

        [Required]
        [Column("status_code")]
        [StringLength(50)]
        public string StatusCode { get; set; }

        [Required]
        [Column("user_code")]
        [StringLength(50)]
        public string UserCode { get; set; }
    }
}