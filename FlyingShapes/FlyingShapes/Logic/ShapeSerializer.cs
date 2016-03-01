using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using FlyingShapes.Models;

namespace FlyingShapes.Logic
{
    public static class ShapeSerializer
    {
        private static readonly BinaryFormatter binaryFormatter = new BinaryFormatter();
        private static readonly XmlSerializer xmlFormatter = new XmlSerializer(typeof(List<Shape>));
        private static readonly DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Shape>));

        public static void SerializeToBinary(List<Shape> shapes)
        {
            using (var fileStream = new FileStream("shapes.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fileStream, shapes);
            }
        }

        public static void SerializeToXml(List<Shape> shapes)
        {
            using (var fileStream = new FileStream("shapes.xml", FileMode.OpenOrCreate))
            {
                xmlFormatter.Serialize(fileStream, shapes);
            }
        }

        public static void SerializeToJson(List<Shape> shapes)
        {
            using (var fileStream = new FileStream("shapes.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fileStream, shapes);
            }
        }

        public static List<Shape> DeserializeFromBinary()
        {
            using (var fileStream = new FileStream("shapes.dat", FileMode.OpenOrCreate))
            {
                var shapes = (List<Shape>)binaryFormatter.Deserialize(fileStream);
                return shapes;
            }
        }

        public static List<Shape> DeserializeFromXml()
        {
            using (var fileStream = new FileStream("shapes.xml", FileMode.OpenOrCreate))
            {
                var shapes = (List<Shape>)xmlFormatter.Deserialize(fileStream);
                return shapes;
            }
        }

        public static List<Shape> DeserializeFromJson()
        {
            using (var fileStream = new FileStream("shapes.json", FileMode.OpenOrCreate))
            {
                var shapes = (List<Shape>)jsonFormatter.ReadObject(fileStream);
                return shapes;
            }
        }
    }
}
