using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Device.API.Models
{
    public class SmartDevice
    {
        [Key]
        public int DeviceId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(64)")]
        public string DeviceName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(128)")]
        public string DeviceCapability { get; set;}
    }
}