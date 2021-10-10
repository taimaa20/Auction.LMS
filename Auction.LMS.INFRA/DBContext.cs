using Auction.LMS.CORE.Common;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace Auction.LMS.INFRA
{
    public class DBContext : IDBContext
    {
        private DbConnection _connection; // put connection string
        private readonly IConfiguration configuration; // get connection string from appsettings.json

        public DBContext(IConfiguration configuration)
        {
            this.configuration = configuration;



        }
        /* CHeck the connection string is null or not and check connection string is open or not (close)*/
        public DbConnection Connection // immplement from interface
        {
            get
            {
                if (_connection == null)
                {



                    _connection = new SqlConnection(configuration["ConnectionStrings:DBConnectionsString"]); // configuration get connection string from appsettings.json



                    _connection.Open();// connection open

                }
                else if (_connection.State != ConnectionState.Open) // check connectionstate
                                                                    //_connection.State State open or close
                {
                    _connection.Open();
                }



                return _connection; // return connection if the connection is not null or not close
            }



        }
    }
}
