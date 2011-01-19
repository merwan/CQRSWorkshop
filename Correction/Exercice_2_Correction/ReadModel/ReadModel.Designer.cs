﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace ReadModel
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ReadModelContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ReadModelContainer object using the connection string found in the 'ReadModelContainer' section of the application configuration file.
        /// </summary>
        public ReadModelContainer() : base("name=ReadModelContainer", "ReadModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ReadModelContainer object.
        /// </summary>
        public ReadModelContainer(string connectionString) : base(connectionString, "ReadModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ReadModelContainer object.
        /// </summary>
        public ReadModelContainer(EntityConnection connection) : base(connection, "ReadModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<MediaItem> MediaItems
        {
            get
            {
                if ((_MediaItems == null))
                {
                    _MediaItems = base.CreateObjectSet<MediaItem>("MediaItems");
                }
                return _MediaItems;
            }
        }
        private ObjectSet<MediaItem> _MediaItems;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<CustomerItem> CustomerItems
        {
            get
            {
                if ((_CustomerItems == null))
                {
                    _CustomerItems = base.CreateObjectSet<CustomerItem>("CustomerItems");
                }
                return _CustomerItems;
            }
        }
        private ObjectSet<CustomerItem> _CustomerItems;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<CustomerRentedItem> CustomerRentedItems
        {
            get
            {
                if ((_CustomerRentedItems == null))
                {
                    _CustomerRentedItems = base.CreateObjectSet<CustomerRentedItem>("CustomerRentedItems");
                }
                return _CustomerRentedItems;
            }
        }
        private ObjectSet<CustomerRentedItem> _CustomerRentedItems;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the MediaItems EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMediaItems(MediaItem mediaItem)
        {
            base.AddObject("MediaItems", mediaItem);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the CustomerItems EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCustomerItems(CustomerItem customerItem)
        {
            base.AddObject("CustomerItems", customerItem);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the CustomerRentedItems EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCustomerRentedItems(CustomerRentedItem customerRentedItem)
        {
            base.AddObject("CustomerRentedItems", customerRentedItem);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ReadModel", Name="CustomerItem")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CustomerItem : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new CustomerItem object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="canRent">Initial value of the CanRent property.</param>
        /// <param name="canReturn">Initial value of the CanReturn property.</param>
        public static CustomerItem CreateCustomerItem(global::System.Guid id, global::System.String name, global::System.Boolean canRent, global::System.Boolean canReturn)
        {
            CustomerItem customerItem = new CustomerItem();
            customerItem.Id = id;
            customerItem.Name = name;
            customerItem.CanRent = canRent;
            customerItem.CanReturn = canReturn;
            return customerItem;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean CanRent
        {
            get
            {
                return _CanRent;
            }
            set
            {
                OnCanRentChanging(value);
                ReportPropertyChanging("CanRent");
                _CanRent = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CanRent");
                OnCanRentChanged();
            }
        }
        private global::System.Boolean _CanRent;
        partial void OnCanRentChanging(global::System.Boolean value);
        partial void OnCanRentChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean CanReturn
        {
            get
            {
                return _CanReturn;
            }
            set
            {
                OnCanReturnChanging(value);
                ReportPropertyChanging("CanReturn");
                _CanReturn = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CanReturn");
                OnCanReturnChanged();
            }
        }
        private global::System.Boolean _CanReturn;
        partial void OnCanReturnChanging(global::System.Boolean value);
        partial void OnCanReturnChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ReadModel", Name="CustomerRentedItem")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CustomerRentedItem : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new CustomerRentedItem object.
        /// </summary>
        /// <param name="mediaId">Initial value of the MediaId property.</param>
        /// <param name="customerId">Initial value of the CustomerId property.</param>
        /// <param name="customerName">Initial value of the CustomerName property.</param>
        /// <param name="mediaTitle">Initial value of the MediaTitle property.</param>
        /// <param name="dueDate">Initial value of the DueDate property.</param>
        public static CustomerRentedItem CreateCustomerRentedItem(global::System.Guid mediaId, global::System.Guid customerId, global::System.String customerName, global::System.String mediaTitle, global::System.DateTime dueDate)
        {
            CustomerRentedItem customerRentedItem = new CustomerRentedItem();
            customerRentedItem.MediaId = mediaId;
            customerRentedItem.CustomerId = customerId;
            customerRentedItem.CustomerName = customerName;
            customerRentedItem.MediaTitle = mediaTitle;
            customerRentedItem.DueDate = dueDate;
            return customerRentedItem;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid MediaId
        {
            get
            {
                return _MediaId;
            }
            set
            {
                if (_MediaId != value)
                {
                    OnMediaIdChanging(value);
                    ReportPropertyChanging("MediaId");
                    _MediaId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("MediaId");
                    OnMediaIdChanged();
                }
            }
        }
        private global::System.Guid _MediaId;
        partial void OnMediaIdChanging(global::System.Guid value);
        partial void OnMediaIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid CustomerId
        {
            get
            {
                return _CustomerId;
            }
            set
            {
                if (_CustomerId != value)
                {
                    OnCustomerIdChanging(value);
                    ReportPropertyChanging("CustomerId");
                    _CustomerId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CustomerId");
                    OnCustomerIdChanged();
                }
            }
        }
        private global::System.Guid _CustomerId;
        partial void OnCustomerIdChanging(global::System.Guid value);
        partial void OnCustomerIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CustomerName
        {
            get
            {
                return _CustomerName;
            }
            set
            {
                OnCustomerNameChanging(value);
                ReportPropertyChanging("CustomerName");
                _CustomerName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CustomerName");
                OnCustomerNameChanged();
            }
        }
        private global::System.String _CustomerName;
        partial void OnCustomerNameChanging(global::System.String value);
        partial void OnCustomerNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String MediaTitle
        {
            get
            {
                return _MediaTitle;
            }
            set
            {
                OnMediaTitleChanging(value);
                ReportPropertyChanging("MediaTitle");
                _MediaTitle = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("MediaTitle");
                OnMediaTitleChanged();
            }
        }
        private global::System.String _MediaTitle;
        partial void OnMediaTitleChanging(global::System.String value);
        partial void OnMediaTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DueDate
        {
            get
            {
                return _DueDate;
            }
            set
            {
                OnDueDateChanging(value);
                ReportPropertyChanging("DueDate");
                _DueDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DueDate");
                OnDueDateChanged();
            }
        }
        private global::System.DateTime _DueDate;
        partial void OnDueDateChanging(global::System.DateTime value);
        partial void OnDueDateChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ReadModel", Name="MediaItem")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class MediaItem : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new MediaItem object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        public static MediaItem CreateMediaItem(global::System.Guid id, global::System.String title)
        {
            MediaItem mediaItem = new MediaItem();
            mediaItem.Id = id;
            mediaItem.Title = title;
            return mediaItem;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();

        #endregion
    
    }

    #endregion
    
}
