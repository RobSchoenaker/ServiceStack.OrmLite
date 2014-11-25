﻿
// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `AppDb`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Server=localhost;Database=test;User Id=test;password=**zapped**;`
//     Schema:                 ``
//     Include Views:          `False`

//     Factory Name:          `SqlClientFactory`
using System;
using System.Data.Common;
using System.Data;
using System.Collections.Generic;
using ServiceStack.OrmLite;

namespace StoredProcedures
{
	public static class SPList 
	{
		private static DbParameter CreateNewParameter(DbCommand dbCommand, string paramName, object paramValue, ParameterDirection paramDirection, DbType paramType)
		{
			DbParameter param = dbCommand.CreateParameter();
			param.Direction = paramDirection;
			param.DbType = paramType;
			param.ParameterName = paramName;
			param.Value = paramValue;
			return param;
		}

		public static OrmLiteSPStatement DummyColumn(this IDbConnection db, int? times = null)
		{
			var dbCmd = (DbCommand)OrmLiteConfig.ExecFilter.CreateCommand(db).ToDbCommand();
			dbCmd.CommandText = "DummyColumn";
			dbCmd.CommandType = CommandType.StoredProcedure;
			dbCmd.Parameters.Add(CreateNewParameter(dbCmd,"Times",times,ParameterDirection.Input,DbType.Int32));
 			return new OrmLiteSPStatement(db, dbCmd);
		}

		public static OrmLiteSPStatement DummyProc(this IDbConnection db, string name = null)
		{
			var dbCmd = (DbCommand)OrmLiteConfig.ExecFilter.CreateCommand(db).ToDbCommand();
			dbCmd.CommandText = "DummyProc";
			dbCmd.CommandType = CommandType.StoredProcedure;
			dbCmd.Parameters.Add(CreateNewParameter(dbCmd,"Name",name,ParameterDirection.Input,DbType.String));
 			return new OrmLiteSPStatement(db, dbCmd);
		}

		public static OrmLiteSPStatement SP_upload_file(this IDbConnection db, string filename = null, string filetype = null, byte[] filecontent = null)
		{
			var dbCmd = (DbCommand)OrmLiteConfig.ExecFilter.CreateCommand(db).ToDbCommand();
			dbCmd.CommandText = "SP_upload_file";
			dbCmd.CommandType = CommandType.StoredProcedure;
			dbCmd.Parameters.Add(CreateNewParameter(dbCmd,"filename",filename,ParameterDirection.Input,DbType.AnsiString));
			dbCmd.Parameters.Add(CreateNewParameter(dbCmd,"filetype",filetype,ParameterDirection.Input,DbType.AnsiString));
			dbCmd.Parameters.Add(CreateNewParameter(dbCmd,"filecontent",filecontent,ParameterDirection.Input,DbType.Binary));
 			return new OrmLiteSPStatement(db, dbCmd);
		}

		public static OrmLiteSPStatement DummyTable(this IDbConnection db, int? times = null)
		{
			var dbCmd = (DbCommand)OrmLiteConfig.ExecFilter.CreateCommand(db).ToDbCommand();
			dbCmd.CommandText = "DummyTable";
			dbCmd.CommandType = CommandType.StoredProcedure;
			dbCmd.Parameters.Add(CreateNewParameter(dbCmd,"Times",times,ParameterDirection.Input,DbType.Int32));
 			return new OrmLiteSPStatement(db, dbCmd);
		}

		public static OrmLiteSPStatement DummyScalar(this IDbConnection db, int? times = null)
		{
			var dbCmd = (DbCommand)OrmLiteConfig.ExecFilter.CreateCommand(db).ToDbCommand();
			dbCmd.CommandText = "DummyScalar";
			dbCmd.CommandType = CommandType.StoredProcedure;
			dbCmd.Parameters.Add(CreateNewParameter(dbCmd,"Times",times,ParameterDirection.Input,DbType.Int32));
 			return new OrmLiteSPStatement(db, dbCmd);
		}

	}
}
