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
  public class Link66 {
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
    [DataMember(Name="vport", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vport")]
    public List<string> Vport { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Link66 {\n");
      sb.Append("  Linkid: ").Append(Linkid).Append("\n");
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
