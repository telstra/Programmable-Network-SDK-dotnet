using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.TelstraTPN.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Endpoint {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="endpoint_uuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endpoint_uuid")]
    public string EndpointUuid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="vports", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vports")]
    public List<string> Vports { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Endpoint {\n");
      sb.Append("  EndpointUuid: ").Append(EndpointUuid).Append("\n");
      sb.Append("  Vports: ").Append(Vports).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
