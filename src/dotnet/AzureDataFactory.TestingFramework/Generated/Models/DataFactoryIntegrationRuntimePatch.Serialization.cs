// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class DataFactoryIntegrationRuntimePatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AutoUpdate))
            {
                writer.WritePropertyName("autoUpdate"u8);
                writer.WriteStringValue(AutoUpdate.Value.ToString());
            }
            if (Optional.IsDefined(UpdateDelayOffset))
            {
                writer.WritePropertyName("updateDelayOffset"u8);
                writer.WriteStringValue(UpdateDelayOffset.Value, "P");
            }
            writer.WriteEndObject();
        }
    }
}