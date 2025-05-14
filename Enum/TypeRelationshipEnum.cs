using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace modulum.Shared.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeRelationshipEnum
    {
        [Display(Name = "Um pra Muitos")]
        OneToMany,

        [Display(Name = "Muitos pra Um")]
        ManyToOne,

        [Display(Name = "Muitos pra Muitos")]
        ManyToMany,

        [Display(Name = "Um pra Um")]
        OneToOne
    }
}
