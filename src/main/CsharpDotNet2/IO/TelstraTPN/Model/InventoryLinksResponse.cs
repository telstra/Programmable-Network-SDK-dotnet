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
  public class InventoryLinksResponse {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Latency: 0=Low, 1=Standard, 2=Best Effort
    /// </summary>
    /// <value>Latency: 0=Low, 1=Standard, 2=Best Effort</value>
    [DataMember(Name="latency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latency")]
    public int? Latency { get; set; }

    /// <summary>
    /// Identifier of a link
    /// </summary>
    /// <value>Identifier of a link</value>
    [DataMember(Name="linkid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkid")]
    public string Linkid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="contracts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contracts")]
    public List<Contract> Contracts { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="tag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tag")]
    public string Tag { get; set; }

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
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="linkStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkStatus")]
    public int? LinkStatus { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="topology_tag_uuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "topology_tag_uuid")]
    public string TopologyTagUuid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="billing-id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing-id")]
    public string BillingId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InventoryLinksResponse {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Latency: ").Append(Latency).Append("\n");
      sb.Append("  Linkid: ").Append(Linkid).Append("\n");
      sb.Append("  Contracts: ").Append(Contracts).Append("\n");
      sb.Append("  Tag: ").Append(Tag).Append("\n");
      sb.Append("  Connections: ").Append(Connections).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  LinkStatus: ").Append(LinkStatus).Append("\n");
      sb.Append("  TopologyTagUuid: ").Append(TopologyTagUuid).Append("\n");
      sb.Append("  BillingId: ").Append(BillingId).Append("\n");
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
