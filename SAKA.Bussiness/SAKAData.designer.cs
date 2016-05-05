﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAKA.Bussiness
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Empatik")]
	public partial class SAKADataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKPI(KPI instance);
    partial void UpdateKPI(KPI instance);
    partial void DeleteKPI(KPI instance);
    #endregion
		
		public SAKADataDataContext() : 
				base(global::SAKA.Bussiness.Properties.Settings.Default.EmpatikConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SAKADataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SAKADataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SAKADataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SAKADataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<KPI> KPIs
		{
			get
			{
				return this.GetTable<KPI>();
			}
		}
		
		public System.Data.Linq.Table<KPI_CALCULATION_LOG> KPI_CALCULATION_LOGs
		{
			get
			{
				return this.GetTable<KPI_CALCULATION_LOG>();
			}
		}
		
		public System.Data.Linq.Table<KPI_VALUE> KPI_VALUEs
		{
			get
			{
				return this.GetTable<KPI_VALUE>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KPI")]
	public partial class KPI : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Name;
		
		private decimal _Target;
		
		private char _Period;
		
		private decimal _ThresHold;
		
		private bool _ThresHold_Type;
		
		private System.Guid _Id;
		
		private string _Unit;
		
		private System.DateTime _Creation_Date;
		
		private System.Nullable<System.DateTime> _Modification_Date;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnTargetChanging(decimal value);
    partial void OnTargetChanged();
    partial void OnPeriodChanging(char value);
    partial void OnPeriodChanged();
    partial void OnThresHoldChanging(decimal value);
    partial void OnThresHoldChanged();
    partial void OnThresHold_TypeChanging(bool value);
    partial void OnThresHold_TypeChanged();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnUnitChanging(string value);
    partial void OnUnitChanged();
    partial void OnCreation_DateChanging(System.DateTime value);
    partial void OnCreation_DateChanged();
    partial void OnModification_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnModification_DateChanged();
    #endregion
		
		public KPI()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(400) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Target", DbType="Decimal(12,2) NOT NULL")]
		public decimal Target
		{
			get
			{
				return this._Target;
			}
			set
			{
				if ((this._Target != value))
				{
					this.OnTargetChanging(value);
					this.SendPropertyChanging();
					this._Target = value;
					this.SendPropertyChanged("Target");
					this.OnTargetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Period", DbType="Char(1) NOT NULL")]
		public char Period
		{
			get
			{
				return this._Period;
			}
			set
			{
				if ((this._Period != value))
				{
					this.OnPeriodChanging(value);
					this.SendPropertyChanging();
					this._Period = value;
					this.SendPropertyChanged("Period");
					this.OnPeriodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThresHold", DbType="Decimal(12,2) NOT NULL")]
		public decimal ThresHold
		{
			get
			{
				return this._ThresHold;
			}
			set
			{
				if ((this._ThresHold != value))
				{
					this.OnThresHoldChanging(value);
					this.SendPropertyChanging();
					this._ThresHold = value;
					this.SendPropertyChanged("ThresHold");
					this.OnThresHoldChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThresHold_Type", DbType="Bit NOT NULL")]
		public bool ThresHold_Type
		{
			get
			{
				return this._ThresHold_Type;
			}
			set
			{
				if ((this._ThresHold_Type != value))
				{
					this.OnThresHold_TypeChanging(value);
					this.SendPropertyChanging();
					this._ThresHold_Type = value;
					this.SendPropertyChanged("ThresHold_Type");
					this.OnThresHold_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Unit", DbType="NVarChar(30)")]
		public string Unit
		{
			get
			{
				return this._Unit;
			}
			set
			{
				if ((this._Unit != value))
				{
					this.OnUnitChanging(value);
					this.SendPropertyChanging();
					this._Unit = value;
					this.SendPropertyChanged("Unit");
					this.OnUnitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Creation_Date", DbType="Date NOT NULL")]
		public System.DateTime Creation_Date
		{
			get
			{
				return this._Creation_Date;
			}
			set
			{
				if ((this._Creation_Date != value))
				{
					this.OnCreation_DateChanging(value);
					this.SendPropertyChanging();
					this._Creation_Date = value;
					this.SendPropertyChanged("Creation_Date");
					this.OnCreation_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modification_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Modification_Date
		{
			get
			{
				return this._Modification_Date;
			}
			set
			{
				if ((this._Modification_Date != value))
				{
					this.OnModification_DateChanging(value);
					this.SendPropertyChanging();
					this._Modification_Date = value;
					this.SendPropertyChanged("Modification_Date");
					this.OnModification_DateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KPI_CALCULATION_LOG")]
	public partial class KPI_CALCULATION_LOG
	{
		
		private System.Guid _Id;
		
		private System.DateTime _Date;
		
		private bool _Success;
		
		private string _Exception_Message;
		
		private System.Guid _Kpi_Id;
		
		public KPI_CALCULATION_LOG()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this._Date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Success", DbType="Bit NOT NULL")]
		public bool Success
		{
			get
			{
				return this._Success;
			}
			set
			{
				if ((this._Success != value))
				{
					this._Success = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Exception_Message", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Exception_Message
		{
			get
			{
				return this._Exception_Message;
			}
			set
			{
				if ((this._Exception_Message != value))
				{
					this._Exception_Message = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kpi_Id", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Kpi_Id
		{
			get
			{
				return this._Kpi_Id;
			}
			set
			{
				if ((this._Kpi_Id != value))
				{
					this._Kpi_Id = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KPI_VALUE")]
	public partial class KPI_VALUE
	{
		
		private System.Guid _Kpi_Id;
		
		private decimal _Value;
		
		private System.DateTime _Date;
		
		private decimal _Target;
		
		private decimal _ThresHold;
		
		private bool _ThresHold_Type;
		
		public KPI_VALUE()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kpi_Id", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Kpi_Id
		{
			get
			{
				return this._Kpi_Id;
			}
			set
			{
				if ((this._Kpi_Id != value))
				{
					this._Kpi_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", DbType="Decimal(12,2) NOT NULL")]
		public decimal Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this._Value = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this._Date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Target", DbType="Decimal(12,2) NOT NULL")]
		public decimal Target
		{
			get
			{
				return this._Target;
			}
			set
			{
				if ((this._Target != value))
				{
					this._Target = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThresHold", DbType="Decimal(12,2) NOT NULL")]
		public decimal ThresHold
		{
			get
			{
				return this._ThresHold;
			}
			set
			{
				if ((this._ThresHold != value))
				{
					this._ThresHold = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThresHold_Type", DbType="Bit NOT NULL")]
		public bool ThresHold_Type
		{
			get
			{
				return this._ThresHold_Type;
			}
			set
			{
				if ((this._ThresHold_Type != value))
				{
					this._ThresHold_Type = value;
				}
			}
		}
	}
}
#pragma warning restore 1591