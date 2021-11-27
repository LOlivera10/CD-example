namespace BrokerCommon.Dto
{
    public class GeolocalizacionEventDto
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Cuidad { get; set; }
        public string Codigo_Postal { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
    }
}
