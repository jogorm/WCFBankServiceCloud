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

namespace WCFServiceWebRole1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ABCBanking")]
	public partial class BankDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    partial void InsertTransaction(Transaction instance);
    partial void UpdateTransaction(Transaction instance);
    partial void DeleteTransaction(Transaction instance);
    #endregion
		
		public BankDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ABCBankingConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BankDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BankDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BankDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BankDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
		
		public System.Data.Linq.Table<Transaction> Transactions
		{
			get
			{
				return this.GetTable<Transaction>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Account")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Acc_ID;
		
		private decimal _balance;
		
		private decimal _running_totals;
		
		private string _first_name;
		
		private string _last_name;
		
		private string _address;
		
		private string _postcode;
		
		private string _telephone;
		
		private string _pin;
		
		private decimal _overdraft;
		
		private EntitySet<Transaction> _Transactions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAcc_IDChanging(int value);
    partial void OnAcc_IDChanged();
    partial void OnbalanceChanging(decimal value);
    partial void OnbalanceChanged();
    partial void Onrunning_totalsChanging(decimal value);
    partial void Onrunning_totalsChanged();
    partial void Onfirst_nameChanging(string value);
    partial void Onfirst_nameChanged();
    partial void Onlast_nameChanging(string value);
    partial void Onlast_nameChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OnpostcodeChanging(string value);
    partial void OnpostcodeChanged();
    partial void OntelephoneChanging(string value);
    partial void OntelephoneChanged();
    partial void OnpinChanging(string value);
    partial void OnpinChanged();
    partial void OnoverdraftChanging(decimal value);
    partial void OnoverdraftChanged();
    #endregion
		
		public Account()
		{
			this._Transactions = new EntitySet<Transaction>(new Action<Transaction>(this.attach_Transactions), new Action<Transaction>(this.detach_Transactions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Acc_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Acc_ID
		{
			get
			{
				return this._Acc_ID;
			}
			set
			{
				if ((this._Acc_ID != value))
				{
					this.OnAcc_IDChanging(value);
					this.SendPropertyChanging();
					this._Acc_ID = value;
					this.SendPropertyChanged("Acc_ID");
					this.OnAcc_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_balance", DbType="SmallMoney NOT NULL")]
		public decimal balance
		{
			get
			{
				return this._balance;
			}
			set
			{
				if ((this._balance != value))
				{
					this.OnbalanceChanging(value);
					this.SendPropertyChanging();
					this._balance = value;
					this.SendPropertyChanged("balance");
					this.OnbalanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_running_totals", DbType="SmallMoney NOT NULL")]
		public decimal running_totals
		{
			get
			{
				return this._running_totals;
			}
			set
			{
				if ((this._running_totals != value))
				{
					this.Onrunning_totalsChanging(value);
					this.SendPropertyChanging();
					this._running_totals = value;
					this.SendPropertyChanged("running_totals");
					this.Onrunning_totalsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_first_name", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string first_name
		{
			get
			{
				return this._first_name;
			}
			set
			{
				if ((this._first_name != value))
				{
					this.Onfirst_nameChanging(value);
					this.SendPropertyChanging();
					this._first_name = value;
					this.SendPropertyChanged("first_name");
					this.Onfirst_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_last_name", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string last_name
		{
			get
			{
				return this._last_name;
			}
			set
			{
				if ((this._last_name != value))
				{
					this.Onlast_nameChanging(value);
					this.SendPropertyChanging();
					this._last_name = value;
					this.SendPropertyChanged("last_name");
					this.Onlast_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="NChar(30) NOT NULL", CanBeNull=false)]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_postcode", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string postcode
		{
			get
			{
				return this._postcode;
			}
			set
			{
				if ((this._postcode != value))
				{
					this.OnpostcodeChanging(value);
					this.SendPropertyChanging();
					this._postcode = value;
					this.SendPropertyChanged("postcode");
					this.OnpostcodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telephone", DbType="NChar(18) NOT NULL", CanBeNull=false)]
		public string telephone
		{
			get
			{
				return this._telephone;
			}
			set
			{
				if ((this._telephone != value))
				{
					this.OntelephoneChanging(value);
					this.SendPropertyChanging();
					this._telephone = value;
					this.SendPropertyChanged("telephone");
					this.OntelephoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pin", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string pin
		{
			get
			{
				return this._pin;
			}
			set
			{
				if ((this._pin != value))
				{
					this.OnpinChanging(value);
					this.SendPropertyChanging();
					this._pin = value;
					this.SendPropertyChanged("pin");
					this.OnpinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_overdraft", DbType="SmallMoney NOT NULL")]
		public decimal overdraft
		{
			get
			{
				return this._overdraft;
			}
			set
			{
				if ((this._overdraft != value))
				{
					this.OnoverdraftChanging(value);
					this.SendPropertyChanging();
					this._overdraft = value;
					this.SendPropertyChanged("overdraft");
					this.OnoverdraftChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Transaction", Storage="_Transactions", ThisKey="Acc_ID", OtherKey="acc_id")]
		public EntitySet<Transaction> Transactions
		{
			get
			{
				return this._Transactions;
			}
			set
			{
				this._Transactions.Assign(value);
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
		
		private void attach_Transactions(Transaction entity)
		{
			this.SendPropertyChanging();
			entity.Account = this;
		}
		
		private void detach_Transactions(Transaction entity)
		{
			this.SendPropertyChanging();
			entity.Account = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Transactions")]
	public partial class Transaction : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Trans_ID;
		
		private decimal _amount;
		
		private System.DateTime _datetime;
		
		private int _acc_id;
		
		private EntityRef<Account> _Account;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTrans_IDChanging(int value);
    partial void OnTrans_IDChanged();
    partial void OnamountChanging(decimal value);
    partial void OnamountChanged();
    partial void OndatetimeChanging(System.DateTime value);
    partial void OndatetimeChanged();
    partial void Onacc_idChanging(int value);
    partial void Onacc_idChanged();
    #endregion
		
		public Transaction()
		{
			this._Account = default(EntityRef<Account>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Trans_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Trans_ID
		{
			get
			{
				return this._Trans_ID;
			}
			set
			{
				if ((this._Trans_ID != value))
				{
					this.OnTrans_IDChanging(value);
					this.SendPropertyChanging();
					this._Trans_ID = value;
					this.SendPropertyChanged("Trans_ID");
					this.OnTrans_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="SmallMoney NOT NULL")]
		public decimal amount
		{
			get
			{
				return this._amount;
			}
			set
			{
				if ((this._amount != value))
				{
					this.OnamountChanging(value);
					this.SendPropertyChanging();
					this._amount = value;
					this.SendPropertyChanged("amount");
					this.OnamountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datetime", DbType="DateTime NOT NULL")]
		public System.DateTime datetime
		{
			get
			{
				return this._datetime;
			}
			set
			{
				if ((this._datetime != value))
				{
					this.OndatetimeChanging(value);
					this.SendPropertyChanging();
					this._datetime = value;
					this.SendPropertyChanged("datetime");
					this.OndatetimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_acc_id", DbType="Int NOT NULL")]
		public int acc_id
		{
			get
			{
				return this._acc_id;
			}
			set
			{
				if ((this._acc_id != value))
				{
					if (this._Account.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onacc_idChanging(value);
					this.SendPropertyChanging();
					this._acc_id = value;
					this.SendPropertyChanged("acc_id");
					this.Onacc_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Transaction", Storage="_Account", ThisKey="acc_id", OtherKey="Acc_ID", IsForeignKey=true)]
		public Account Account
		{
			get
			{
				return this._Account.Entity;
			}
			set
			{
				Account previousValue = this._Account.Entity;
				if (((previousValue != value) 
							|| (this._Account.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Account.Entity = null;
						previousValue.Transactions.Remove(this);
					}
					this._Account.Entity = value;
					if ((value != null))
					{
						value.Transactions.Add(this);
						this._acc_id = value.Acc_ID;
					}
					else
					{
						this._acc_id = default(int);
					}
					this.SendPropertyChanged("Account");
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
}
#pragma warning restore 1591
