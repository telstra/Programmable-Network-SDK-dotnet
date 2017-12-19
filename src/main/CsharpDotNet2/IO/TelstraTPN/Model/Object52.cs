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
  public class Object52 {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="brief_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brief_description")]
    public string BriefDescription { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="buyers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buyers")]
    public string Buyers { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="classifications", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "classifications")]
    public List<Classification> Classifications { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments")]
    public string Comments { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="create_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create_at")]
    public int? CreateAt { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="creator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creator")]
    public string Creator { get; set; }

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
    [DataMember(Name="eos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eos")]
    public string Eos { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="flavors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "flavors")]
    public List<Flavor> Flavors { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="flavors_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "flavors_price")]
    public string FlavorsPrice { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="glance_comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "glance_comments")]
    public string GlanceComments { get; set; }

    /// <summary>
    /// Gets or Sets GlanceImage
    /// </summary>
    [DataMember(Name="glance_image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "glance_image")]
    public GlanceImage GlanceImage { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="glance_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "glance_name")]
    public string GlanceName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="glance_properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "glance_properties")]
    public string GlanceProperties { get; set; }

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
    [DataMember(Name="image_format", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image_format")]
    public string ImageFormat { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="license_required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "license_required")]
    public bool? LicenseRequired { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="logo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logo")]
    public string Logo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="max_ports", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max_ports")]
    public int? MaxPorts { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="md5", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "md5")]
    public string Md5 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="min_ports", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "min_ports")]
    public int? MinPorts { get; set; }

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
    [DataMember(Name="os_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "os_version")]
    public string OsVersion { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="owner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner")]
    public string Owner { get; set; }

    /// <summary>
    /// Gets or Sets Product
    /// </summary>
    [DataMember(Name="product", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product")]
    public Product Product { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="publish_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publish_date")]
    public string PublishDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="restrict_vnc_console", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "restrict_vnc_console")]
    public bool? RestrictVncConsole { get; set; }

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
    [DataMember(Name="support_hot_plug", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "support_hot_plug")]
    public bool? SupportHotPlug { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<VnfTag> Tags { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="upload_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "upload_at")]
    public int? UploadAt { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="vendor_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendor_name")]
    public string VendorName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="zero_day_config_spec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zero_day_config_spec")]
    public string ZeroDayConfigSpec { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Object52 {\n");
      sb.Append("  BriefDescription: ").Append(BriefDescription).Append("\n");
      sb.Append("  Buyers: ").Append(Buyers).Append("\n");
      sb.Append("  Classifications: ").Append(Classifications).Append("\n");
      sb.Append("  Comments: ").Append(Comments).Append("\n");
      sb.Append("  CreateAt: ").Append(CreateAt).Append("\n");
      sb.Append("  Creator: ").Append(Creator).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Eos: ").Append(Eos).Append("\n");
      sb.Append("  Flavors: ").Append(Flavors).Append("\n");
      sb.Append("  FlavorsPrice: ").Append(FlavorsPrice).Append("\n");
      sb.Append("  GlanceComments: ").Append(GlanceComments).Append("\n");
      sb.Append("  GlanceImage: ").Append(GlanceImage).Append("\n");
      sb.Append("  GlanceName: ").Append(GlanceName).Append("\n");
      sb.Append("  GlanceProperties: ").Append(GlanceProperties).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ImageFormat: ").Append(ImageFormat).Append("\n");
      sb.Append("  LicenseRequired: ").Append(LicenseRequired).Append("\n");
      sb.Append("  Logo: ").Append(Logo).Append("\n");
      sb.Append("  MaxPorts: ").Append(MaxPorts).Append("\n");
      sb.Append("  Md5: ").Append(Md5).Append("\n");
      sb.Append("  MinPorts: ").Append(MinPorts).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
      sb.Append("  Owner: ").Append(Owner).Append("\n");
      sb.Append("  Product: ").Append(Product).Append("\n");
      sb.Append("  PublishDate: ").Append(PublishDate).Append("\n");
      sb.Append("  RestrictVncConsole: ").Append(RestrictVncConsole).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  SupportHotPlug: ").Append(SupportHotPlug).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  UploadAt: ").Append(UploadAt).Append("\n");
      sb.Append("  VendorName: ").Append(VendorName).Append("\n");
      sb.Append("  ZeroDayConfigSpec: ").Append(ZeroDayConfigSpec).Append("\n");
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
