﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.488
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace Microsoft.SilverlightMediaFramework.Samples.RemoteDiagnostics.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="ServiceReference1.LoggingService")]
    public interface LoggingService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:LoggingService/LogBatch", ReplyAction="urn:LoggingService/LogBatchResponse")]
        System.IAsyncResult BeginLogBatch(string BatchXml, System.AsyncCallback callback, object asyncState);
        
        System.DateTimeOffset EndLogBatch(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LoggingServiceChannel : Microsoft.SilverlightMediaFramework.Samples.RemoteDiagnostics.ServiceReference1.LoggingService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LogBatchCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public LogBatchCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.DateTimeOffset Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.DateTimeOffset)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoggingServiceClient : System.ServiceModel.ClientBase<Microsoft.SilverlightMediaFramework.Samples.RemoteDiagnostics.ServiceReference1.LoggingService>, Microsoft.SilverlightMediaFramework.Samples.RemoteDiagnostics.ServiceReference1.LoggingService {
        
        private BeginOperationDelegate onBeginLogBatchDelegate;
        
        private EndOperationDelegate onEndLogBatchDelegate;
        
        private System.Threading.SendOrPostCallback onLogBatchCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public LoggingServiceClient() {
        }
        
        public LoggingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoggingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoggingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoggingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<LogBatchCompletedEventArgs> LogBatchCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Microsoft.SilverlightMediaFramework.Samples.RemoteDiagnostics.ServiceReference1.LoggingService.BeginLogBatch(string BatchXml, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginLogBatch(BatchXml, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.DateTimeOffset Microsoft.SilverlightMediaFramework.Samples.RemoteDiagnostics.ServiceReference1.LoggingService.EndLogBatch(System.IAsyncResult result) {
            return base.Channel.EndLogBatch(result);
        }
        
        private System.IAsyncResult OnBeginLogBatch(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string BatchXml = ((string)(inValues[0]));
            return ((Microsoft.SilverlightMediaFramework.Samples.RemoteDiagnostics.ServiceReference1.LoggingService)(this)).BeginLogBatch(BatchXml, callback, asyncState);
        }
        
        private object[] OnEndLogBatch(System.IAsyncResult result) {
            System.DateTimeOffset retVal = ((Microsoft.SilverlightMediaFramework.Samples.RemoteDiagnostics.ServiceReference1.LoggingService)(this)).EndLogBatch(result);
            return new object[] {
                    retVal};
        }
        
        private void OnLogBatchCompleted(object state) {
            if ((this.LogBatchCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.LogBatchCompleted(this, new LogBatchCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void LogBatchAsync(string BatchXml) {
            this.LogBatchAsync(BatchXml, null);
        }
        
        public void LogBatchAsync(string BatchXml, object userState) {
            if ((this.onBeginLogBatchDelegate == null)) {
                this.onBeginLogBatchDelegate = new BeginOperationDelegate(this.OnBeginLogBatch);
            }
            if ((this.onEndLogBatchDelegate == null)) {
                this.onEndLogBatchDelegate = new EndOperationDelegate(this.OnEndLogBatch);
            }
            if ((this.onLogBatchCompletedDelegate == null)) {
                this.onLogBatchCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnLogBatchCompleted);
            }
            base.InvokeAsync(this.onBeginLogBatchDelegate, new object[] {
                        BatchXml}, this.onEndLogBatchDelegate, this.onLogBatchCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override Microsoft.SilverlightMediaFramework.Samples.RemoteDiagnostics.ServiceReference1.LoggingService CreateChannel() {
            return new LoggingServiceClientChannel(this);
        }
        
        private class LoggingServiceClientChannel : ChannelBase<Microsoft.SilverlightMediaFramework.Samples.RemoteDiagnostics.ServiceReference1.LoggingService>, Microsoft.SilverlightMediaFramework.Samples.RemoteDiagnostics.ServiceReference1.LoggingService {
            
            public LoggingServiceClientChannel(System.ServiceModel.ClientBase<Microsoft.SilverlightMediaFramework.Samples.RemoteDiagnostics.ServiceReference1.LoggingService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginLogBatch(string BatchXml, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = BatchXml;
                System.IAsyncResult _result = base.BeginInvoke("LogBatch", _args, callback, asyncState);
                return _result;
            }
            
            public System.DateTimeOffset EndLogBatch(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.DateTimeOffset _result = ((System.DateTimeOffset)(base.EndInvoke("LogBatch", _args, result)));
                return _result;
            }
        }
    }
}
