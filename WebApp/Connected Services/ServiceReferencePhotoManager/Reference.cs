﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferencePhotoManager
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MediaDTO", Namespace="http://schemas.datacontract.org/2004/07/MyPhotosDatabase.Models.DTO", IsReference=true)]
    public partial class MediaDTO : object
    {
        
        private System.DateTime CreatedDateField;
        
        private bool DeletedField;
        
        private string DescriptionField;
        
        private string EventField;
        
        private string FormatField;
        
        private System.Guid IdField;
        
        private string LocationField;
        
        private string NameField;
        
        private string PathField;
        
        private string PeopleField;
        
        private string TagsField;
        
        private ServiceReferencePhotoManager.MediaType TypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedDate
        {
            get
            {
                return this.CreatedDateField;
            }
            set
            {
                this.CreatedDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Deleted
        {
            get
            {
                return this.DeletedField;
            }
            set
            {
                this.DeletedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Event
        {
            get
            {
                return this.EventField;
            }
            set
            {
                this.EventField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Format
        {
            get
            {
                return this.FormatField;
            }
            set
            {
                this.FormatField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location
        {
            get
            {
                return this.LocationField;
            }
            set
            {
                this.LocationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string People
        {
            get
            {
                return this.PeopleField;
            }
            set
            {
                this.PeopleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tags
        {
            get
            {
                return this.TagsField;
            }
            set
            {
                this.TagsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReferencePhotoManager.MediaType Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MediaType", Namespace="http://schemas.datacontract.org/2004/07/MyPhotosDatabase.Enums")]
    public enum MediaType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Video = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Photo = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferencePhotoManager.IPhotoManagerService")]
    public interface IPhotoManagerService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/SaveMedia", ReplyAction="http://tempuri.org/IMedia/SaveMediaResponse")]
        System.Threading.Tasks.Task SaveMediaAsync(ServiceReferencePhotoManager.MediaDTO mediaDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/GetMediaById", ReplyAction="http://tempuri.org/IMedia/GetMediaByIdResponse")]
        System.Threading.Tasks.Task<ServiceReferencePhotoManager.MediaDTO> GetMediaByIdAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/GetAll", ReplyAction="http://tempuri.org/IMedia/GetAllResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePhotoManager.MediaDTO>> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/GetAllWhere", ReplyAction="http://tempuri.org/IMedia/GetAllWhereResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePhotoManager.MediaDTO>> GetAllWhereAsync(string toSearch, bool byDate, bool byEvent, bool byPeople, bool byLocation, bool byTags, bool byDescription);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/UpdateMedia", ReplyAction="http://tempuri.org/IMedia/UpdateMediaResponse")]
        System.Threading.Tasks.Task UpdateMediaAsync(System.Guid id, ServiceReferencePhotoManager.MediaDTO mediaDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/DeleteMedia", ReplyAction="http://tempuri.org/IMedia/DeleteMediaResponse")]
        System.Threading.Tasks.Task DeleteMediaAsync(ServiceReferencePhotoManager.MediaDTO mediaDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/DeleteMediaById", ReplyAction="http://tempuri.org/IMedia/DeleteMediaByIdResponse")]
        System.Threading.Tasks.Task DeleteMediaByIdAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/AlreadyInDatabaseAndNotDeleted", ReplyAction="http://tempuri.org/IMedia/AlreadyInDatabaseAndNotDeletedResponse")]
        System.Threading.Tasks.Task<bool> AlreadyInDatabaseAndNotDeletedAsync(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/ConvertToBase64", ReplyAction="http://tempuri.org/IMedia/ConvertToBase64Response")]
        System.Threading.Tasks.Task<string> ConvertToBase64Async(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/GetImage", ReplyAction="http://tempuri.org/IMedia/GetImageResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> GetImageAsync(string path);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IPhotoManagerServiceChannel : ServiceReferencePhotoManager.IPhotoManagerService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class PhotoManagerServiceClient : System.ServiceModel.ClientBase<ServiceReferencePhotoManager.IPhotoManagerService>, ServiceReferencePhotoManager.IPhotoManagerService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PhotoManagerServiceClient() : 
                base(PhotoManagerServiceClient.GetDefaultBinding(), PhotoManagerServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IPhotoManagerService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PhotoManagerServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(PhotoManagerServiceClient.GetBindingForEndpoint(endpointConfiguration), PhotoManagerServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PhotoManagerServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PhotoManagerServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PhotoManagerServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PhotoManagerServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PhotoManagerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task SaveMediaAsync(ServiceReferencePhotoManager.MediaDTO mediaDTO)
        {
            return base.Channel.SaveMediaAsync(mediaDTO);
        }
        
        public System.Threading.Tasks.Task<ServiceReferencePhotoManager.MediaDTO> GetMediaByIdAsync(System.Guid id)
        {
            return base.Channel.GetMediaByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePhotoManager.MediaDTO>> GetAllAsync()
        {
            return base.Channel.GetAllAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePhotoManager.MediaDTO>> GetAllWhereAsync(string toSearch, bool byDate, bool byEvent, bool byPeople, bool byLocation, bool byTags, bool byDescription)
        {
            return base.Channel.GetAllWhereAsync(toSearch, byDate, byEvent, byPeople, byLocation, byTags, byDescription);
        }
        
        public System.Threading.Tasks.Task UpdateMediaAsync(System.Guid id, ServiceReferencePhotoManager.MediaDTO mediaDTO)
        {
            return base.Channel.UpdateMediaAsync(id, mediaDTO);
        }
        
        public System.Threading.Tasks.Task DeleteMediaAsync(ServiceReferencePhotoManager.MediaDTO mediaDTO)
        {
            return base.Channel.DeleteMediaAsync(mediaDTO);
        }
        
        public System.Threading.Tasks.Task DeleteMediaByIdAsync(System.Guid id)
        {
            return base.Channel.DeleteMediaByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task<bool> AlreadyInDatabaseAndNotDeletedAsync(string path)
        {
            return base.Channel.AlreadyInDatabaseAndNotDeletedAsync(path);
        }
        
        public System.Threading.Tasks.Task<string> ConvertToBase64Async(string path)
        {
            return base.Channel.ConvertToBase64Async(path);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> GetImageAsync(string path)
        {
            return base.Channel.GetImageAsync(path);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPhotoManagerService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPhotoManagerService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000/MyPhotos");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PhotoManagerServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IPhotoManagerService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PhotoManagerServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IPhotoManagerService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IPhotoManagerService,
        }
    }
}
