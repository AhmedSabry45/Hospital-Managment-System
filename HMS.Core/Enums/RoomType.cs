using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Enums
{
    public enum RoomType
    {
        [EnumMember(Value = "Private")]
        Private,

        [EnumMember(Value = "SemiPrivate")]
        SemiPrivate,

        [EnumMember(Value = "Shared")]
        Shared
    }
}
