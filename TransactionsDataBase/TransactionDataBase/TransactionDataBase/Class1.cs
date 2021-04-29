using OKHOSTING.Core;
using OKHOSTING.ORM;
using OKHOSTING.ORM.Model;
using OKHOSTING.ORM.Operations;
using OKHOSTING.Security;
using Locki;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TransactionDataBase
{
    public class Class1
    {
        public void Start()
        {
            BaitAndSwitch.PlatformSpecificConstructors.Add(typeof(DataBase), DataBase_Setup);
            BaitAndSwitch.PlatformSpecificConstructors.Add(typeof(OKHOSTING.SQL.Client), Client_Setup_Local);
            MapTypes();
            CreateDatabase();
        }

        public static DataBase DataBase_Setup()
        {
            var db = new DataBase(BaitAndSwitch.Create<OKHOSTING.SQL.Client>(), new OKHOSTING.SQL.DbProviders.MySql.SQLGenerator());
            db.BeforeOperation += Db_BeforeOperation;

            return db;
        }

        public static OKHOSTING.SQL.Client Client_Setup_Local()
        {
            AppConfig config = new AppConfig();

            return new OKHOSTING.SQL.DbProviders.MySql.Client() { ConnectionString = config.GetAppSetting("connectionString") };
        }

        private static void Db_BeforeOperation(DataBase sender, OperationEventArgs eventArgs)
        {
            if (eventArgs.Operation is Insert && eventArgs.Operation.DataType.PrimaryKey.Count() == 1 && eventArgs.Operation.DataType.PrimaryKey.Single().Expression.ReturnType.Equals(typeof(Guid)))
            {
                var pk = eventArgs.Operation.DataType.PrimaryKey.Single();
                object instance = ((Insert)eventArgs.Operation).Instance;
                Guid pkValue = (Guid)pk.Expression.GetValue(instance);

                //create new Guid before insert, if current value is empty
                if (pkValue.Equals(Guid.Empty))
                {
                    pk.SetValueFromColumn(instance, Guid.NewGuid());
                }
            }
        }

        public static void MapTypes()
        {
            var types = new List<Type>();

            types.AddRange(typeof(User).Assembly.DefinedTypes);
            types.AddRange(typeof(OKHOSTING.People.Person).Assembly.DefinedTypes);
            types.AddRange(typeof(OKHOSTING.ERP.Customers.Customer).Assembly.DefinedTypes);
            types.AddRange(typeof(DocumentSigner).Assembly.DefinedTypes);

            var dtypes = DataType.CreateDataTypes(types).ToList();

            var dtype = DataType<OKHOSTING.Security.User>.GetDataType();
            var converter = new OKHOSTING.ORM.Cryptography.EncryptStringConverter("ASDjgh67sda76576gjhsdfgjhdsw@#$$#$#");
            dtype[m => m.Password].Converter = converter;

            BaitAndSwitch.PlatformSpecificModifiers.Add(new Tuple<Type, Func<object, object>>(typeof(object), (obj) =>
            {
                if (DataType.IsDataType(obj.GetType()))
                {
                    obj.SetCachedForeignKeyFilteredCollections();
                }

                return obj;
            }));
        }

        public static void CreateDatabase()
        {
            using (var dataBase = BaitAndSwitch.Create<DataBase>())
            {
                dataBase.Create(DataType.AllDataTypes);
            }
        }
    }
}
