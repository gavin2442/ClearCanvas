﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Enterprise.Core {
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
    internal class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ClearCanvas.Enterprise.Core.SR", typeof(SR).Assembly);
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
        ///   Looks up a localized string similar to An audit request with an empty log entry was received and will be ignored..
        /// </summary>
        internal static string ErrorEmptyAuditRequest {
            get {
                return ResourceManager.GetString("ErrorEmptyAuditRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A null audit request was received and will be ignored..
        /// </summary>
        internal static string ErrorNullAuditRequest {
            get {
                return ResourceManager.GetString("ErrorNullAuditRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation could not complete because it was deadlocked with another operation..
        /// </summary>
        internal static string ExceptionDeadlockDetected {
            get {
                return ResourceManager.GetString("ExceptionDeadlockDetected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The entity was not found..
        /// </summary>
        internal static string ExceptionEntityNotFound {
            get {
                return ResourceManager.GetString("ExceptionEntityNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entity version does not match the version in the database (OID: {0})..
        /// </summary>
        internal static string ExceptionEntityVersion {
            get {
                return ResourceManager.GetString("ExceptionEntityVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The enumeration value {0} was not found for class {1}..
        /// </summary>
        internal static string ExceptionEnumValueNotFound {
            get {
                return ResourceManager.GetString("ExceptionEnumValueNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected string value..
        /// </summary>
        internal static string ExceptionExpectedStringValue {
            get {
                return ResourceManager.GetString("ExceptionExpectedStringValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot inherit read-context as an update-context..
        /// </summary>
        internal static string ExceptionIncompatiblePersistenceContext {
            get {
                return ResourceManager.GetString("ExceptionIncompatiblePersistenceContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid {0}..
        /// </summary>
        internal static string ExceptionInvalidEntity {
            get {
                return ResourceManager.GetString("ExceptionInvalidEntity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Persistence context required..
        /// </summary>
        internal static string ExceptionPersistenceContextRequired {
            get {
                return ResourceManager.GetString("ExceptionPersistenceContextRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is invalid..
        /// </summary>
        internal static string RuleEmbeddeValue {
            get {
                return ResourceManager.GetString("RuleEmbeddeValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more {0} are invalid..
        /// </summary>
        internal static string RuleEmbeddeValueCollection {
            get {
                return ResourceManager.GetString("RuleEmbeddeValueCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} must be between {1} and {2} characters..
        /// </summary>
        internal static string RuleLength {
            get {
                return ResourceManager.GetString("RuleLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is required..
        /// </summary>
        internal static string RuleRequired {
            get {
                return ResourceManager.GetString("RuleRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} conflicts with an existing {1}..
        /// </summary>
        internal static string RuleUniqueKey {
            get {
                return ResourceManager.GetString("RuleUniqueKey", resourceCulture);
            }
        }
    }
}
