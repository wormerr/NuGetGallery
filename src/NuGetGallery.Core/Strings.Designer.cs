﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGetGallery {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGetGallery.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to write audit record: &apos;{0}&apos;. Record already exists..
        /// </summary>
        internal static string CloudAuditingService_DuplicateAuditRecord {
            get {
                return ResourceManager.GetString("CloudAuditingService_DuplicateAuditRecord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No handler for the {0} command is registered..
        /// </summary>
        internal static string CommandExecutor_UnhandledCommand {
            get {
                return ResourceManager.GetString("CommandExecutor_UnhandledCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package manifest contains an ID that is too long. Package IDs can be no longer than 100 characters..
        /// </summary>
        internal static string Manifest_IdTooLong {
            get {
                return ResourceManager.GetString("Manifest_IdTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package manifest contains an invalid Dependency: &apos;{0} {1}&apos;.
        /// </summary>
        internal static string Manifest_InvalidDependency {
            get {
                return ResourceManager.GetString("Manifest_InvalidDependency", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package manifest contains an invalid ID: &apos;{0}&apos;.
        /// </summary>
        internal static string Manifest_InvalidId {
            get {
                return ResourceManager.GetString("Manifest_InvalidId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package manifest contains an invalid Minimum Client Version: &apos;{0}&apos;.
        /// </summary>
        internal static string Manifest_InvalidMinClientVersion {
            get {
                return ResourceManager.GetString("Manifest_InvalidMinClientVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package manifest contains an invalid Target Framework: &apos;{0}&apos;.
        /// </summary>
        internal static string Manifest_InvalidTargetFramework {
            get {
                return ResourceManager.GetString("Manifest_InvalidTargetFramework", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package manifest contains an invalid URL.
        /// </summary>
        internal static string Manifest_InvalidUrl {
            get {
                return ResourceManager.GetString("Manifest_InvalidUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package manifest contains an invalid Version: &apos;{0}&apos;.
        /// </summary>
        internal static string Manifest_InvalidVersion {
            get {
                return ResourceManager.GetString("Manifest_InvalidVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package manifest is missing the Id field.
        /// </summary>
        internal static string Manifest_MissingId {
            get {
                return ResourceManager.GetString("Manifest_MissingId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must be a readable stream.
        /// </summary>
        internal static string StreamMustBeReadable {
            get {
                return ResourceManager.GetString("StreamMustBeReadable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must be a seekable stream.
        /// </summary>
        internal static string StreamMustBeSeekable {
            get {
                return ResourceManager.GetString("StreamMustBeSeekable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must be a writeable stream.
        /// </summary>
        internal static string StreamMustBeWriteable {
            get {
                return ResourceManager.GetString("StreamMustBeWriteable", resourceCulture);
            }
        }
    }
}
