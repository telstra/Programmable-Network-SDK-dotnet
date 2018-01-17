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
  public class InventoryVnfendpointRequest {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="customeruuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customeruuid")]
    public string Customeruuid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="imageuuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "imageuuid")]
    public int? Imageuuid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="flavoruuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "flavoruuid")]
    public int? Flavoruuid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="datacenteruuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "datacenteruuid")]
    public string Datacenteruuid { get; set; }

    /// <summary>
    /// Boot configuration for VNF, base64 encoded
    /// </summary>
    /// <value>Boot configuration for VNF, base64 encoded</value>
    [DataMember(Name="config", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "config")]
    public string Config { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="topology_tag_uuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "topology_tag_uuid")]
    public string TopologyTagUuid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InventoryVnfendpointRequest {\n");
      sb.Append("  Customeruuid: ").Append(Customeruuid).Append("\n");
      sb.Append("  Imageuuid: ").Append(Imageuuid).Append("\n");
      sb.Append("  Flavoruuid: ").Append(Flavoruuid).Append("\n");
      sb.Append("  Datacenteruuid: ").Append(Datacenteruuid).Append("\n");
      sb.Append("  Config: ").Append(Config).Append("\n");
      sb.Append("  TopologyTagUuid: ").Append(TopologyTagUuid).Append("\n");
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
