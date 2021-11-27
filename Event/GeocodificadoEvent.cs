using BrokerCommon.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrokerCommon.Event
{
    public class GeocodificadoEvent : Event<GeocodificadoEventDto>
    {
        public GeocodificadoEvent(GeocodificadoEventDto payload) : base(payload)
        {
        }
    }
}
