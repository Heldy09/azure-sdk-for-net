// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataFactory.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary> A class representing the FactoryDataset data model. </summary>
    public partial class FactoryDatasetData : ResourceData
    {
        /// <summary> Initializes a new instance of FactoryDatasetData. </summary>
        /// <param name="properties">
        /// Dataset properties.
        /// Please note <see cref="FactoryDatasetDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonMwsObjectDataset"/>, <see cref="AmazonRdsForOracleTableDataset"/>, <see cref="AmazonRdsForSqlServerTableDataset"/>, <see cref="AmazonRedshiftTableDataset"/>, <see cref="AmazonS3Dataset"/>, <see cref="AvroDataset"/>, <see cref="AzureBlobDataset"/>, <see cref="AzureBlobFSDataset"/>, <see cref="AzureDataExplorerTableDataset"/>, <see cref="AzureDataLakeStoreDataset"/>, <see cref="AzureDatabricksDeltaLakeDataset"/>, <see cref="AzureMariaDBTableDataset"/>, <see cref="AzureMySqlTableDataset"/>, <see cref="AzurePostgreSqlTableDataset"/>, <see cref="AzureSearchIndexDataset"/>, <see cref="AzureSqlDWTableDataset"/>, <see cref="AzureSqlMITableDataset"/>, <see cref="AzureSqlTableDataset"/>, <see cref="AzureTableDataset"/>, <see cref="BinaryDataset"/>, <see cref="CassandraTableDataset"/>, <see cref="CommonDataServiceForAppsEntityDataset"/>, <see cref="ConcurObjectDataset"/>, <see cref="CosmosDBMongoDBApiCollectionDataset"/>, <see cref="CosmosDBSqlApiCollectionDataset"/>, <see cref="CouchbaseTableDataset"/>, <see cref="CustomDataset"/>, <see cref="Db2TableDataset"/>, <see cref="DelimitedTextDataset"/>, <see cref="DocumentDBCollectionDataset"/>, <see cref="DrillTableDataset"/>, <see cref="DynamicsAXResourceDataset"/>, <see cref="DynamicsCrmEntityDataset"/>, <see cref="DynamicsEntityDataset"/>, <see cref="EloquaObjectDataset"/>, <see cref="ExcelDataset"/>, <see cref="FileShareDataset"/>, <see cref="GoogleAdWordsObjectDataset"/>, <see cref="GoogleBigQueryObjectDataset"/>, <see cref="GreenplumTableDataset"/>, <see cref="HBaseObjectDataset"/>, <see cref="HiveObjectDataset"/>, <see cref="HttpFileDataset"/>, <see cref="HubspotObjectDataset"/>, <see cref="ImpalaObjectDataset"/>, <see cref="InformixTableDataset"/>, <see cref="JiraObjectDataset"/>, <see cref="JsonDataset"/>, <see cref="MagentoObjectDataset"/>, <see cref="MariaDBTableDataset"/>, <see cref="MarketoObjectDataset"/>, <see cref="MicrosoftAccessTableDataset"/>, <see cref="MongoDBAtlasCollectionDataset"/>, <see cref="MongoDBCollectionDataset"/>, <see cref="MongoDBV2CollectionDataset"/>, <see cref="MySqlTableDataset"/>, <see cref="NetezzaTableDataset"/>, <see cref="ODataResourceDataset"/>, <see cref="OdbcTableDataset"/>, <see cref="Office365Dataset"/>, <see cref="OracleServiceCloudObjectDataset"/>, <see cref="OracleTableDataset"/>, <see cref="OrcDataset"/>, <see cref="ParquetDataset"/>, <see cref="PaypalObjectDataset"/>, <see cref="PhoenixObjectDataset"/>, <see cref="PostgreSqlTableDataset"/>, <see cref="PrestoObjectDataset"/>, <see cref="QuickBooksObjectDataset"/>, <see cref="RelationalTableDataset"/>, <see cref="ResponsysObjectDataset"/>, <see cref="RestResourceDataset"/>, <see cref="SalesforceMarketingCloudObjectDataset"/>, <see cref="SalesforceObjectDataset"/>, <see cref="SalesforceServiceCloudObjectDataset"/>, <see cref="SapBwCubeDataset"/>, <see cref="SapCloudForCustomerResourceDataset"/>, <see cref="SapEccResourceDataset"/>, <see cref="SapHanaTableDataset"/>, <see cref="SapOdpResourceDataset"/>, <see cref="SapOpenHubTableDataset"/>, <see cref="SapTableResourceDataset"/>, <see cref="ServiceNowObjectDataset"/>, <see cref="SharePointOnlineListResourceDataset"/>, <see cref="ShopifyObjectDataset"/>, <see cref="SnowflakeDataset"/>, <see cref="SparkObjectDataset"/>, <see cref="SqlServerTableDataset"/>, <see cref="SquareObjectDataset"/>, <see cref="SybaseTableDataset"/>, <see cref="TeradataTableDataset"/>, <see cref="VerticaTableDataset"/>, <see cref="WebTableDataset"/>, <see cref="XeroObjectDataset"/>, <see cref="XmlDataset"/> and <see cref="ZohoObjectDataset"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public FactoryDatasetData(FactoryDatasetDefinition properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of FactoryDatasetData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// Dataset properties.
        /// Please note <see cref="FactoryDatasetDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonMwsObjectDataset"/>, <see cref="AmazonRdsForOracleTableDataset"/>, <see cref="AmazonRdsForSqlServerTableDataset"/>, <see cref="AmazonRedshiftTableDataset"/>, <see cref="AmazonS3Dataset"/>, <see cref="AvroDataset"/>, <see cref="AzureBlobDataset"/>, <see cref="AzureBlobFSDataset"/>, <see cref="AzureDataExplorerTableDataset"/>, <see cref="AzureDataLakeStoreDataset"/>, <see cref="AzureDatabricksDeltaLakeDataset"/>, <see cref="AzureMariaDBTableDataset"/>, <see cref="AzureMySqlTableDataset"/>, <see cref="AzurePostgreSqlTableDataset"/>, <see cref="AzureSearchIndexDataset"/>, <see cref="AzureSqlDWTableDataset"/>, <see cref="AzureSqlMITableDataset"/>, <see cref="AzureSqlTableDataset"/>, <see cref="AzureTableDataset"/>, <see cref="BinaryDataset"/>, <see cref="CassandraTableDataset"/>, <see cref="CommonDataServiceForAppsEntityDataset"/>, <see cref="ConcurObjectDataset"/>, <see cref="CosmosDBMongoDBApiCollectionDataset"/>, <see cref="CosmosDBSqlApiCollectionDataset"/>, <see cref="CouchbaseTableDataset"/>, <see cref="CustomDataset"/>, <see cref="Db2TableDataset"/>, <see cref="DelimitedTextDataset"/>, <see cref="DocumentDBCollectionDataset"/>, <see cref="DrillTableDataset"/>, <see cref="DynamicsAXResourceDataset"/>, <see cref="DynamicsCrmEntityDataset"/>, <see cref="DynamicsEntityDataset"/>, <see cref="EloquaObjectDataset"/>, <see cref="ExcelDataset"/>, <see cref="FileShareDataset"/>, <see cref="GoogleAdWordsObjectDataset"/>, <see cref="GoogleBigQueryObjectDataset"/>, <see cref="GreenplumTableDataset"/>, <see cref="HBaseObjectDataset"/>, <see cref="HiveObjectDataset"/>, <see cref="HttpFileDataset"/>, <see cref="HubspotObjectDataset"/>, <see cref="ImpalaObjectDataset"/>, <see cref="InformixTableDataset"/>, <see cref="JiraObjectDataset"/>, <see cref="JsonDataset"/>, <see cref="MagentoObjectDataset"/>, <see cref="MariaDBTableDataset"/>, <see cref="MarketoObjectDataset"/>, <see cref="MicrosoftAccessTableDataset"/>, <see cref="MongoDBAtlasCollectionDataset"/>, <see cref="MongoDBCollectionDataset"/>, <see cref="MongoDBV2CollectionDataset"/>, <see cref="MySqlTableDataset"/>, <see cref="NetezzaTableDataset"/>, <see cref="ODataResourceDataset"/>, <see cref="OdbcTableDataset"/>, <see cref="Office365Dataset"/>, <see cref="OracleServiceCloudObjectDataset"/>, <see cref="OracleTableDataset"/>, <see cref="OrcDataset"/>, <see cref="ParquetDataset"/>, <see cref="PaypalObjectDataset"/>, <see cref="PhoenixObjectDataset"/>, <see cref="PostgreSqlTableDataset"/>, <see cref="PrestoObjectDataset"/>, <see cref="QuickBooksObjectDataset"/>, <see cref="RelationalTableDataset"/>, <see cref="ResponsysObjectDataset"/>, <see cref="RestResourceDataset"/>, <see cref="SalesforceMarketingCloudObjectDataset"/>, <see cref="SalesforceObjectDataset"/>, <see cref="SalesforceServiceCloudObjectDataset"/>, <see cref="SapBwCubeDataset"/>, <see cref="SapCloudForCustomerResourceDataset"/>, <see cref="SapEccResourceDataset"/>, <see cref="SapHanaTableDataset"/>, <see cref="SapOdpResourceDataset"/>, <see cref="SapOpenHubTableDataset"/>, <see cref="SapTableResourceDataset"/>, <see cref="ServiceNowObjectDataset"/>, <see cref="SharePointOnlineListResourceDataset"/>, <see cref="ShopifyObjectDataset"/>, <see cref="SnowflakeDataset"/>, <see cref="SparkObjectDataset"/>, <see cref="SqlServerTableDataset"/>, <see cref="SquareObjectDataset"/>, <see cref="SybaseTableDataset"/>, <see cref="TeradataTableDataset"/>, <see cref="VerticaTableDataset"/>, <see cref="WebTableDataset"/>, <see cref="XeroObjectDataset"/>, <see cref="XmlDataset"/> and <see cref="ZohoObjectDataset"/>.
        /// </param>
        /// <param name="eTag"> Etag identifies change in the resource. </param>
        internal FactoryDatasetData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, FactoryDatasetDefinition properties, ETag? eTag) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            ETag = eTag;
        }

        /// <summary>
        /// Dataset properties.
        /// Please note <see cref="FactoryDatasetDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonMwsObjectDataset"/>, <see cref="AmazonRdsForOracleTableDataset"/>, <see cref="AmazonRdsForSqlServerTableDataset"/>, <see cref="AmazonRedshiftTableDataset"/>, <see cref="AmazonS3Dataset"/>, <see cref="AvroDataset"/>, <see cref="AzureBlobDataset"/>, <see cref="AzureBlobFSDataset"/>, <see cref="AzureDataExplorerTableDataset"/>, <see cref="AzureDataLakeStoreDataset"/>, <see cref="AzureDatabricksDeltaLakeDataset"/>, <see cref="AzureMariaDBTableDataset"/>, <see cref="AzureMySqlTableDataset"/>, <see cref="AzurePostgreSqlTableDataset"/>, <see cref="AzureSearchIndexDataset"/>, <see cref="AzureSqlDWTableDataset"/>, <see cref="AzureSqlMITableDataset"/>, <see cref="AzureSqlTableDataset"/>, <see cref="AzureTableDataset"/>, <see cref="BinaryDataset"/>, <see cref="CassandraTableDataset"/>, <see cref="CommonDataServiceForAppsEntityDataset"/>, <see cref="ConcurObjectDataset"/>, <see cref="CosmosDBMongoDBApiCollectionDataset"/>, <see cref="CosmosDBSqlApiCollectionDataset"/>, <see cref="CouchbaseTableDataset"/>, <see cref="CustomDataset"/>, <see cref="Db2TableDataset"/>, <see cref="DelimitedTextDataset"/>, <see cref="DocumentDBCollectionDataset"/>, <see cref="DrillTableDataset"/>, <see cref="DynamicsAXResourceDataset"/>, <see cref="DynamicsCrmEntityDataset"/>, <see cref="DynamicsEntityDataset"/>, <see cref="EloquaObjectDataset"/>, <see cref="ExcelDataset"/>, <see cref="FileShareDataset"/>, <see cref="GoogleAdWordsObjectDataset"/>, <see cref="GoogleBigQueryObjectDataset"/>, <see cref="GreenplumTableDataset"/>, <see cref="HBaseObjectDataset"/>, <see cref="HiveObjectDataset"/>, <see cref="HttpFileDataset"/>, <see cref="HubspotObjectDataset"/>, <see cref="ImpalaObjectDataset"/>, <see cref="InformixTableDataset"/>, <see cref="JiraObjectDataset"/>, <see cref="JsonDataset"/>, <see cref="MagentoObjectDataset"/>, <see cref="MariaDBTableDataset"/>, <see cref="MarketoObjectDataset"/>, <see cref="MicrosoftAccessTableDataset"/>, <see cref="MongoDBAtlasCollectionDataset"/>, <see cref="MongoDBCollectionDataset"/>, <see cref="MongoDBV2CollectionDataset"/>, <see cref="MySqlTableDataset"/>, <see cref="NetezzaTableDataset"/>, <see cref="ODataResourceDataset"/>, <see cref="OdbcTableDataset"/>, <see cref="Office365Dataset"/>, <see cref="OracleServiceCloudObjectDataset"/>, <see cref="OracleTableDataset"/>, <see cref="OrcDataset"/>, <see cref="ParquetDataset"/>, <see cref="PaypalObjectDataset"/>, <see cref="PhoenixObjectDataset"/>, <see cref="PostgreSqlTableDataset"/>, <see cref="PrestoObjectDataset"/>, <see cref="QuickBooksObjectDataset"/>, <see cref="RelationalTableDataset"/>, <see cref="ResponsysObjectDataset"/>, <see cref="RestResourceDataset"/>, <see cref="SalesforceMarketingCloudObjectDataset"/>, <see cref="SalesforceObjectDataset"/>, <see cref="SalesforceServiceCloudObjectDataset"/>, <see cref="SapBwCubeDataset"/>, <see cref="SapCloudForCustomerResourceDataset"/>, <see cref="SapEccResourceDataset"/>, <see cref="SapHanaTableDataset"/>, <see cref="SapOdpResourceDataset"/>, <see cref="SapOpenHubTableDataset"/>, <see cref="SapTableResourceDataset"/>, <see cref="ServiceNowObjectDataset"/>, <see cref="SharePointOnlineListResourceDataset"/>, <see cref="ShopifyObjectDataset"/>, <see cref="SnowflakeDataset"/>, <see cref="SparkObjectDataset"/>, <see cref="SqlServerTableDataset"/>, <see cref="SquareObjectDataset"/>, <see cref="SybaseTableDataset"/>, <see cref="TeradataTableDataset"/>, <see cref="VerticaTableDataset"/>, <see cref="WebTableDataset"/>, <see cref="XeroObjectDataset"/>, <see cref="XmlDataset"/> and <see cref="ZohoObjectDataset"/>.
        /// </summary>
        public FactoryDatasetDefinition Properties { get; set; }
        /// <summary> Etag identifies change in the resource. </summary>
        public ETag? ETag { get; }
    }
}
