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

namespace JavaScriptReference.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ReferenceDBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ReferenceDBEntities object using the connection string found in the 'ReferenceDBEntities' section of the application configuration file.
        /// </summary>
        public ReferenceDBEntities() : base("name=ReferenceDBEntities", "ReferenceDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ReferenceDBEntities object.
        /// </summary>
        public ReferenceDBEntities(string connectionString) : base(connectionString, "ReferenceDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ReferenceDBEntities object.
        /// </summary>
        public ReferenceDBEntities(EntityConnection connection) : base(connection, "ReferenceDBEntities")
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
        public ObjectSet<Entry> Entries
        {
            get
            {
                if ((_Entries == null))
                {
                    _Entries = base.CreateObjectSet<Entry>("Entries");
                }
                return _Entries;
            }
        }
        private ObjectSet<Entry> _Entries;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Entries EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEntries(Entry entry)
        {
            base.AddObject("Entries", entry);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ReferenceDBModel", Name="Entry")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Entry : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Entry object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="browsers">Initial value of the Browsers property.</param>
        /// <param name="syntax">Initial value of the Syntax property.</param>
        /// <param name="shortDescription">Initial value of the ShortDescription property.</param>
        /// <param name="fullDescription">Initial value of the FullDescription property.</param>
        /// <param name="lastUpdated">Initial value of the LastUpdated property.</param>
        /// <param name="isDeleted">Initial value of the IsDeleted property.</param>
        public static Entry CreateEntry(global::System.Int32 id, global::System.String name, global::System.String browsers, global::System.String syntax, global::System.String shortDescription, global::System.String fullDescription, global::System.Int64 lastUpdated, global::System.Boolean isDeleted)
        {
            Entry entry = new Entry();
            entry.Id = id;
            entry.Name = name;
            entry.Browsers = browsers;
            entry.Syntax = syntax;
            entry.ShortDescription = shortDescription;
            entry.FullDescription = fullDescription;
            entry.LastUpdated = lastUpdated;
            entry.IsDeleted = isDeleted;
            return entry;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
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
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
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
        public global::System.String Browsers
        {
            get
            {
                return _Browsers;
            }
            set
            {
                OnBrowsersChanging(value);
                ReportPropertyChanging("Browsers");
                _Browsers = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Browsers");
                OnBrowsersChanged();
            }
        }
        private global::System.String _Browsers;
        partial void OnBrowsersChanging(global::System.String value);
        partial void OnBrowsersChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Syntax
        {
            get
            {
                return _Syntax;
            }
            set
            {
                OnSyntaxChanging(value);
                ReportPropertyChanging("Syntax");
                _Syntax = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Syntax");
                OnSyntaxChanged();
            }
        }
        private global::System.String _Syntax;
        partial void OnSyntaxChanging(global::System.String value);
        partial void OnSyntaxChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ShortDescription
        {
            get
            {
                return _ShortDescription;
            }
            set
            {
                OnShortDescriptionChanging(value);
                ReportPropertyChanging("ShortDescription");
                _ShortDescription = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ShortDescription");
                OnShortDescriptionChanged();
            }
        }
        private global::System.String _ShortDescription;
        partial void OnShortDescriptionChanging(global::System.String value);
        partial void OnShortDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FullDescription
        {
            get
            {
                return _FullDescription;
            }
            set
            {
                OnFullDescriptionChanging(value);
                ReportPropertyChanging("FullDescription");
                _FullDescription = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FullDescription");
                OnFullDescriptionChanged();
            }
        }
        private global::System.String _FullDescription;
        partial void OnFullDescriptionChanging(global::System.String value);
        partial void OnFullDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 LastUpdated
        {
            get
            {
                return _LastUpdated;
            }
            set
            {
                OnLastUpdatedChanging(value);
                ReportPropertyChanging("LastUpdated");
                _LastUpdated = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LastUpdated");
                OnLastUpdatedChanged();
            }
        }
        private global::System.Int64 _LastUpdated;
        partial void OnLastUpdatedChanging(global::System.Int64 value);
        partial void OnLastUpdatedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsDeleted
        {
            get
            {
                return _IsDeleted;
            }
            set
            {
                OnIsDeletedChanging(value);
                ReportPropertyChanging("IsDeleted");
                _IsDeleted = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsDeleted");
                OnIsDeletedChanged();
            }
        }
        private global::System.Boolean _IsDeleted;
        partial void OnIsDeletedChanging(global::System.Boolean value);
        partial void OnIsDeletedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> OwnerId
        {
            get
            {
                return _OwnerId;
            }
            set
            {
                OnOwnerIdChanging(value);
                ReportPropertyChanging("OwnerId");
                _OwnerId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OwnerId");
                OnOwnerIdChanged();
            }
        }
        private Nullable<global::System.Int32> _OwnerId;
        partial void OnOwnerIdChanging(Nullable<global::System.Int32> value);
        partial void OnOwnerIdChanged();

        #endregion
    
    }

    #endregion
    
}
