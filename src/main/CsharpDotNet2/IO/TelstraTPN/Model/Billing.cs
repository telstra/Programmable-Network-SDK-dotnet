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
  public class Billing {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="billingid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingid")]
    public string Billingid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="billing-account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing-account")]
    public string BillingAccount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Billing {\n");
      sb.Append("  Billingid: ").Append(Billingid).Append("\n");
      sb.Append("  BillingAccount: ").Append(BillingAccount).Append("\n");
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
