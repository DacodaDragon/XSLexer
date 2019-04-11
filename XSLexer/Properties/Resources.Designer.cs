﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XSLexer.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("XSLexer.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to # XS dataType Configuration
        ///#
        ///# Base XS DataTypes:
        ///# - boolean
        ///# - int
        ///# - float
        ///# - string
        ///
        ///# == Allowed DataTypes
        ///XsDataTypes&gt;
        ///	int: int
        ///	float: float
        ///	string: string
        ///	boolean: boolean
        ///
        ///# == Allowed Function DataTypes
        ///XsFunctionReturnTypes&gt;
        ///	int: int
        ///	float: float
        ///	string: string
        ///	boolean: boolean
        ///	void: void.
        /// </summary>
        internal static string DataTypes {
            get {
                return ResourceManager.GetString("DataTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to # XS Tokenization chart using regular expression
        ///# 
        ///# Root		: [bool]	# Can this token be made without any prior context?
        ///# CharStart : [Regex]	# The regex that needs to be valid on the first character
        ///# CharBody	: [Regex]   # The regex that needs to be valid on all characters after the first character
        ///# WordsDef	: [Ref]		# Name to a list of words defined anywhere else in the file.		&gt;&gt; CharStart and CharBody are required.
        ///# Word		: [Regex]   # The regex with the specific word it needs to be to be that  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TokenDefinitions {
            get {
                return ResourceManager.GetString("TokenDefinitions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to void Main() {
        ///
        ///}.
        /// </summary>
        internal static string XsFunction {
            get {
                return ResourceManager.GetString("XsFunction", resourceCulture);
            }
        }
    }
}
