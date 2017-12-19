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
  public class Eis100EndpointsAssignTopologyTagRequest {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="topology_tag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "topology_tag")]
    public string TopologyTag { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Eis100EndpointsAssignTopologyTagRequest {\n");
      sb.Append("  TopologyTag: ").Append(TopologyTag).Append("\n");
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
