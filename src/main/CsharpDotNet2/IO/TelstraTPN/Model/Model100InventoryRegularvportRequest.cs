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
  public class Model100InventoryRegularvportRequest {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="vporttype", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vporttype")]
    public string Vporttype { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="endpointuuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endpointuuid")]
    public string Endpointuuid { get; set; }

    /// <summary>
    /// Gets or Sets Vportvalue
    /// </summary>
    [DataMember(Name="vportvalue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vportvalue")]
    public Vportvalue Vportvalue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Model100InventoryRegularvportRequest {\n");
      sb.Append("  Vporttype: ").Append(Vporttype).Append("\n");
      sb.Append("  Endpointuuid: ").Append(Endpointuuid).Append("\n");
      sb.Append("  Vportvalue: ").Append(Vportvalue).Append("\n");
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
