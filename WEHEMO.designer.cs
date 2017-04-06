﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wehemo.Business
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WeHeMo")]
	public partial class WEHEMODataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertTest(Test instance);
    partial void UpdateTest(Test instance);
    partial void DeleteTest(Test instance);
    partial void InsertTestResult(TestResult instance);
    partial void UpdateTestResult(TestResult instance);
    partial void DeleteTestResult(TestResult instance);
    partial void InsertStatusCodes(StatusCodes instance);
    partial void UpdateStatusCodes(StatusCodes instance);
    partial void DeleteStatusCodes(StatusCodes instance);
    #endregion
		
		public WEHEMODataContext() : 
				base(global::Wehemo.Business.Properties.Settings.Default.WeHeMoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WEHEMODataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WEHEMODataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WEHEMODataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WEHEMODataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<Test> Tests
		{
			get
			{
				return this.GetTable<Test>();
			}
		}
		
		public System.Data.Linq.Table<TestResult> TestResults
		{
			get
			{
				return this.GetTable<TestResult>();
			}
		}
		
		public System.Data.Linq.Table<StatusCodes> StatusCodes
		{
			get
			{
				return this.GetTable<StatusCodes>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ID;
		
		private string _Name;
		
		private string _Email;
		
		private string _Password;
		
		private System.DateTime _CreatedDate;
		
		private EntitySet<Test> _Tests;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(System.Guid value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnCreatedDateChanging(System.DateTime value);
    partial void OnCreatedDateChanged();
    #endregion
		
		public Customer()
		{
			this._Tests = new EntitySet<Test>(new Action<Test>(this.attach_Tests), new Action<Test>(this.detach_Tests));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedDate", DbType="SmallDateTime NOT NULL")]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._CreatedDate;
			}
			set
			{
				if ((this._CreatedDate != value))
				{
					this.OnCreatedDateChanging(value);
					this.SendPropertyChanging();
					this._CreatedDate = value;
					this.SendPropertyChanged("CreatedDate");
					this.OnCreatedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Test", Storage="_Tests", ThisKey="ID", OtherKey="CustomerID")]
		public EntitySet<Test> Tests
		{
			get
			{
				return this._Tests;
			}
			set
			{
				this._Tests.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Tests(Test entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_Tests(Test entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Test")]
	public partial class Test : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ID;
		
		private System.Guid _CustomerID;
		
		private string _Name;
		
		private string _URL;
		
		private System.DateTime _CreatedDate;
		
		private EntitySet<TestResult> _TestResults;
		
		private EntityRef<Customer> _Customer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(System.Guid value);
    partial void OnIDChanged();
    partial void OnCustomerIDChanging(System.Guid value);
    partial void OnCustomerIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnURLChanging(string value);
    partial void OnURLChanged();
    partial void OnCreatedDateChanging(System.DateTime value);
    partial void OnCreatedDateChanged();
    #endregion
		
		public Test()
		{
			this._TestResults = new EntitySet<TestResult>(new Action<TestResult>(this.attach_TestResults), new Action<TestResult>(this.detach_TestResults));
			this._Customer = default(EntityRef<Customer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URL", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string URL
		{
			get
			{
				return this._URL;
			}
			set
			{
				if ((this._URL != value))
				{
					this.OnURLChanging(value);
					this.SendPropertyChanging();
					this._URL = value;
					this.SendPropertyChanged("URL");
					this.OnURLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedDate", DbType="SmallDateTime NOT NULL")]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._CreatedDate;
			}
			set
			{
				if ((this._CreatedDate != value))
				{
					this.OnCreatedDateChanging(value);
					this.SendPropertyChanging();
					this._CreatedDate = value;
					this.SendPropertyChanged("CreatedDate");
					this.OnCreatedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Test_TestResult", Storage="_TestResults", ThisKey="ID", OtherKey="TestID")]
		public EntitySet<TestResult> TestResults
		{
			get
			{
				return this._TestResults;
			}
			set
			{
				this._TestResults.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Test", Storage="_Customer", ThisKey="CustomerID", OtherKey="ID", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Tests.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Tests.Add(this);
						this._CustomerID = value.ID;
					}
					else
					{
						this._CustomerID = default(System.Guid);
					}
					this.SendPropertyChanged("Customer");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_TestResults(TestResult entity)
		{
			this.SendPropertyChanging();
			entity.Test = this;
		}
		
		private void detach_TestResults(TestResult entity)
		{
			this.SendPropertyChanging();
			entity.Test = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TestResult")]
	public partial class TestResult : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ResultID;
		
		private System.Guid _TestID;
		
		private int _StatusCode;
		
		private System.DateTime _ResultDate;
		
		private EntityRef<Test> _Test;
		
		private EntityRef<StatusCodes> _StatusCodes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnResultIDChanging(System.Guid value);
    partial void OnResultIDChanged();
    partial void OnTestIDChanging(System.Guid value);
    partial void OnTestIDChanged();
    partial void OnStatusCodeChanging(int value);
    partial void OnStatusCodeChanged();
    partial void OnResultDateChanging(System.DateTime value);
    partial void OnResultDateChanged();
    #endregion
		
		public TestResult()
		{
			this._Test = default(EntityRef<Test>);
			this._StatusCodes = default(EntityRef<StatusCodes>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResultID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ResultID
		{
			get
			{
				return this._ResultID;
			}
			set
			{
				if ((this._ResultID != value))
				{
					this.OnResultIDChanging(value);
					this.SendPropertyChanging();
					this._ResultID = value;
					this.SendPropertyChanged("ResultID");
					this.OnResultIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TestID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid TestID
		{
			get
			{
				return this._TestID;
			}
			set
			{
				if ((this._TestID != value))
				{
					if (this._Test.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTestIDChanging(value);
					this.SendPropertyChanging();
					this._TestID = value;
					this.SendPropertyChanged("TestID");
					this.OnTestIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatusCode", DbType="Int NOT NULL")]
		public int StatusCode
		{
			get
			{
				return this._StatusCode;
			}
			set
			{
				if ((this._StatusCode != value))
				{
					if (this._StatusCodes.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStatusCodeChanging(value);
					this.SendPropertyChanging();
					this._StatusCode = value;
					this.SendPropertyChanged("StatusCode");
					this.OnStatusCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResultDate", DbType="DateTime NOT NULL")]
		public System.DateTime ResultDate
		{
			get
			{
				return this._ResultDate;
			}
			set
			{
				if ((this._ResultDate != value))
				{
					this.OnResultDateChanging(value);
					this.SendPropertyChanging();
					this._ResultDate = value;
					this.SendPropertyChanged("ResultDate");
					this.OnResultDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Test_TestResult", Storage="_Test", ThisKey="TestID", OtherKey="ID", IsForeignKey=true)]
		public Test Test
		{
			get
			{
				return this._Test.Entity;
			}
			set
			{
				Test previousValue = this._Test.Entity;
				if (((previousValue != value) 
							|| (this._Test.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Test.Entity = null;
						previousValue.TestResults.Remove(this);
					}
					this._Test.Entity = value;
					if ((value != null))
					{
						value.TestResults.Add(this);
						this._TestID = value.ID;
					}
					else
					{
						this._TestID = default(System.Guid);
					}
					this.SendPropertyChanged("Test");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="StatusCodes_TestResult", Storage="_StatusCodes", ThisKey="StatusCode", OtherKey="Code", IsForeignKey=true)]
		public StatusCodes StatusCodes
		{
			get
			{
				return this._StatusCodes.Entity;
			}
			set
			{
				StatusCodes previousValue = this._StatusCodes.Entity;
				if (((previousValue != value) 
							|| (this._StatusCodes.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._StatusCodes.Entity = null;
						previousValue.TestResults.Remove(this);
					}
					this._StatusCodes.Entity = value;
					if ((value != null))
					{
						value.TestResults.Add(this);
						this._StatusCode = value.Code;
					}
					else
					{
						this._StatusCode = default(int);
					}
					this.SendPropertyChanged("StatusCodes");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.StatusCodes")]
	public partial class StatusCodes : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Code;
		
		private string _Descriptions;
		
		private EntitySet<TestResult> _TestResults;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(int value);
    partial void OnCodeChanged();
    partial void OnDescriptionsChanging(string value);
    partial void OnDescriptionsChanged();
    #endregion
		
		public StatusCodes()
		{
			this._TestResults = new EntitySet<TestResult>(new Action<TestResult>(this.attach_TestResults), new Action<TestResult>(this.detach_TestResults));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._Code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descriptions", DbType="VarChar(400)")]
		public string Descriptions
		{
			get
			{
				return this._Descriptions;
			}
			set
			{
				if ((this._Descriptions != value))
				{
					this.OnDescriptionsChanging(value);
					this.SendPropertyChanging();
					this._Descriptions = value;
					this.SendPropertyChanged("Descriptions");
					this.OnDescriptionsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="StatusCodes_TestResult", Storage="_TestResults", ThisKey="Code", OtherKey="StatusCode")]
		public EntitySet<TestResult> TestResults
		{
			get
			{
				return this._TestResults;
			}
			set
			{
				this._TestResults.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_TestResults(TestResult entity)
		{
			this.SendPropertyChanging();
			entity.StatusCodes = this;
		}
		
		private void detach_TestResults(TestResult entity)
		{
			this.SendPropertyChanging();
			entity.StatusCodes = null;
		}
	}
}
#pragma warning restore 1591
