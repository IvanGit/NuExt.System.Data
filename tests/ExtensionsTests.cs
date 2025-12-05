using System.Data;

namespace NuExt.System.Data.Tests
{
    public class ExtensionsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var table = new DataTable("Sample");
            table.Columns.Add("ID", typeof(long)).AutoIncrement = true;
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("Int32Value", typeof(int));
            table.Columns.Add("Int32NullableValue", typeof(int));
            table.Columns.Add("BoolValue", typeof(int));
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    table.Rows.Add(null, $"Name{i}", $"Description{i}", i, i, 1);
                }
                else
                {
                    table.Rows.Add(null, $"Name{i}", null, i, null, 0);
                }
            }
            Assert.That(table.Rows, Has.Count.EqualTo(10));
            var listTable = new List<(long Id, string Name, string? Description, int Int32Value, int? Int32NullableValue, bool BoolValue)>();
            foreach (DataRow row in table.Rows)
            {
                listTable.Add((
                    row.GetInt64("Id"),
                    row.GetString("Name"),
                    row.GetNullableString("Description"),
                    row.GetInt32("Int32Value"),
                    row.GetNullableInt32("Int32NullableValue"),
                    row.GetBoolean("BoolValue")
                ));
            }

            Assert.That(listTable, Has.Count.EqualTo(table.Rows.Count));
            for (int i = 0; i < table.Rows.Count; i++)
            {
                var row = table.Rows[i];
                var (id, name, description, int32Value, int32NullableValue, boolValue) = listTable[i];
                using (Assert.EnterMultipleScope())
                {
                    Assert.That(row["Id"], Is.EqualTo(id));
                    Assert.That(row["Name"], Is.EqualTo(name));
                    Assert.That(row["Description"], Is.EqualTo(description ?? (object)DBNull.Value));
                    Assert.That(row["Int32Value"], Is.EqualTo(int32Value));
                    Assert.That(row["Int32NullableValue"], Is.EqualTo(int32NullableValue ?? (object)DBNull.Value));
                    Assert.That(row["BoolValue"], Is.EqualTo(Convert.ToInt32(boolValue)));
                }
            }

            Assert.Pass();
        }
    }
}