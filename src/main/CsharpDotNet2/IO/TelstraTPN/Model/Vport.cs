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
  public class Vport {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="bandwidth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bandwidth")]
    public int? Bandwidth { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="interfacesequence", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interfacesequence")]
    public int? Interfacesequence { get; set; }

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
    [DataMember(Name="vportuuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vportuuid")]
    public string Vportuuid { get; set; }

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
      sb.Append("class Vport {\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Bandwidth: ").Append(Bandwidth).Append("\n");
      sb.Append("  Interfacesequence: ").Append(Interfacesequence).Append("\n");
      sb.Append("  Vporttype: ").Append(Vporttype).Append("\n");
      sb.Append("  Vportuuid: ").Append(Vportuuid).Append("\n");
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
