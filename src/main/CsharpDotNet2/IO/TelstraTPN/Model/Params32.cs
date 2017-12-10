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
  public class Params32 {
    /// <summary>
    /// Duration of contract in minutes
    /// </summary>
    /// <value>Duration of contract in minutes</value>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration")]
    public int? Duration { get; set; }

    /// <summary>
    /// Identifier of a link
    /// </summary>
    /// <value>Identifier of a link</value>
    [DataMember(Name="linkid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkid")]
    public string Linkid { get; set; }

    /// <summary>
    /// Identifier of a contract
    /// </summary>
    /// <value>Identifier of a contract</value>
    [DataMember(Name="contractid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contractid")]
    public string Contractid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public int? Price { get; set; }

    /// <summary>
    /// Renewal Option: 0=Auto Disconnect, 1=Auto Renew, 2=Pay per hour
    /// </summary>
    /// <value>Renewal Option: 0=Auto Disconnect, 1=Auto Renew, 2=Pay per hour</value>
    [DataMember(Name="renewal-option", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renewal-option")]
    public int? RenewalOption { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Params32 {\n");
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      sb.Append("  Linkid: ").Append(Linkid).Append("\n");
      sb.Append("  Contractid: ").Append(Contractid).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  RenewalOption: ").Append(RenewalOption).Append("\n");
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
