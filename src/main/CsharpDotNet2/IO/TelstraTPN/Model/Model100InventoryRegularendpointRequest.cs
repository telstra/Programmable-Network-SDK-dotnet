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
  public class Model100InventoryRegularendpointRequest {
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
    [DataMember(Name="datacenteruuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "datacenteruuid")]
    public string Datacenteruuid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="interfacetype", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interfacetype")]
    public string Interfacetype { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Model100InventoryRegularendpointRequest {\n");
      sb.Append("  Customeruuid: ").Append(Customeruuid).Append("\n");
      sb.Append("  Datacenteruuid: ").Append(Datacenteruuid).Append("\n");
      sb.Append("  Interfacetype: ").Append(Interfacetype).Append("\n");
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
