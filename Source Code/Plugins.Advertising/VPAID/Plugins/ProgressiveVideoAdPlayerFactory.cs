﻿using System;
using System.Windows;
using Microsoft.SilverlightMediaFramework.Plugins.Metadata;
using Microsoft.SilverlightMediaFramework.Utilities.Extensions;
using System.ComponentModel.Composition;

namespace Microsoft.SilverlightMediaFramework.Plugins.Advertising.VPAID.Plugins
{
    /// <summary>
    /// Provides an IVpaidFactory implementation for the ProgressiveVideoAdPlayer
    /// </summary>
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [ExportGenericPlugin(PluginName = PluginName, PluginDescription = PluginDescription, PluginVersion = PluginVersion)]
    public class ProgressiveVideoAdPlayerFactory : IGenericPlugin, IVpaidFactory
    {
        private const string PluginName = "ProgressiveVideoAdPlayerFactory";
        private const string PluginDescription = "An ad player capable of playing progressive video ads without dependencies on the underlying video type.";
        private const string PluginVersion = "2.2012.0605.0";

        protected IPlayer player;

        #region IGenericPlugin
        public event Action<IPlugin, Primitives.LogEntry> LogReady;

        public event Action<IPlugin> PluginLoaded;

        public event Action<IPlugin> PluginUnloaded;

        public event Action<IPlugin, Exception> PluginLoadFailed;

        public event Action<IPlugin, Exception> PluginUnloadFailed;

        bool isLoaded;
        public bool IsLoaded
        {
            get { return isLoaded; }
        }

        public virtual void Load()
        {
            isLoaded = true;
            PluginLoaded.IfNotNull(i => i(this));
        }

        public virtual void Unload()
        {
            player = null;
            isLoaded = false;
            PluginUnloaded.IfNotNull(i => i(this));
        }

        public virtual void SetPlayer(FrameworkElement player)
        {
            this.player = player as IPlayer;
        }
        #endregion

        public virtual PriorityCriteriaEnum CheckSupport(ICreativeSource AdSource, IAdTarget AdTarget)
        {
#if !WINDOWS_PHONE && !OOB
            if (AdTarget is HtmlElementAdTarget) return PriorityCriteriaEnum.NotSupported;
#endif
            if (AdSource.MimeType == null) return PriorityCriteriaEnum.NotSupported;

#if HTTP_ONLY
            if (!AdSource.MediaSource.StartsWith("http", StringComparison.OrdinalIgnoreCase)) 
            {
                return PriorityCriteriaEnum.NotSupported;
            }
#endif

            switch (AdSource.MimeType.ToLower())
            {
                case "video/mp4":
                case "video/x-ms-wmv":
                    return PriorityCriteriaEnum.Dynamic | PriorityCriteriaEnum.Native | PriorityCriteriaEnum.Progressive;
                default:
                    return PriorityCriteriaEnum.NotSupported;
            }
        }

        public virtual IVpaid GetVpaidPlayer(ICreativeSource AdSource, IAdTarget AdTarget)
        {
            return new ProgressiveVideoAdPlayer(AdSource, AdTarget, player.ActiveMediaPlugin);
        }
    }
}
