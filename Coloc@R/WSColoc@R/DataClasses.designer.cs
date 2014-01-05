﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSColocAtR
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="COLOC@R")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAuthToken(AuthToken instance);
    partial void UpdateAuthToken(AuthToken instance);
    partial void DeleteAuthToken(AuthToken instance);
    partial void InsertCity(City instance);
    partial void UpdateCity(City instance);
    partial void DeleteCity(City instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["COLOC_RConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<AuthToken> AuthTokens
		{
			get
			{
				return this.GetTable<AuthToken>();
			}
		}
		
		public System.Data.Linq.Table<City> Cities
		{
			get
			{
				return this.GetTable<City>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AuthToken")]
	public partial class AuthToken : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _token;
		
		private int _idUser;
		
		private string _ipAddress;
		
		private System.DateTime _lastActivity;
		
		private bool _fullyAuthAndOnline;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntokenChanging(string value);
    partial void OntokenChanged();
    partial void OnidUserChanging(int value);
    partial void OnidUserChanged();
    partial void OnipAddressChanging(string value);
    partial void OnipAddressChanged();
    partial void OnlastActivityChanging(System.DateTime value);
    partial void OnlastActivityChanged();
    partial void OnfullyAuthAndOnlineChanging(bool value);
    partial void OnfullyAuthAndOnlineChanged();
    #endregion
		
		public AuthToken()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_token", DbType="VarChar(255) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string token
		{
			get
			{
				return this._token;
			}
			set
			{
				if ((this._token != value))
				{
					this.OntokenChanging(value);
					this.SendPropertyChanging();
					this._token = value;
					this.SendPropertyChanged("token");
					this.OntokenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUser", DbType="Int NOT NULL")]
		public int idUser
		{
			get
			{
				return this._idUser;
			}
			set
			{
				if ((this._idUser != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidUserChanging(value);
					this.SendPropertyChanging();
					this._idUser = value;
					this.SendPropertyChanged("idUser");
					this.OnidUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ipAddress", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string ipAddress
		{
			get
			{
				return this._ipAddress;
			}
			set
			{
				if ((this._ipAddress != value))
				{
					this.OnipAddressChanging(value);
					this.SendPropertyChanging();
					this._ipAddress = value;
					this.SendPropertyChanged("ipAddress");
					this.OnipAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastActivity", DbType="DateTime NOT NULL")]
		public System.DateTime lastActivity
		{
			get
			{
				return this._lastActivity;
			}
			set
			{
				if ((this._lastActivity != value))
				{
					this.OnlastActivityChanging(value);
					this.SendPropertyChanging();
					this._lastActivity = value;
					this.SendPropertyChanged("lastActivity");
					this.OnlastActivityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fullyAuthAndOnline", DbType="Bit NOT NULL")]
		public bool fullyAuthAndOnline
		{
			get
			{
				return this._fullyAuthAndOnline;
			}
			set
			{
				if ((this._fullyAuthAndOnline != value))
				{
					this.OnfullyAuthAndOnlineChanging(value);
					this.SendPropertyChanging();
					this._fullyAuthAndOnline = value;
					this.SendPropertyChanged("fullyAuthAndOnline");
					this.OnfullyAuthAndOnlineChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_AuthToken", Storage="_User", ThisKey="idUser", OtherKey="idUser", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.AuthTokens.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.AuthTokens.Add(this);
						this._idUser = value.idUser;
					}
					else
					{
						this._idUser = default(int);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cities")]
	public partial class City : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idCity;
		
		private string _codeCity;
		
		private string _libelleCity;
		
		private EntitySet<User> _Users;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidCityChanging(int value);
    partial void OnidCityChanged();
    partial void OncodeCityChanging(string value);
    partial void OncodeCityChanged();
    partial void OnlibelleCityChanging(string value);
    partial void OnlibelleCityChanged();
    #endregion
		
		public City()
		{
			this._Users = new EntitySet<User>(new Action<User>(this.attach_Users), new Action<User>(this.detach_Users));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCity", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idCity
		{
			get
			{
				return this._idCity;
			}
			set
			{
				if ((this._idCity != value))
				{
					this.OnidCityChanging(value);
					this.SendPropertyChanging();
					this._idCity = value;
					this.SendPropertyChanged("idCity");
					this.OnidCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codeCity", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string codeCity
		{
			get
			{
				return this._codeCity;
			}
			set
			{
				if ((this._codeCity != value))
				{
					this.OncodeCityChanging(value);
					this.SendPropertyChanging();
					this._codeCity = value;
					this.SendPropertyChanged("codeCity");
					this.OncodeCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_libelleCity", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string libelleCity
		{
			get
			{
				return this._libelleCity;
			}
			set
			{
				if ((this._libelleCity != value))
				{
					this.OnlibelleCityChanging(value);
					this.SendPropertyChanging();
					this._libelleCity = value;
					this.SendPropertyChanged("libelleCity");
					this.OnlibelleCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="City_User", Storage="_Users", ThisKey="idCity", OtherKey="city")]
		public EntitySet<User> Users
		{
			get
			{
				return this._Users;
			}
			set
			{
				this._Users.Assign(value);
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
		
		private void attach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.City1 = this;
		}
		
		private void detach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.City1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idUser;
		
		private string _loginUser;
		
		private string _emailUser;
		
		private string _passwordUser;
		
		private string _firstNameUser;
		
		private string _lastNameUser;
		
		private bool _type;
		
		private int _age;
		
		private int _priceColoc;
		
		private int _city;
		
		private string _descUser;
		
		private System.Nullable<int> _m2Coloc;
		
		private System.Nullable<System.DateTime> _lastConnectionUser;
		
		private EntitySet<AuthToken> _AuthTokens;
		
		private EntityRef<City> _City1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidUserChanging(int value);
    partial void OnidUserChanged();
    partial void OnloginUserChanging(string value);
    partial void OnloginUserChanged();
    partial void OnemailUserChanging(string value);
    partial void OnemailUserChanged();
    partial void OnpasswordUserChanging(string value);
    partial void OnpasswordUserChanged();
    partial void OnfirstNameUserChanging(string value);
    partial void OnfirstNameUserChanged();
    partial void OnlastNameUserChanging(string value);
    partial void OnlastNameUserChanged();
    partial void OntypeChanging(bool value);
    partial void OntypeChanged();
    partial void OnageChanging(int value);
    partial void OnageChanged();
    partial void OnpriceColocChanging(int value);
    partial void OnpriceColocChanged();
    partial void OncityChanging(int value);
    partial void OncityChanged();
    partial void OndescUserChanging(string value);
    partial void OndescUserChanged();
    partial void Onm2ColocChanging(System.Nullable<int> value);
    partial void Onm2ColocChanged();
    partial void OnlastConnectionUserChanging(System.Nullable<System.DateTime> value);
    partial void OnlastConnectionUserChanged();
    #endregion
		
		public User()
		{
			this._AuthTokens = new EntitySet<AuthToken>(new Action<AuthToken>(this.attach_AuthTokens), new Action<AuthToken>(this.detach_AuthTokens));
			this._City1 = default(EntityRef<City>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUser", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idUser
		{
			get
			{
				return this._idUser;
			}
			set
			{
				if ((this._idUser != value))
				{
					this.OnidUserChanging(value);
					this.SendPropertyChanging();
					this._idUser = value;
					this.SendPropertyChanged("idUser");
					this.OnidUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_loginUser", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string loginUser
		{
			get
			{
				return this._loginUser;
			}
			set
			{
				if ((this._loginUser != value))
				{
					this.OnloginUserChanging(value);
					this.SendPropertyChanging();
					this._loginUser = value;
					this.SendPropertyChanged("loginUser");
					this.OnloginUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emailUser", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string emailUser
		{
			get
			{
				return this._emailUser;
			}
			set
			{
				if ((this._emailUser != value))
				{
					this.OnemailUserChanging(value);
					this.SendPropertyChanging();
					this._emailUser = value;
					this.SendPropertyChanged("emailUser");
					this.OnemailUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_passwordUser", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string passwordUser
		{
			get
			{
				return this._passwordUser;
			}
			set
			{
				if ((this._passwordUser != value))
				{
					this.OnpasswordUserChanging(value);
					this.SendPropertyChanging();
					this._passwordUser = value;
					this.SendPropertyChanged("passwordUser");
					this.OnpasswordUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_firstNameUser", DbType="VarChar(255)")]
		public string firstNameUser
		{
			get
			{
				return this._firstNameUser;
			}
			set
			{
				if ((this._firstNameUser != value))
				{
					this.OnfirstNameUserChanging(value);
					this.SendPropertyChanging();
					this._firstNameUser = value;
					this.SendPropertyChanged("firstNameUser");
					this.OnfirstNameUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastNameUser", DbType="VarChar(255)")]
		public string lastNameUser
		{
			get
			{
				return this._lastNameUser;
			}
			set
			{
				if ((this._lastNameUser != value))
				{
					this.OnlastNameUserChanging(value);
					this.SendPropertyChanging();
					this._lastNameUser = value;
					this.SendPropertyChanged("lastNameUser");
					this.OnlastNameUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type", DbType="Bit NOT NULL")]
		public bool type
		{
			get
			{
				return this._type;
			}
			set
			{
				if ((this._type != value))
				{
					this.OntypeChanging(value);
					this.SendPropertyChanging();
					this._type = value;
					this.SendPropertyChanged("type");
					this.OntypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_age", DbType="Int NOT NULL")]
		public int age
		{
			get
			{
				return this._age;
			}
			set
			{
				if ((this._age != value))
				{
					this.OnageChanging(value);
					this.SendPropertyChanging();
					this._age = value;
					this.SendPropertyChanged("age");
					this.OnageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_priceColoc", DbType="Int NOT NULL")]
		public int priceColoc
		{
			get
			{
				return this._priceColoc;
			}
			set
			{
				if ((this._priceColoc != value))
				{
					this.OnpriceColocChanging(value);
					this.SendPropertyChanging();
					this._priceColoc = value;
					this.SendPropertyChanged("priceColoc");
					this.OnpriceColocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_city", DbType="Int NOT NULL")]
		public int city
		{
			get
			{
				return this._city;
			}
			set
			{
				if ((this._city != value))
				{
					if (this._City1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncityChanging(value);
					this.SendPropertyChanging();
					this._city = value;
					this.SendPropertyChanged("city");
					this.OncityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descUser", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string descUser
		{
			get
			{
				return this._descUser;
			}
			set
			{
				if ((this._descUser != value))
				{
					this.OndescUserChanging(value);
					this.SendPropertyChanging();
					this._descUser = value;
					this.SendPropertyChanged("descUser");
					this.OndescUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_m2Coloc", DbType="Int")]
		public System.Nullable<int> m2Coloc
		{
			get
			{
				return this._m2Coloc;
			}
			set
			{
				if ((this._m2Coloc != value))
				{
					this.Onm2ColocChanging(value);
					this.SendPropertyChanging();
					this._m2Coloc = value;
					this.SendPropertyChanged("m2Coloc");
					this.Onm2ColocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastConnectionUser", DbType="DateTime")]
		public System.Nullable<System.DateTime> lastConnectionUser
		{
			get
			{
				return this._lastConnectionUser;
			}
			set
			{
				if ((this._lastConnectionUser != value))
				{
					this.OnlastConnectionUserChanging(value);
					this.SendPropertyChanging();
					this._lastConnectionUser = value;
					this.SendPropertyChanged("lastConnectionUser");
					this.OnlastConnectionUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_AuthToken", Storage="_AuthTokens", ThisKey="idUser", OtherKey="idUser")]
		public EntitySet<AuthToken> AuthTokens
		{
			get
			{
				return this._AuthTokens;
			}
			set
			{
				this._AuthTokens.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="City_User", Storage="_City1", ThisKey="city", OtherKey="idCity", IsForeignKey=true)]
		public City City1
		{
			get
			{
				return this._City1.Entity;
			}
			set
			{
				City previousValue = this._City1.Entity;
				if (((previousValue != value) 
							|| (this._City1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._City1.Entity = null;
						previousValue.Users.Remove(this);
					}
					this._City1.Entity = value;
					if ((value != null))
					{
						value.Users.Add(this);
						this._city = value.idCity;
					}
					else
					{
						this._city = default(int);
					}
					this.SendPropertyChanged("City1");
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
		
		private void attach_AuthTokens(AuthToken entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_AuthTokens(AuthToken entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
}
#pragma warning restore 1591
