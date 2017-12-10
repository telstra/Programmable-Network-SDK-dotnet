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
  public class Model100InventoryLinkRequest {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="billing-id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing-id")]
    public string BillingId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="connections", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "connections")]
    public List<string> Connections { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="tag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tag")]
    public string Tag { get; set; }

    /// <summary>
    /// Latency: 0=Low, 1=Standard, 2=Best Effort
    /// </summary>
    /// <value>Latency: 0=Low, 1=Standard, 2=Best Effort</value>
    [DataMember(Name="latency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latency")]
    public int? Latency { get; set; }

    /// <summary>
    /// Duration of contract in minutes
    /// </summary>
    /// <value>Duration of contract in minutes</value>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration")]
    public int? Duration { get; set; }

    /// <summary>
    /// Bandwidth in kB/s
    /// </summary>
    /// <value>Bandwidth in kB/s</value>
    [DataMember(Name="bandwidth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bandwidth")]
    public int? Bandwidth { get; set; }

    /// <summary>
    /// Renewal Option: 0=Auto Disconnect, 1=Auto Renew, 2=Pay per hour
    /// </summary>
    /// <value>Renewal Option: 0=Auto Disconnect, 1=Auto Renew, 2=Pay per hour</value>
    [DataMember(Name="renewal-option", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renewal-option")]
    public int? RenewalOption { get; set; }

    /// <summary>
    /// 1=VLAN, 2=VNF
    /// </summary>
    /// <value>1=VLAN, 2=VNF</value>
    [DataMember(Name="link-type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "link-type")]
    public int? LinkType { get; set; }

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
      sb.Append("class Model100InventoryLinkRequest {\n");
      sb.Append("  BillingId: ").Append(BillingId).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Connections: ").Append(Connections).Append("\n");
      sb.Append("  Tag: ").Append(Tag).Append("\n");
      sb.Append("  Latency: ").Append(Latency).Append("\n");
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      sb.Append("  Bandwidth: ").Append(Bandwidth).Append("\n");
      sb.Append("  RenewalOption: ").Append(RenewalOption).Append("\n");
      sb.Append("  LinkType: ").Append(LinkType).Append("\n");
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
