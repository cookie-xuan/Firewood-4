﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34209
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLinq
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="firewood")]
	public partial class FirewoodDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void Insertorg(org instance);
    partial void Updateorg(org instance);
    partial void Deleteorg(org instance);
    partial void Insertactivity(activity instance);
    partial void Updateactivity(activity instance);
    partial void Deleteactivity(activity instance);
    partial void Insertcomment(comment instance);
    partial void Updatecomment(comment instance);
    partial void Deletecomment(comment instance);
    #endregion
		
		public FirewoodDataContext() : 
				base(global::DataLinq.Properties.Settings.Default.firewoodConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public FirewoodDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FirewoodDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FirewoodDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FirewoodDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<org> org
		{
			get
			{
				return this.GetTable<org>();
			}
		}
		
		public System.Data.Linq.Table<join> join
		{
			get
			{
				return this.GetTable<join>();
			}
		}
		
		public System.Data.Linq.Table<activity> activity
		{
			get
			{
				return this.GetTable<activity>();
			}
		}
		
		public System.Data.Linq.Table<comment> comment
		{
			get
			{
				return this.GetTable<comment>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.org")]
	public partial class org : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _OrgID;
		
		private string _OrgName;
		
		private string _OrgPwd;
		
		private string _OrgPic;
		
		private string _OrgPrincipal;
		
		private string _OrgTel;
		
		private string _OrgDepartment;
		
		private string _OrgIntroduction;
		
		private string _OrgContact;
		
		private string _OrgIP;
		
		private System.DateTime _RegisterTime;
		
		private System.DateTime _LastLogin;
		
		private int _State;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrgIDChanging(System.Guid value);
    partial void OnOrgIDChanged();
    partial void OnOrgNameChanging(string value);
    partial void OnOrgNameChanged();
    partial void OnOrgPwdChanging(string value);
    partial void OnOrgPwdChanged();
    partial void OnOrgPicChanging(string value);
    partial void OnOrgPicChanged();
    partial void OnOrgPrincipalChanging(string value);
    partial void OnOrgPrincipalChanged();
    partial void OnOrgTelChanging(string value);
    partial void OnOrgTelChanged();
    partial void OnOrgDepartmentChanging(string value);
    partial void OnOrgDepartmentChanged();
    partial void OnOrgIntroductionChanging(string value);
    partial void OnOrgIntroductionChanged();
    partial void OnOrgContactChanging(string value);
    partial void OnOrgContactChanged();
    partial void OnOrgIPChanging(string value);
    partial void OnOrgIPChanged();
    partial void OnRegisterTimeChanging(System.DateTime value);
    partial void OnRegisterTimeChanged();
    partial void OnLastLoginChanging(System.DateTime value);
    partial void OnLastLoginChanged();
    partial void OnStateChanging(int value);
    partial void OnStateChanged();
    #endregion
		
		public org()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid OrgID
		{
			get
			{
				return this._OrgID;
			}
			set
			{
				if ((this._OrgID != value))
				{
					this.OnOrgIDChanging(value);
					this.SendPropertyChanging();
					this._OrgID = value;
					this.SendPropertyChanged("OrgID");
					this.OnOrgIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgName", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string OrgName
		{
			get
			{
				return this._OrgName;
			}
			set
			{
				if ((this._OrgName != value))
				{
					this.OnOrgNameChanging(value);
					this.SendPropertyChanging();
					this._OrgName = value;
					this.SendPropertyChanged("OrgName");
					this.OnOrgNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgPwd", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string OrgPwd
		{
			get
			{
				return this._OrgPwd;
			}
			set
			{
				if ((this._OrgPwd != value))
				{
					this.OnOrgPwdChanging(value);
					this.SendPropertyChanging();
					this._OrgPwd = value;
					this.SendPropertyChanged("OrgPwd");
					this.OnOrgPwdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgPic", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string OrgPic
		{
			get
			{
				return this._OrgPic;
			}
			set
			{
				if ((this._OrgPic != value))
				{
					this.OnOrgPicChanging(value);
					this.SendPropertyChanging();
					this._OrgPic = value;
					this.SendPropertyChanged("OrgPic");
					this.OnOrgPicChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgPrincipal", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string OrgPrincipal
		{
			get
			{
				return this._OrgPrincipal;
			}
			set
			{
				if ((this._OrgPrincipal != value))
				{
					this.OnOrgPrincipalChanging(value);
					this.SendPropertyChanging();
					this._OrgPrincipal = value;
					this.SendPropertyChanged("OrgPrincipal");
					this.OnOrgPrincipalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgTel", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string OrgTel
		{
			get
			{
				return this._OrgTel;
			}
			set
			{
				if ((this._OrgTel != value))
				{
					this.OnOrgTelChanging(value);
					this.SendPropertyChanging();
					this._OrgTel = value;
					this.SendPropertyChanged("OrgTel");
					this.OnOrgTelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgDepartment", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string OrgDepartment
		{
			get
			{
				return this._OrgDepartment;
			}
			set
			{
				if ((this._OrgDepartment != value))
				{
					this.OnOrgDepartmentChanging(value);
					this.SendPropertyChanging();
					this._OrgDepartment = value;
					this.SendPropertyChanged("OrgDepartment");
					this.OnOrgDepartmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgIntroduction", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string OrgIntroduction
		{
			get
			{
				return this._OrgIntroduction;
			}
			set
			{
				if ((this._OrgIntroduction != value))
				{
					this.OnOrgIntroductionChanging(value);
					this.SendPropertyChanging();
					this._OrgIntroduction = value;
					this.SendPropertyChanged("OrgIntroduction");
					this.OnOrgIntroductionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgContact", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string OrgContact
		{
			get
			{
				return this._OrgContact;
			}
			set
			{
				if ((this._OrgContact != value))
				{
					this.OnOrgContactChanging(value);
					this.SendPropertyChanging();
					this._OrgContact = value;
					this.SendPropertyChanged("OrgContact");
					this.OnOrgContactChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgIP", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string OrgIP
		{
			get
			{
				return this._OrgIP;
			}
			set
			{
				if ((this._OrgIP != value))
				{
					this.OnOrgIPChanging(value);
					this.SendPropertyChanging();
					this._OrgIP = value;
					this.SendPropertyChanged("OrgIP");
					this.OnOrgIPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegisterTime", DbType="DateTime NOT NULL")]
		public System.DateTime RegisterTime
		{
			get
			{
				return this._RegisterTime;
			}
			set
			{
				if ((this._RegisterTime != value))
				{
					this.OnRegisterTimeChanging(value);
					this.SendPropertyChanging();
					this._RegisterTime = value;
					this.SendPropertyChanged("RegisterTime");
					this.OnRegisterTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastLogin", DbType="DateTime NOT NULL")]
		public System.DateTime LastLogin
		{
			get
			{
				return this._LastLogin;
			}
			set
			{
				if ((this._LastLogin != value))
				{
					this.OnLastLoginChanging(value);
					this.SendPropertyChanging();
					this._LastLogin = value;
					this.SendPropertyChanged("LastLogin");
					this.OnLastLoginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="Int NOT NULL")]
		public int State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[join]")]
	public partial class join
	{
		
		private System.Guid _UserID;
		
		private System.Guid _ActID;
		
		private int _State;
		
		public join()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this._UserID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ActID
		{
			get
			{
				return this._ActID;
			}
			set
			{
				if ((this._ActID != value))
				{
					this._ActID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="Int NOT NULL")]
		public int State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this._State = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.activity")]
	public partial class activity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ActID;
		
		private string _ActName;
		
		private string _ActIntro;
		
		private string _ActPic;
		
		private System.Guid _OrgID;
		
		private string _Class1;
		
		private string _Class2;
		
		private string _Place;
		
		private System.DateTime _BeginTime;
		
		private System.DateTime _EndTime;
		
		private int _MoneyState;
		
		private int _ScoreState;
		
		private int _AwardState;
		
		private int _VoteState;
		
		private int _State;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnActIDChanging(System.Guid value);
    partial void OnActIDChanged();
    partial void OnActNameChanging(string value);
    partial void OnActNameChanged();
    partial void OnActIntroChanging(string value);
    partial void OnActIntroChanged();
    partial void OnActPicChanging(string value);
    partial void OnActPicChanged();
    partial void OnOrgIDChanging(System.Guid value);
    partial void OnOrgIDChanged();
    partial void OnClass1Changing(string value);
    partial void OnClass1Changed();
    partial void OnClass2Changing(string value);
    partial void OnClass2Changed();
    partial void OnPlaceChanging(string value);
    partial void OnPlaceChanged();
    partial void OnBeginTimeChanging(System.DateTime value);
    partial void OnBeginTimeChanged();
    partial void OnEndTimeChanging(System.DateTime value);
    partial void OnEndTimeChanged();
    partial void OnMoneyStateChanging(int value);
    partial void OnMoneyStateChanged();
    partial void OnScoreStateChanging(int value);
    partial void OnScoreStateChanged();
    partial void OnAwardStateChanging(int value);
    partial void OnAwardStateChanged();
    partial void OnVoteStateChanging(int value);
    partial void OnVoteStateChanged();
    partial void OnStateChanging(int value);
    partial void OnStateChanged();
    #endregion
		
		public activity()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ActID
		{
			get
			{
				return this._ActID;
			}
			set
			{
				if ((this._ActID != value))
				{
					this.OnActIDChanging(value);
					this.SendPropertyChanging();
					this._ActID = value;
					this.SendPropertyChanged("ActID");
					this.OnActIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActName", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string ActName
		{
			get
			{
				return this._ActName;
			}
			set
			{
				if ((this._ActName != value))
				{
					this.OnActNameChanging(value);
					this.SendPropertyChanging();
					this._ActName = value;
					this.SendPropertyChanged("ActName");
					this.OnActNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActIntro", DbType="NVarChar(1000) NOT NULL", CanBeNull=false)]
		public string ActIntro
		{
			get
			{
				return this._ActIntro;
			}
			set
			{
				if ((this._ActIntro != value))
				{
					this.OnActIntroChanging(value);
					this.SendPropertyChanging();
					this._ActIntro = value;
					this.SendPropertyChanged("ActIntro");
					this.OnActIntroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActPic", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string ActPic
		{
			get
			{
				return this._ActPic;
			}
			set
			{
				if ((this._ActPic != value))
				{
					this.OnActPicChanging(value);
					this.SendPropertyChanging();
					this._ActPic = value;
					this.SendPropertyChanged("ActPic");
					this.OnActPicChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid OrgID
		{
			get
			{
				return this._OrgID;
			}
			set
			{
				if ((this._OrgID != value))
				{
					this.OnOrgIDChanging(value);
					this.SendPropertyChanging();
					this._OrgID = value;
					this.SendPropertyChanged("OrgID");
					this.OnOrgIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Class1", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Class1
		{
			get
			{
				return this._Class1;
			}
			set
			{
				if ((this._Class1 != value))
				{
					this.OnClass1Changing(value);
					this.SendPropertyChanging();
					this._Class1 = value;
					this.SendPropertyChanged("Class1");
					this.OnClass1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Class2", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Class2
		{
			get
			{
				return this._Class2;
			}
			set
			{
				if ((this._Class2 != value))
				{
					this.OnClass2Changing(value);
					this.SendPropertyChanging();
					this._Class2 = value;
					this.SendPropertyChanged("Class2");
					this.OnClass2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Place", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Place
		{
			get
			{
				return this._Place;
			}
			set
			{
				if ((this._Place != value))
				{
					this.OnPlaceChanging(value);
					this.SendPropertyChanging();
					this._Place = value;
					this.SendPropertyChanged("Place");
					this.OnPlaceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BeginTime", DbType="DateTime NOT NULL")]
		public System.DateTime BeginTime
		{
			get
			{
				return this._BeginTime;
			}
			set
			{
				if ((this._BeginTime != value))
				{
					this.OnBeginTimeChanging(value);
					this.SendPropertyChanging();
					this._BeginTime = value;
					this.SendPropertyChanged("BeginTime");
					this.OnBeginTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndTime", DbType="DateTime NOT NULL")]
		public System.DateTime EndTime
		{
			get
			{
				return this._EndTime;
			}
			set
			{
				if ((this._EndTime != value))
				{
					this.OnEndTimeChanging(value);
					this.SendPropertyChanging();
					this._EndTime = value;
					this.SendPropertyChanged("EndTime");
					this.OnEndTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoneyState", DbType="Int NOT NULL")]
		public int MoneyState
		{
			get
			{
				return this._MoneyState;
			}
			set
			{
				if ((this._MoneyState != value))
				{
					this.OnMoneyStateChanging(value);
					this.SendPropertyChanging();
					this._MoneyState = value;
					this.SendPropertyChanged("MoneyState");
					this.OnMoneyStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ScoreState", DbType="Int NOT NULL")]
		public int ScoreState
		{
			get
			{
				return this._ScoreState;
			}
			set
			{
				if ((this._ScoreState != value))
				{
					this.OnScoreStateChanging(value);
					this.SendPropertyChanging();
					this._ScoreState = value;
					this.SendPropertyChanged("ScoreState");
					this.OnScoreStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AwardState", DbType="Int NOT NULL")]
		public int AwardState
		{
			get
			{
				return this._AwardState;
			}
			set
			{
				if ((this._AwardState != value))
				{
					this.OnAwardStateChanging(value);
					this.SendPropertyChanging();
					this._AwardState = value;
					this.SendPropertyChanged("AwardState");
					this.OnAwardStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VoteState", DbType="Int NOT NULL")]
		public int VoteState
		{
			get
			{
				return this._VoteState;
			}
			set
			{
				if ((this._VoteState != value))
				{
					this.OnVoteStateChanging(value);
					this.SendPropertyChanging();
					this._VoteState = value;
					this.SendPropertyChanged("VoteState");
					this.OnVoteStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="Int NOT NULL")]
		public int State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.comment")]
	public partial class comment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ComID;
		
		private System.Guid _OrgID;
		
		private System.Guid _ActID;
		
		private System.Guid _UserID;
		
		private string _ComCon;
		
		private System.DateTime _ComTime;
		
		private int _State;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnComIDChanging(System.Guid value);
    partial void OnComIDChanged();
    partial void OnOrgIDChanging(System.Guid value);
    partial void OnOrgIDChanged();
    partial void OnActIDChanging(System.Guid value);
    partial void OnActIDChanged();
    partial void OnUserIDChanging(System.Guid value);
    partial void OnUserIDChanged();
    partial void OnComConChanging(string value);
    partial void OnComConChanged();
    partial void OnComTimeChanging(System.DateTime value);
    partial void OnComTimeChanged();
    partial void OnStateChanging(int value);
    partial void OnStateChanged();
    #endregion
		
		public comment()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ComID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ComID
		{
			get
			{
				return this._ComID;
			}
			set
			{
				if ((this._ComID != value))
				{
					this.OnComIDChanging(value);
					this.SendPropertyChanging();
					this._ComID = value;
					this.SendPropertyChanged("ComID");
					this.OnComIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid OrgID
		{
			get
			{
				return this._OrgID;
			}
			set
			{
				if ((this._OrgID != value))
				{
					this.OnOrgIDChanging(value);
					this.SendPropertyChanging();
					this._OrgID = value;
					this.SendPropertyChanged("OrgID");
					this.OnOrgIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ActID
		{
			get
			{
				return this._ActID;
			}
			set
			{
				if ((this._ActID != value))
				{
					this.OnActIDChanging(value);
					this.SendPropertyChanging();
					this._ActID = value;
					this.SendPropertyChanged("ActID");
					this.OnActIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ComCon", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string ComCon
		{
			get
			{
				return this._ComCon;
			}
			set
			{
				if ((this._ComCon != value))
				{
					this.OnComConChanging(value);
					this.SendPropertyChanging();
					this._ComCon = value;
					this.SendPropertyChanged("ComCon");
					this.OnComConChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ComTime", DbType="DateTime NOT NULL")]
		public System.DateTime ComTime
		{
			get
			{
				return this._ComTime;
			}
			set
			{
				if ((this._ComTime != value))
				{
					this.OnComTimeChanging(value);
					this.SendPropertyChanging();
					this._ComTime = value;
					this.SendPropertyChanged("ComTime");
					this.OnComTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="Int NOT NULL")]
		public int State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
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
