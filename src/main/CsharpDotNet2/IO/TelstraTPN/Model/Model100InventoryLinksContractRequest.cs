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
  public class Model100InventoryLinksContractRequest {
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
      sb.Append("class Model100InventoryLinksContractRequest {\n");
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
