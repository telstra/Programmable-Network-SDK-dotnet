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
  public class Flavor {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

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
    [DataMember(Name="disk", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disk")]
    public int? Disk { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="ephemeral", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ephemeral")]
    public int? Ephemeral { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

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
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public double? Price { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="ram", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ram")]
    public int? Ram { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="specific_customer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "specific_customer")]
    public string SpecificCustomer { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="swap", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "swap")]
    public int? Swap { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="vcpus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vcpus")]
    public int? Vcpus { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Flavor {\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Disk: ").Append(Disk).Append("\n");
      sb.Append("  Ephemeral: ").Append(Ephemeral).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  Ram: ").Append(Ram).Append("\n");
      sb.Append("  SpecificCustomer: ").Append(SpecificCustomer).Append("\n");
      sb.Append("  Swap: ").Append(Swap).Append("\n");
      sb.Append("  Vcpus: ").Append(Vcpus).Append("\n");
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
