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
  public class InventoryVnfVportResponse {
    /// <summary>
    /// vnfuuid which was passed in the request
    /// </summary>
    /// <value>vnfuuid which was passed in the request</value>
    [DataMember(Name="vnfuuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vnfuuid")]
    public string Vnfuuid { get; set; }

    /// <summary>
    /// uuid of the newly-created vport
    /// </summary>
    /// <value>uuid of the newly-created vport</value>
    [DataMember(Name="vnportuuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vnportuuid")]
    public string Vnportuuid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InventoryVnfVportResponse {\n");
      sb.Append("  Vnfuuid: ").Append(Vnfuuid).Append("\n");
      sb.Append("  Vnportuuid: ").Append(Vnportuuid).Append("\n");
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
