using BrokerCommon.Dto;

namespace BrokerCommon.Event
{
    public class GeolocalizacionEvent : Event<GeolocalizacionEventDto>
    {
        public GeolocalizacionEvent(GeolocalizacionEventDto payload) : base(payload)
        {
        }
    }
}
