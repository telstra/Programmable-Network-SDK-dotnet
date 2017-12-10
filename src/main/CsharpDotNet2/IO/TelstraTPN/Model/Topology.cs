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
  public class Topology {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="uuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

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
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="customer_uuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer_uuid")]
    public string CustomerUuid { get; set; }

    /// <summary>
    /// no longer used
    /// </summary>
    /// <value>no longer used</value>
    [DataMember(Name="nsd_uuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nsd_uuid")]
    public string NsdUuid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="guid_topology_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guid_topology_id")]
    public string GuidTopologyId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="created_by", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_by")]
    public string CreatedBy { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="creation_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creation_date")]
    public int? CreationDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="deletion_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deletion_date")]
    public int? DeletionDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Topology {\n");
      sb.Append("  Uuid: ").Append(Uuid).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  CustomerUuid: ").Append(CustomerUuid).Append("\n");
      sb.Append("  NsdUuid: ").Append(NsdUuid).Append("\n");
      sb.Append("  GuidTopologyId: ").Append(GuidTopologyId).Append("\n");
      sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  DeletionDate: ").Append(DeletionDate).Append("\n");
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
