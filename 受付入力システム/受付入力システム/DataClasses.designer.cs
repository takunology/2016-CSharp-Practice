﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 受付入力システム
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 拡張メソッドの定義
    partial void OnCreated();
    partial void InsertSchool(School instance);
    partial void UpdateSchool(School instance);
    partial void DeleteSchool(School instance);
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::受付入力システム.Properties.Settings.Default.DatabaseConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<School> School
		{
			get
			{
				return this.GetTable<School>();
			}
		}
		
		public System.Data.Linq.Table<Student> Student
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.School")]
	public partial class School : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Student> _Student;
		
    #region 拡張メソッドの定義
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public School()
		{
			this._Student = new EntitySet<Student>(new Action<Student>(this.attach_Student), new Action<Student>(this.detach_Student));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="School_Student", Storage="_Student", ThisKey="Id", OtherKey="SchoolId")]
		public EntitySet<Student> Student
		{
			get
			{
				return this._Student;
			}
			set
			{
				this._Student.Assign(value);
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
		
		private void attach_Student(Student entity)
		{
			this.SendPropertyChanging();
			entity.School = this;
		}
		
		private void detach_Student(Student entity)
		{
			this.SendPropertyChanging();
			entity.School = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Student")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _SchoolId;
		
		private string _Name;
		
		private string _Grade;
		
		private string _KanaName;
		
		private string _Sei;
		
		private EntityRef<School> _School;
		
    #region 拡張メソッドの定義
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnSchoolIdChanging(int value);
    partial void OnSchoolIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnGradeChanging(string value);
    partial void OnGradeChanged();
    partial void OnKanaNameChanging(string value);
    partial void OnKanaNameChanged();
    partial void OnSeiChanging(string value);
    partial void OnSeiChanged();
    #endregion
		
		public Student()
		{
			this._School = default(EntityRef<School>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SchoolId", DbType="Int NOT NULL")]
		public int SchoolId
		{
			get
			{
				return this._SchoolId;
			}
			set
			{
				if ((this._SchoolId != value))
				{
					if (this._School.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSchoolIdChanging(value);
					this.SendPropertyChanging();
					this._SchoolId = value;
					this.SendPropertyChanged("SchoolId");
					this.OnSchoolIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(63) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Grade", DbType="NVarChar(50)")]
		public string Grade
		{
			get
			{
				return this._Grade;
			}
			set
			{
				if ((this._Grade != value))
				{
					this.OnGradeChanging(value);
					this.SendPropertyChanging();
					this._Grade = value;
					this.SendPropertyChanged("Grade");
					this.OnGradeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KanaName", DbType="NVarChar(63)")]
		public string KanaName
		{
			get
			{
				return this._KanaName;
			}
			set
			{
				if ((this._KanaName != value))
				{
					this.OnKanaNameChanging(value);
					this.SendPropertyChanging();
					this._KanaName = value;
					this.SendPropertyChanged("KanaName");
					this.OnKanaNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sei", DbType="NVarChar(10)")]
		public string Sei
		{
			get
			{
				return this._Sei;
			}
			set
			{
				if ((this._Sei != value))
				{
					this.OnSeiChanging(value);
					this.SendPropertyChanging();
					this._Sei = value;
					this.SendPropertyChanged("Sei");
					this.OnSeiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="School_Student", Storage="_School", ThisKey="SchoolId", OtherKey="Id", IsForeignKey=true)]
		public School School
		{
			get
			{
				return this._School.Entity;
			}
			set
			{
				School previousValue = this._School.Entity;
				if (((previousValue != value) 
							|| (this._School.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._School.Entity = null;
						previousValue.Student.Remove(this);
					}
					this._School.Entity = value;
					if ((value != null))
					{
						value.Student.Add(this);
						this._SchoolId = value.Id;
					}
					else
					{
						this._SchoolId = default(int);
					}
					this.SendPropertyChanged("School");
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
