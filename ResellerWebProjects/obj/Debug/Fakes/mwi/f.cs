// <assemblyHash>a3b396d5</assemblyHash>
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     This source code was auto-generated by Microsoft.QualityTools.Testing.Fakes, Version=16.0.0.0.
// </auto-generated>
#pragma warning disable 0067, 0108, 0618
#line hidden
extern alias mqttf;
extern alias mwi;

[assembly: mqttf::Microsoft.QualityTools.Testing.Fakes.FakesAssembly("Microsoft.Web.Infrastructure", false)]
[assembly: global::System.Reflection.AssemblyCompany("Microsoft Corporation")]
[assembly: global::System.Reflection.AssemblyConfiguration("")]
[assembly: global::System.Reflection.AssemblyFileVersion("1.0.20105.407")]
[assembly: global::System.Reflection.AssemblyProduct("Microsoft ASP.Net WebPages")]
[assembly: global::System.Reflection.AssemblyVersion("1.0.0.0")]
[assembly: global::System.Runtime.CompilerServices.InternalsVisibleTo("System.Web.WebPages.CommonTest, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly: global::System.Runtime.CompilerServices.InternalsVisibleTo("Microsoft.Web.Infrastructure.Test, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
namespace Microsoft.Web.Infrastructure.DynamicModuleHelper.Fakes
{
    /// <summary>Shim type of Microsoft.Web.Infrastructure.DynamicModuleHelper.DynamicModuleUtility</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimClass(typeof(mwi::Microsoft.Web.Infrastructure.DynamicModuleHelper.DynamicModuleUtility))]
    [global::System.Diagnostics.DebuggerDisplay("Shim of DynamicModuleUtility")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public sealed partial class ShimDynamicModuleUtility
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBase
    {
        /// <summary>Initializes a new shim instance</summary>
        private ShimDynamicModuleUtility()
        : base(typeof(mwi::Microsoft.Web.Infrastructure.DynamicModuleHelper.DynamicModuleUtility))
        {
        }

        /// <summary>Assigns the &apos;Current&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsCurrent()
        {
            global::Microsoft.Web.Infrastructure.DynamicModuleHelper.Fakes.ShimDynamicModuleUtility.Behavior =
              mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.CurrentProxy;
        }

        /// <summary>Assigns the &apos;NotImplemented&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsNotImplemented()
        {
            global::Microsoft.Web.Infrastructure.DynamicModuleHelper.Fakes.ShimDynamicModuleUtility.Behavior =
              mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.NotImplemented;
        }

        /// <summary>Assigns the behavior for all methods of the shimmed type</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.IShimBehavior Behavior
        {
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.AttachToType
                    (typeof(mwi::Microsoft.Web.Infrastructure.DynamicModuleHelper.DynamicModuleUtility), value);
            }
        }

        /// <summary>Sets the shim of DynamicModuleUtility.RegisterModule(Type moduleType)</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<global::System.Type> RegisterModuleType
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("RegisterModule", 24)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicStatic
                    ((global::System.Delegate)value, typeof(mwi::Microsoft.Web.Infrastructure.DynamicModuleHelper.DynamicModuleUtility), 
                     "RegisterModule", typeof(void), new global::System.Type[]{typeof(global::System.Type)});
            }
        }
    }
}
namespace Microsoft.Web.Infrastructure.DynamicValidationHelper.Fakes
{
    /// <summary>Shim type of Microsoft.Web.Infrastructure.DynamicValidationHelper.ValidationUtility</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimClass(typeof(mwi::Microsoft.Web.Infrastructure.DynamicValidationHelper.ValidationUtility))]
    [global::System.Diagnostics.DebuggerDisplay("Shim of ValidationUtility")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public sealed partial class ShimValidationUtility
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBase
    {
        /// <summary>Initializes a new shim instance</summary>
        private ShimValidationUtility()
        : base(typeof(mwi::Microsoft.Web.Infrastructure.DynamicValidationHelper.ValidationUtility))
        {
        }

        /// <summary>Assigns the &apos;Current&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsCurrent()
        {
            global::Microsoft.Web.Infrastructure.DynamicValidationHelper.Fakes.ShimValidationUtility.Behavior =
              mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.CurrentProxy;
        }

        /// <summary>Assigns the &apos;NotImplemented&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsNotImplemented()
        {
            global::Microsoft.Web.Infrastructure.DynamicValidationHelper.Fakes.ShimValidationUtility.Behavior =
              mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.NotImplemented;
        }

        /// <summary>Assigns the behavior for all methods of the shimmed type</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.IShimBehavior Behavior
        {
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.AttachToType
                    (typeof(mwi::Microsoft.Web.Infrastructure.DynamicValidationHelper.ValidationUtility), value);
            }
        }

        /// <summary>Sets the shim of ValidationUtility.EnableDynamicValidation(HttpContext context)</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<global::System.Web.HttpContext> EnableDynamicValidationHttpContext
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("EnableDynamicValidation", 24)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicStatic
                    ((global::System.Delegate)value, typeof(mwi::Microsoft.Web.Infrastructure.DynamicValidationHelper.ValidationUtility), 
                     "EnableDynamicValidation", typeof(void), new global::System.Type[]{typeof(global::System.Web.HttpContext)});
            }
        }

        /// <summary>Sets the shim of ValidationUtility.GetUnvalidatedCollections(HttpContext context, Func`1&lt;NameValueCollection&gt;&amp; formGetter, Func`1&lt;NameValueCollection&gt;&amp; queryStringGetter)</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.OutOutAction<global::System.Web.HttpContext, global::System.Func<global::System.Collections.Specialized.NameValueCollection>, global::System.Func<global::System.Collections.Specialized.NameValueCollection>> GetUnvalidatedCollectionsHttpContextFuncOfNameValueCollectionOutFuncOfNameValueCollectionOut
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("GetUnvalidatedCollections", 24)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicStatic
                    ((global::System.Delegate)value, typeof(mwi::Microsoft.Web.Infrastructure.DynamicValidationHelper.ValidationUtility), 
                     "GetUnvalidatedCollections", typeof(void), new global::System.Type[]{typeof(global::System.Web.HttpContext), 
                                                                                          typeof(global::System.Func<global::System.Collections.Specialized.NameValueCollection>).MakeByRefType(), 
                                                                                          typeof(global::System.Func<global::System.Collections.Specialized.NameValueCollection>).MakeByRefType()});
            }
        }

        /// <summary>Sets the shim of ValidationUtility.IsValidationEnabled(HttpContext context)</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<global::System.Web.HttpContext, bool?> IsValidationEnabledHttpContext
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("IsValidationEnabled", 24)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicStatic
                    ((global::System.Delegate)value, typeof(mwi::Microsoft.Web.Infrastructure.DynamicValidationHelper.ValidationUtility), 
                     "IsValidationEnabled", typeof(bool?), new global::System.Type[]{typeof(global::System.Web.HttpContext)});
            }
        }
    }
}
namespace Microsoft.Web.Infrastructure.Fakes
{
    /// <summary>Shim type of Microsoft.Web.Infrastructure.HttpContextHelper</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimClass(typeof(mwi::Microsoft.Web.Infrastructure.HttpContextHelper))]
    [global::System.Diagnostics.DebuggerDisplay("Shim of HttpContextHelper")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public sealed partial class ShimHttpContextHelper
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBase
    {
        /// <summary>Initializes a new shim instance</summary>
        private ShimHttpContextHelper()
        : base(typeof(mwi::Microsoft.Web.Infrastructure.HttpContextHelper))
        {
        }

        /// <summary>Assigns the &apos;Current&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsCurrent()
        {
            global::Microsoft.Web.Infrastructure.Fakes.ShimHttpContextHelper.Behavior =
              mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.CurrentProxy;
        }

        /// <summary>Assigns the &apos;NotImplemented&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsNotImplemented()
        {
            global::Microsoft.Web.Infrastructure.Fakes.ShimHttpContextHelper.Behavior =
              mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.NotImplemented;
        }

        /// <summary>Assigns the behavior for all methods of the shimmed type</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.IShimBehavior Behavior
        {
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.AttachToType
                    (typeof(mwi::Microsoft.Web.Infrastructure.HttpContextHelper), value);
            }
        }

        /// <summary>Sets the shim of HttpContextHelper.ExecuteInNullContext(Action action)</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<global::System.Action> ExecuteInNullContextAction
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("ExecuteInNullContext", 24)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicStatic
                    ((global::System.Delegate)value, typeof(mwi::Microsoft.Web.Infrastructure.HttpContextHelper), 
                     "ExecuteInNullContext", typeof(void), new global::System.Type[]{typeof(global::System.Action)});
            }
        }

        /// <summary>Sets the shim of HttpContextHelper.SetCurrentContext(HttpContext context)</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<global::System.Web.HttpContext> SetCurrentContextHttpContext
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("SetCurrentContext", 40)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimNonPublicStatic
                    ((global::System.Delegate)value, typeof(mwi::Microsoft.Web.Infrastructure.HttpContextHelper), 
                     "SetCurrentContext", typeof(void), new global::System.Type[]{typeof(global::System.Web.HttpContext)});
            }
        }
    }
}
namespace Microsoft.Web.Infrastructure.Fakes
{
    /// <summary>Shim type of Microsoft.Web.Infrastructure.InfrastructureHelper</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimClass(typeof(mwi::Microsoft.Web.Infrastructure.InfrastructureHelper))]
    [global::System.Diagnostics.DebuggerDisplay("Shim of InfrastructureHelper")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public sealed partial class ShimInfrastructureHelper
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBase
    {
        /// <summary>Initializes a new shim instance</summary>
        private ShimInfrastructureHelper()
        : base(typeof(mwi::Microsoft.Web.Infrastructure.InfrastructureHelper))
        {
        }

        /// <summary>Assigns the &apos;Current&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsCurrent()
        {
            global::Microsoft.Web.Infrastructure.Fakes.ShimInfrastructureHelper.Behavior =
              mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.CurrentProxy;
        }

        /// <summary>Assigns the &apos;NotImplemented&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsNotImplemented()
        {
            global::Microsoft.Web.Infrastructure.Fakes.ShimInfrastructureHelper.Behavior =
              mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.NotImplemented;
        }

        /// <summary>Assigns the behavior for all methods of the shimmed type</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.IShimBehavior Behavior
        {
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.AttachToType
                    (typeof(mwi::Microsoft.Web.Infrastructure.InfrastructureHelper), value);
            }
        }

        /// <summary>Sets the shim of InfrastructureHelper.IsCodeDomDefinedExtension(String extension)</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<string, bool> IsCodeDomDefinedExtensionString
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("IsCodeDomDefinedExtension", 24)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicStatic
                    ((global::System.Delegate)value, typeof(mwi::Microsoft.Web.Infrastructure.InfrastructureHelper), 
                     "IsCodeDomDefinedExtension", typeof(bool), new global::System.Type[]{typeof(string)});
            }
        }

        /// <summary>Sets the shim of InfrastructureHelper.UnloadAppDomain()</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action UnloadAppDomain
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("UnloadAppDomain", 24)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicStatic
                    ((global::System.Delegate)value, typeof(mwi::Microsoft.Web.Infrastructure.InfrastructureHelper), 
                     "UnloadAppDomain", typeof(void), new global::System.Type[]{});
            }
        }
    }
}
