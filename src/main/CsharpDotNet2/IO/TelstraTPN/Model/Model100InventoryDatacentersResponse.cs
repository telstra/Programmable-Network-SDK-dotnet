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
  public class Model100InventoryDatacentersResponse {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="cityname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cityname")]
    public string Cityname { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="countryname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "countryname")]
    public string Countryname { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="datacentername", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "datacentername")]
    public string Datacentername { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="datacentercode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "datacentercode")]
    public string Datacentercode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="datacenteruuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "datacenteruuid")]
    public string Datacenteruuid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="interfacetypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interfacetypes")]
    public List<string> Interfacetypes { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="operatorname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operatorname")]
    public string Operatorname { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Model100InventoryDatacentersResponse {\n");
      sb.Append("  Cityname: ").Append(Cityname).Append("\n");
      sb.Append("  Countryname: ").Append(Countryname).Append("\n");
      sb.Append("  Datacentername: ").Append(Datacentername).Append("\n");
      sb.Append("  Datacentercode: ").Append(Datacentercode).Append("\n");
      sb.Append("  Datacenteruuid: ").Append(Datacenteruuid).Append("\n");
      sb.Append("  Interfacetypes: ").Append(Interfacetypes).Append("\n");
      sb.Append("  Operatorname: ").Append(Operatorname).Append("\n");
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
