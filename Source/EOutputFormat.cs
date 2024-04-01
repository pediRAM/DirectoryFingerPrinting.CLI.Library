/*
DirectoryFingerPrinting.CLI.Library (DFP cli lib) is a free and open source library
for parsing arguments, exporting to file-formats like csv, json and xml, provides
error codes, help text, and serializer factory used by console application from 
DirectoryFingerPrinting.CLI (dpf.exe).

Copyright (C) 2024 Pedram GANJEH HADIDI

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/


using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace DirectoryFingerPrinting.CLI.Library
{
    public enum EOutputFormat
    {
        /// <summary>
        /// Default.
        /// </summary>
        [XmlEnum]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        DFP  = 0,

        [XmlEnum]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        XML  = 1,

        [XmlEnum]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        JSON = 2,

        [XmlEnum]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        CSV  = 3,
    }
}
