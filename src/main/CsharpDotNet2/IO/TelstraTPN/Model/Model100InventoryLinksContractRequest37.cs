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
  public class Model100InventoryLinksContractRequest37 {
    /// <summary>
    /// Duration of contract in hours (not minutes)
    /// </summary>
    /// <value>Duration of contract in hours (not minutes)</value>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration")]
    public int? Duration { get; set; }

    /// <summary>
    /// Bandwidth in MB/s (not kB/s)
    /// </summary>
    /// <value>Bandwidth in MB/s (not kB/s)</value>
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Model100InventoryLinksContractRequest37 {\n");
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      sb.Append("  Bandwidth: ").Append(Bandwidth).Append("\n");
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
