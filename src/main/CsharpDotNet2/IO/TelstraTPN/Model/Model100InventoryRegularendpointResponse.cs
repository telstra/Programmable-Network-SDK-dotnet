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
  public class Model100InventoryRegularendpointResponse {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="success-auxiliary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success-auxiliary")]
    public string SuccessAuxiliary { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="success-code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success-code")]
    public int? SuccessCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="success-message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success-message")]
    public string SuccessMessage { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="endpointuuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endpointuuid")]
    public string Endpointuuid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Model100InventoryRegularendpointResponse {\n");
      sb.Append("  SuccessAuxiliary: ").Append(SuccessAuxiliary).Append("\n");
      sb.Append("  SuccessCode: ").Append(SuccessCode).Append("\n");
      sb.Append("  SuccessMessage: ").Append(SuccessMessage).Append("\n");
      sb.Append("  Endpointuuid: ").Append(Endpointuuid).Append("\n");
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
