﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ares.Players {
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
    internal class StringResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StringResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ares.Players.StringResources", typeof(StringResources).Assembly);
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
        ///   Looks up a localized string similar to Connected with client {0}.
        /// </summary>
        internal static string ClientConnected {
            get {
                return ResourceManager.GetString("ClientConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Closed connection with client..
        /// </summary>
        internal static string ClientDisconnected {
            get {
                return ResourceManager.GetString("ClientDisconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Got length from client: .
        /// </summary>
        internal static string ClientLengthReceived {
            get {
                return ResourceManager.GetString("ClientLengthReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error listening for client: .
        /// </summary>
        internal static string ClientListenError {
            get {
                return ResourceManager.GetString("ClientListenError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection to client lost..
        /// </summary>
        internal static string ClientSendError {
            get {
                return ResourceManager.GetString("ClientSendError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received command &apos;{0}&apos;.
        /// </summary>
        internal static string CommandReceived {
            get {
                return ResourceManager.GetString("CommandReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disconnecting on client request..
        /// </summary>
        internal static string DisconnectingClient {
            get {
                return ResourceManager.GetString("DisconnectingClient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid key code: {0}.
        /// </summary>
        internal static string InvalidKeyCode {
            get {
                return ResourceManager.GetString("InvalidKeyCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error while listening for keys: .
        /// </summary>
        internal static string KeyListenError {
            get {
                return ResourceManager.GetString("KeyListenError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received key ids: {0} {1}.
        /// </summary>
        internal static string KeyReceived {
            get {
                return ResourceManager.GetString("KeyReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Length is too high..
        /// </summary>
        internal static string LengthTooHigh {
            get {
                return ResourceManager.GetString("LengthTooHigh", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client didn&apos;t send ID.
        /// </summary>
        internal static string NoClientID {
            get {
                return ResourceManager.GetString("NoClientID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received ping..
        /// </summary>
        internal static string PingReceived {
            get {
                return ResourceManager.GetString("PingReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Ping received, assuming connection failure..
        /// </summary>
        internal static string PingTimeout {
            get {
                return ResourceManager.GetString("PingTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At element {0}: {1}.
        /// </summary>
        internal static string PlayError {
            get {
                return ResourceManager.GetString("PlayError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting UDP broadcast.
        /// </summary>
        internal static string StartBroadcast {
            get {
                return ResourceManager.GetString("StartBroadcast", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stopping UDP broadcast.
        /// </summary>
        internal static string StopBroadcast {
            get {
                return ResourceManager.GetString("StopBroadcast", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error accessing tags database: {0}.
        /// </summary>
        internal static string TagsDbError {
            get {
                return ResourceManager.GetString("TagsDbError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error sending UDP packet: .
        /// </summary>
        internal static string UDPError {
            get {
                return ResourceManager.GetString("UDPError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sending UDP packet &apos;{0}&apos;.
        /// </summary>
        internal static string UDPSending {
            get {
                return ResourceManager.GetString("UDPSending", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received volume command: type {0}, volume {1}.
        /// </summary>
        internal static string VolumeCommandReceived {
            get {
                return ResourceManager.GetString("VolumeCommandReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received out-of-range volume command.
        /// </summary>
        internal static string VolumeOutOfRange {
            get {
                return ResourceManager.GetString("VolumeOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Length is wrong..
        /// </summary>
        internal static string WrongClientLength {
            get {
                return ResourceManager.GetString("WrongClientLength", resourceCulture);
            }
        }
    }
}
