// Copyright 2018 Cohesity Inc.

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Cohesity.Models
{
    /// <summary>
    /// Specifies volume information about a Physical Protection Source.
    /// </summary>
    [DataContract]
    public partial class PhysicalVolume :  IEquatable<PhysicalVolume>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalVolume" /> class.
        /// </summary>
        /// <param name="devicePath">Specifies the path to the device that hosts the volume locally..</param>
        /// <param name="guid">Specifies an id for the Physical Volume..</param>
        /// <param name="isExtendedAttributesSupported">Specifies whether this volume supports extended attributes (like ACLs) when performing file backups..</param>
        /// <param name="isProtected">Specifies if a volume is protected by a Job..</param>
        /// <param name="label">Specifies a volume label that can be used for displaying additional identifying information about a volume..</param>
        /// <param name="logicalSizeBytes">Specifies the logical size of the volume in bytes that is not reduced by change-block tracking, compression and deduplication..</param>
        /// <param name="mountPoints">Specifies the mount points where the volume is mounted, for example: &#39;C:\\&#39;, &#39;/mnt/foo&#39; etc..</param>
        /// <param name="networkPath">Specifies the full path to connect to the network attached volume. For example, (IP or hostname):/path/to/share for NFS volumes)..</param>
        /// <param name="usedSizeBytes">Specifies the size used by the volume in bytes..</param>
        public PhysicalVolume(string devicePath = default(string), string guid = default(string), bool? isExtendedAttributesSupported = default(bool?), bool? isProtected = default(bool?), string label = default(string), long? logicalSizeBytes = default(long?), List<string> mountPoints = default(List<string>), string networkPath = default(string), long? usedSizeBytes = default(long?))
        {
            this.DevicePath = devicePath;
            this.Guid = guid;
            this.IsExtendedAttributesSupported = isExtendedAttributesSupported;
            this.IsProtected = isProtected;
            this.Label = label;
            this.LogicalSizeBytes = logicalSizeBytes;
            this.MountPoints = mountPoints;
            this.NetworkPath = networkPath;
            this.UsedSizeBytes = usedSizeBytes;
        }
        
        /// <summary>
        /// Specifies the path to the device that hosts the volume locally.
        /// </summary>
        /// <value>Specifies the path to the device that hosts the volume locally.</value>
        [DataMember(Name="devicePath", EmitDefaultValue=false)]
        public string DevicePath { get; set; }

        /// <summary>
        /// Specifies an id for the Physical Volume.
        /// </summary>
        /// <value>Specifies an id for the Physical Volume.</value>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; set; }

        /// <summary>
        /// Specifies whether this volume supports extended attributes (like ACLs) when performing file backups.
        /// </summary>
        /// <value>Specifies whether this volume supports extended attributes (like ACLs) when performing file backups.</value>
        [DataMember(Name="isExtendedAttributesSupported", EmitDefaultValue=false)]
        public bool? IsExtendedAttributesSupported { get; set; }

        /// <summary>
        /// Specifies if a volume is protected by a Job.
        /// </summary>
        /// <value>Specifies if a volume is protected by a Job.</value>
        [DataMember(Name="isProtected", EmitDefaultValue=false)]
        public bool? IsProtected { get; set; }

        /// <summary>
        /// Specifies a volume label that can be used for displaying additional identifying information about a volume.
        /// </summary>
        /// <value>Specifies a volume label that can be used for displaying additional identifying information about a volume.</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Specifies the logical size of the volume in bytes that is not reduced by change-block tracking, compression and deduplication.
        /// </summary>
        /// <value>Specifies the logical size of the volume in bytes that is not reduced by change-block tracking, compression and deduplication.</value>
        [DataMember(Name="logicalSizeBytes", EmitDefaultValue=false)]
        public long? LogicalSizeBytes { get; set; }

        /// <summary>
        /// Specifies the mount points where the volume is mounted, for example: &#39;C:\\&#39;, &#39;/mnt/foo&#39; etc.
        /// </summary>
        /// <value>Specifies the mount points where the volume is mounted, for example: &#39;C:\\&#39;, &#39;/mnt/foo&#39; etc.</value>
        [DataMember(Name="mountPoints", EmitDefaultValue=false)]
        public List<string> MountPoints { get; set; }

        /// <summary>
        /// Specifies the full path to connect to the network attached volume. For example, (IP or hostname):/path/to/share for NFS volumes).
        /// </summary>
        /// <value>Specifies the full path to connect to the network attached volume. For example, (IP or hostname):/path/to/share for NFS volumes).</value>
        [DataMember(Name="networkPath", EmitDefaultValue=false)]
        public string NetworkPath { get; set; }

        /// <summary>
        /// Specifies the size used by the volume in bytes.
        /// </summary>
        /// <value>Specifies the size used by the volume in bytes.</value>
        [DataMember(Name="usedSizeBytes", EmitDefaultValue=false)]
        public long? UsedSizeBytes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PhysicalVolume);
        }

        /// <summary>
        /// Returns true if PhysicalVolume instances are equal
        /// </summary>
        /// <param name="input">Instance of PhysicalVolume to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhysicalVolume input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DevicePath == input.DevicePath ||
                    (this.DevicePath != null &&
                    this.DevicePath.Equals(input.DevicePath))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.IsExtendedAttributesSupported == input.IsExtendedAttributesSupported ||
                    (this.IsExtendedAttributesSupported != null &&
                    this.IsExtendedAttributesSupported.Equals(input.IsExtendedAttributesSupported))
                ) && 
                (
                    this.IsProtected == input.IsProtected ||
                    (this.IsProtected != null &&
                    this.IsProtected.Equals(input.IsProtected))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.LogicalSizeBytes == input.LogicalSizeBytes ||
                    (this.LogicalSizeBytes != null &&
                    this.LogicalSizeBytes.Equals(input.LogicalSizeBytes))
                ) && 
                (
                    this.MountPoints == input.MountPoints ||
                    this.MountPoints != null &&
                    this.MountPoints.SequenceEqual(input.MountPoints)
                ) && 
                (
                    this.NetworkPath == input.NetworkPath ||
                    (this.NetworkPath != null &&
                    this.NetworkPath.Equals(input.NetworkPath))
                ) && 
                (
                    this.UsedSizeBytes == input.UsedSizeBytes ||
                    (this.UsedSizeBytes != null &&
                    this.UsedSizeBytes.Equals(input.UsedSizeBytes))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DevicePath != null)
                    hashCode = hashCode * 59 + this.DevicePath.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.IsExtendedAttributesSupported != null)
                    hashCode = hashCode * 59 + this.IsExtendedAttributesSupported.GetHashCode();
                if (this.IsProtected != null)
                    hashCode = hashCode * 59 + this.IsProtected.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.LogicalSizeBytes != null)
                    hashCode = hashCode * 59 + this.LogicalSizeBytes.GetHashCode();
                if (this.MountPoints != null)
                    hashCode = hashCode * 59 + this.MountPoints.GetHashCode();
                if (this.NetworkPath != null)
                    hashCode = hashCode * 59 + this.NetworkPath.GetHashCode();
                if (this.UsedSizeBytes != null)
                    hashCode = hashCode * 59 + this.UsedSizeBytes.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

