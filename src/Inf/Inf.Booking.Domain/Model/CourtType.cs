﻿using System.Runtime.Serialization;

namespace Inf.Booking.Domain.Model
{
    [DataContract]
    public enum CourtType
    {
        [EnumMember]
        Squash = 1,
        [EnumMember]
        Badminton = 2
    }
}
