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
  public class EndpointPort {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="cabletype", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cabletype")]
    public string Cabletype { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="connectortype", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "connectortype")]
    public string Connectortype { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="cfa", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cfa")]
    public string Cfa { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="endpointuuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endpointuuid")]
    public string Endpointuuid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="interfacespeed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interfacespeed")]
    public string Interfacespeed { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="interfacetype", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interfacetype")]
    public string Interfacetype { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="vport", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vport")]
    public List<Vport> Vport { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EndpointPort {\n");
      sb.Append("  Cabletype: ").Append(Cabletype).Append("\n");
      sb.Append("  Connectortype: ").Append(Connectortype).Append("\n");
      sb.Append("  Cfa: ").Append(Cfa).Append("\n");
      sb.Append("  Endpointuuid: ").Append(Endpointuuid).Append("\n");
      sb.Append("  Interfacespeed: ").Append(Interfacespeed).Append("\n");
      sb.Append("  Interfacetype: ").Append(Interfacetype).Append("\n");
      sb.Append("  Vport: ").Append(Vport).Append("\n");
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
