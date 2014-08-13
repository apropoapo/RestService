using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RestServiceImpl" in code, svc and config file together.
    public class RestServiceImpl : IRestServiceImpl
    {
        public string XMLData(string id)
        {
            return "You requested " + id;
        }

        public string JSONData(string id)
        {
            string csv = "id;name;firstname;age;height;continent;country;email;freelance;lastvisit\n" +
"1;Hoffman;Tatyana;88;1.32;af;ca;Nam@quisdiamluctus.org;1;17/04/2012\n" +
"2;Atkins;Ishmael;44;1.42;am;uk;arcu.et.pede@musProin.ca;1;12/01/2011\n" +
"3;Hamilton;Mohammad;73;1.22;eu;fr;dui@duiCras.edu;0;25/09/2012\n";

            //string xml = "<table><metadata>";

            //string[] zeilen = csv.Split('\n');
            //// Metadaten einrichten
            //string[] spaltennamen = zeilen[0].Split(';');
            //foreach (string spaltenname in spaltennamen)
            //{
            //    xml += "<column name='" + spaltenname + "' label='" + spaltenname.ToUpper() + "' datatype='string' editable='true'></column>";
            //}
            //xml += "</metadata><data>";

            //for (int i = 1; i < zeilen.Length; i++)
            //{
            //    xml += "<row>";
            //    string[] spaltenwerte = zeilen[i].Split(';');
            //    for (int j = 0; j < spaltenwerte.Length; j++)
            //    {
            //        string spaltenwert = spaltenwerte[j];
            //        xml += "<column name='" + spaltennamen[j] + "'><![CDATA[" + spaltenwert + "]]></column>";
            //    }
            //    xml += "</row>";
            //}

            //xml += "</data></table>";
            //return xml;
            return csv;
        }


    }
}
