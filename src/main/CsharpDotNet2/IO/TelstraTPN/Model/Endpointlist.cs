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
  public class Endpointlist {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="datacenteruuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "datacenteruuid")]
    public string Datacenteruuid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="endpointuuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endpointuuid")]
    public string Endpointuuid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Endpointlist {\n");
      sb.Append("  Datacenteruuid: ").Append(Datacenteruuid).Append("\n");
      sb.Append("  Endpointuuid: ").Append(Endpointuuid).Append("\n");
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
