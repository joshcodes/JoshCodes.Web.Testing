﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JoshCodes.Web.Testing.Unit.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("JoshCodes.Web.Testing.Unit.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;div itemscope itemtype=&quot;http://data-vocabulary.org/Organization&quot;&gt; 
        ///&lt;h2 itemprop=&quot;name&quot;&gt;Legendary Code&lt;/h2&gt;
        ///Always on the move! This text will be displayed on the web page but won’t be machine processed because its parent tag doesn’t have a specific itemprop. 
        ///&lt;div itemprop=&quot;address&quot; itemscope itemtype=&quot;http://data-vocabulary.org/Address&quot;&gt;
        ///&lt;span itemprop=&quot;street-address&quot;&gt;E Capitol St NE &amp; 1st St&lt;/span&gt;, 
        ///&lt;span itemprop=&quot;locality&quot;&gt;Washington&lt;/span&gt;, 
        ///&lt;span itemprop=&quot;region&quot;&gt;DC&lt;/span&gt; 
        ///&lt;span itemprop=&quot; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string microdata_example1 {
            get {
                return ResourceManager.GetString("microdata_example1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Organization&quot;&gt;
        ///&lt;name&gt;Legendary Code&lt;/name&gt;
        ///&lt;address&gt;
        ///  &lt;street-address&gt;E Capitol St NE &amp; 1st St&lt;/street-address&gt;
        ///  &lt;locality&gt;Washington&lt;/locality&gt;
        ///  &lt;region&gt;DC&lt;/region&gt;
        ///  &lt;postal-code&gt;20002&lt;/postal-code&gt;
        ///&lt;/address&gt;
        ///&lt;geo&gt;
        ///    &lt;latitude&gt;38.5323 N&lt;/latitude&gt;  
        ///    &lt;longitude&gt;77.0040 W&lt;/longitude&gt;  
        ///&lt;/geo&gt;  
        ///&lt;tel&gt;555-555-5555&lt;/tel&gt;
        ///&lt;url&gt;http://www.legendarycode.com&lt;/url&gt;
        ///&lt;/Organization&gt;.
        /// </summary>
        internal static string organization {
            get {
                return ResourceManager.GetString("organization", resourceCulture);
            }
        }
    }
}
