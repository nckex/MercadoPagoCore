using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MercadoPagoCore.Common
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProcessingMode
    {
        /// <summary> Payments will be processed with MercadoPago merchant numbers </summary>
        aggregator,
        /// <summary> Payments will be processed with your own merchant numbers </summary>
        gateway
    }
}
