﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tests {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Tests.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to PROBLEM NAME: 	dsj1000-ThOP
        ///KNAPSACK DATA TYPE: uncorrelated
        ///DIMENSION: 1000
        ///NUMBER OF ITEMS: 9980
        ///CAPACITY OF KNAPSACK: 2275942
        ///MAX TIME: 15654897
        ///MIN SPEED: 0.10
        ///MAX SPEED: 1.00
        ///EDGE_WEIGHT_TYPE:   CEIL_2D
        ///NODE_COORD_SECTION  (INDEX, X, Y):
        ///1 981036.0 508139.0
        ///2 534120.0 -42453.0
        ///3 577878.0 -43732.0
        ///4 532890.0 -96645.0
        ///5 205322.0 215891.0
        ///6 225923.0 197950.0
        ///7 69842.0 667632.0
        ///8 391965.0 1054524.0
        ///9 310065.0 -10714.0
        ///10 247401.0 754523.0
        ///11 217951.0 218350.0
        ///12 443097.0 54051.0
        ///13 47342.0 630935.0
        ///14 317 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string big_instance {
            get {
                return ResourceManager.GetString("big_instance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PROBLEM NAME:   ex4-ThOP
        ///KNAPSACK DATA TYPE: uncorrelated
        ///DIMENSION:      4
        ///NUMBER OF ITEMS:        5
        ///CAPACITY OF KNAPSACK:   3
        ///MAX TIME:       75
        ///MIN SPEED:      0.1
        ///MAX SPEED:      1
        ///EDGE_WEIGHT_TYPE:       CEIL_2D
        ///NODE_COORD_SECTION      (INDEX, X, Y):
        ///1	 1.0	 1.0
        ///2	 6.0	 1.0
        ///3	 1.0	 7.0
        ///4	 6.0	 7.0
        ///ITEMS SECTION	(INDEX, PROFIT, WEIGHT, ASSIGNED_CITY_ID):
        ///1	 20	2	2
        ///2	 30	3	2
        ///3	100	3	3
        ///4	 40	1	3
        ///5	 40	1	3
        ///.
        /// </summary>
        internal static string instance {
            get {
                return ResourceManager.GetString("instance", resourceCulture);
            }
        }
    }
}
