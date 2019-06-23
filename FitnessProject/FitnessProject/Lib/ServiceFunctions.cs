using System;
using System.Collections;
using System.Xml;
using System.Reflection;
using System.IO;

namespace FitnessProject.Lib
{
	/// <summary>
	/// Summary description for ServiceFunctions.
	/// </summary>
	public class ServiceFunctions
	{
		#region IsDouble

		public static bool IsDouble(string text)
		{
			try
			{
				double a = Convert.ToDouble(text);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		#endregion

        public static string ScanPrefix()
        {
            return "000";
        }

		#region IsInteger

		public static bool IsInteger(string text)
		{
			try
			{
				int a = Convert.ToInt32(text);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		#endregion

		#region IsDateTime

		public static bool IsDateTime(string date)
		{
			try
			{
				DateTime dt = Convert.ToDateTime(date);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		#endregion

		#region ServiceFunctions

		public ServiceFunctions()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		#endregion
		

		#region List Function

		#region ListItem Class

		/// <summary>
		/// Class of the combobox items
		/// </summary>

		public class ListItem
		{
			#region Fields

			public string Name = "";
			public int ID = 0;

			#endregion

			#region Constructor

			public ListItem(){}
			public ListItem(int _ID, string _Name)
			{
				Name = _Name;
				ID = _ID;
			}

			#endregion

			#region ToString

			public override string ToString()
			{
				return Name;
			}

			#endregion
		}

		#endregion

		#region StringListItem Class

		public class StringListItem : ListItem
		{
			#region Fields
		
			public string ID1 = "";
			public string AltID = "";
			public int RealID = 0;

			#endregion

			#region Constructor

			public StringListItem() {}
			public StringListItem(string _ID, string _Name, int rID)
			{
				Name = _Name;
				ID1 = _ID;
				RealID = rID;
			}

			#endregion

			#region ToString

			public override string ToString()
			{
				return Name;
			}

			#endregion
		}

		#endregion

		#region LoadList

		/// <summary>
		/// Filling combox
		/// </summary>
		/// <param name="ddl"></param>
		/// <param name="Arr"></param>

		public static void LoadList(System.Windows.Forms.ComboBox ddl, ArrayList Arr, int id)
		{
			if(ddl.Items.Count <= 0)
			{
				int index = 0;

				foreach(ListItem Node in Arr)
				{
                    ddl.Items.Add(Node);
					
					ddl.DisplayMember = "Name";
					ddl.ValueMember = "Id";

					if (Node.ID == id)
						ddl.SelectedIndex = index;

					index++;
				}									
			}
		}

		#endregion

		#region GetNameById

		public static string GetNameByID(int ID, ArrayList List)
		{			
			foreach(ListItem li in List)
			{
				if(li.ID == ID)
				{
					return li.Name;
				}
			}

			return "";
		}

		#endregion


		#endregion

		#region GetXMLFromList
		public static string GetXMLFromList(ArrayList ObjectList)
		{
			return GetXMLFromList(ObjectList, "Records", "Record");
		}

		public static string GetXMLFromList(ArrayList ObjectList,string RootTag, string ListTag)
		{
			string Record = "<" + RootTag +">";
			foreach(Object obj in  ObjectList)
			{
				Record += GetXMLFromClass(obj,ListTag);
			}

			Record += "</" + RootTag +">";

			return Record;
		}
		#endregion

		#region GetXMLFromClass

		public static string GetXMLFromClass(object _Details)
		{
			return GetXMLFromClass(_Details, "Record");
		}
		public static string GetXMLFromClass(object _Details, string RootTag)
		{						
			Hashtable HT =  GetValueDetails(_Details);
				
			XmlDocument doc = new XmlDocument();
			XmlElement el = doc.CreateElement(RootTag);
												
			foreach(object obj in HT.Keys)
			{
				string KeyStr = Convert.ToString(obj);
				XmlElement item = doc.CreateElement(KeyStr);
				item.InnerText = Convert.ToString( HT[KeyStr] );
				el.AppendChild(item);
			}

			doc.AppendChild(el);
			
			return doc.InnerXml;
		}
		#endregion
		
		#region Reflection Function
		private static Hashtable GetValueDetails(object _Details)
		{
			System.Reflection.FieldInfo[] pi = _Details.GetType().GetFields();
			
			Hashtable HT = new Hashtable();
			
			for(int i = 0;i< pi.Length;i++)
			{
				object field = GetField(_Details, pi[i].Name);
				string FieldStr = "";	
				if(field.GetType().ToString() == "System.DateTime")
				{
					FieldStr = Convert.ToDateTime(field).ToString("yyyy-MM-dd HH:mm:ss");
				}
				else
				{
					FieldStr = Convert.ToString(field);
				}
				
				HT.Add(pi[i].Name,FieldStr);
			}
			return HT;
		}

		private static object GetField(object obj,string field)
		{
			return obj.GetType().InvokeMember(field,
				BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic |
				BindingFlags.Instance | BindingFlags.GetField, null,obj, null);	
		}

		private static void SetField(object obj, string field, string val)
		{	
			object objVal = Convert.ChangeType(val,Convert.GetTypeCode(GetField(obj, field)));						
			obj.GetType().InvokeMember(field, BindingFlags.SetField, null,obj, new object [] {objVal});	
		}

		public static string GetDoubleSep()
		{	
			try
			{
				double d = Double.Parse("1.11");
				return ".";
			}
			catch{}

			return ",";
		}

		#endregion

		
		#region GetFileContent

		/// <summary>
		/// Возвращает содержимое файла
		/// </summary>
		/// <param name="FilePath">Путь к файлу</param>
		/// <returns>Содержимое файла</returns>

		public static string GetFileContent(string FilePath)
		{
			string FileContent = "";
			if(System.IO.File.Exists(FilePath))
			{
				System.IO.FileStream fs = new System.IO.FileStream(FilePath, System.IO.FileMode.Open,System.IO.FileAccess.Read,FileShare.Read);
				StreamReader sReader = new StreamReader(fs);
				FileContent = sReader.ReadToEnd();
				sReader.Close();								
			}
			return FileContent;
		}
		#endregion

		#region SetListFromXML
		public static ArrayList SetListFromXML(object _Details, string XMLStr)
		{
			return SetListFromXML(_Details, XMLStr, "Records", "Record");
		}
		public static ArrayList SetListFromXML(object _Details, string XMLStr, string RootTag, string ListTag)
		{
			ArrayList AL = new ArrayList();
			if((XMLStr != null) && (XMLStr.Trim().Length > 0))
			{
				XmlDocument doc = new XmlDocument();
				doc.LoadXml( XMLStr );
				XmlNodeList list = doc.SelectNodes( @"//" + RootTag + @"//" + ListTag);
			
				foreach(XmlNode node in list)
				{
					Object obj = System.Activator.CreateInstance(_Details.GetType());				
					string nodeXML = "<" + ListTag +">" + node.InnerXml + @"</" + ListTag +">";
					SetClassFromXML(obj, nodeXML, ListTag);
					AL.Add(obj);				 
				}
			}
			return AL;
		}
		#endregion

		#region SetClassFromXML
		public static void SetClassFromXML(object _Details, string XMLStr)
		{
			SetClassFromXML(_Details, XMLStr, "Record");
		}

		public static void SetClassFromXML(object _Details, string XMLStr, string RootTag)
		{
			if((XMLStr != null) && (XMLStr.Trim().Length > 0))
			{
				XmlDocument doc = new XmlDocument();
				doc.LoadXml( XMLStr );			
				XmlNode root = doc.SelectSingleNode( @"//" + RootTag);

				foreach(XmlNode node in root.ChildNodes)
				{
					
					string FieldValue = node.InnerText;
					
					try
					{
						string DoubleSep = GetDoubleSep();
						if(_Details.GetType().GetField(node.Name).FieldType.ToString() == "System.Double")
						{
							FieldValue = FieldValue.Replace(".",DoubleSep);
							FieldValue = FieldValue.Replace(",",DoubleSep);
						}									
					}
					catch(Exception)
					{
						
					}
					
					SetField(_Details, node.Name, FieldValue);
				}
			}
		}
		#endregion

		#region QuantityLoad

		public static string QuantityLoad(string single, int quantity)
		{
			try
			{
				double val = Convert.ToDouble(single);
				string res = (quantity * val).ToString();

				return res;
			}
			catch (Exception)
			{
				return "-0";
			}
		}

		#endregion

		#region GenerateRepository

		public static string GenerateRepository(string path)
		{
			return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";";
		}

		#endregion
	}
}
