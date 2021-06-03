using System;
using System.Xml;
using System.IO;
using System.Data;
using System.Collections;
using System.Windows.Forms;
using System.Reflection;

namespace Organizer
{
	/// <summary>
	/// TerminManager
	/// </summary>
	internal class TerminManager
	{
		private ArrayList listTermine        = null;
		private DataSet   dataSetTermine     = null;
		private string    xmlFileNameTermine = "";

		public TerminManager() {
			listTermine = new ArrayList();
			dataSetTermine = new DataSet();

			Assembly assembly = Assembly.GetAssembly( this.GetType() );
			string filePath = assembly.Location;
			filePath = filePath.Substring( 0, filePath.LastIndexOf( @"\" ) );
			filePath += @"\";

			xmlFileNameTermine = filePath + "Organizer.xml";
		}

		/// <summary>
		/// Lädt alle Termine aus der XML Datei
		/// </summary>
		public ArrayList LoadTermine() {
			listTermine.Clear();
			dataSetTermine.Clear();
			
			try {
				dataSetTermine.ReadXml( xmlFileNameTermine );
				DataColumn[] dc = new DataColumn[1];
                dc[0] = dataSetTermine.Tables["termin"].Columns[2];
				dataSetTermine.Tables["termin"].PrimaryKey = dc;

				Termin t = null;

				for( int i=0; i<dataSetTermine.Tables["termin"].Rows.Count; i++ ) {
					string dateTime = dataSetTermine.Tables["termin"].Rows[i].ItemArray[0].ToString();
					string subject  = dataSetTermine.Tables["termin"].Rows[i].ItemArray[1].ToString();
					string id       = dataSetTermine.Tables["termin"].Rows[i].ItemArray[2].ToString();

					t = new Termin();
					t.ID          = id;
					t.TheDateTime = DateTime.Parse( dateTime );
					t.Subject     = subject;

					DateTime today = DateTime.Now;
					if( today.CompareTo( t.TheDateTime ) <= 0 ) {
						t.UpToDate = true;
					}
					else {
						t.UpToDate = false;
					}

					listTermine.Add( t );
				}

				listTermine.Sort();
			}
			catch( Exception e ) {
				Console.Error.Write( e.ToString() );
			}

			return listTermine;
		}

		public void InsertTermin(Termin t) {
			try {
				DataRow dr = dataSetTermine.Tables["termin"].NewRow();
				dr[0] = t.TheDateTime.ToString();
				dr[1] = t.Subject;
				dr[2] = t.ID;
				dataSetTermine.Tables["termin"].Rows.Add( dr );
				dataSetTermine.AcceptChanges();
				dataSetTermine.WriteXml( xmlFileNameTermine );
			}
			catch( Exception e ) {
				Console.Error.Write( e.ToString() );

				string strXml = "<?xml version=\"1.0\" standalone=\"yes\"?><organizer xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"><termin id=\"";
				strXml += t.ID;
				strXml += "\"><datum>";
				strXml += t.TheDateTime.ToString();
				strXml += "</datum><betreff>";
				strXml += t.Subject;
				strXml += "</betreff></termin></organizer>";
				
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.LoadXml( strXml );
				xmlDoc.Save( xmlFileNameTermine );
			}
		}

		public bool DeleteTermin(Termin t) {
			try {
				DataRowCollection drc = dataSetTermine.Tables["termin"].Rows;
				DataRow dr = drc.Find( t.ID );
				dataSetTermine.Tables["termin"].Rows.Remove( dr );
				dataSetTermine.AcceptChanges();
				dataSetTermine.WriteXml( xmlFileNameTermine );
				
				return true;
			}
			catch( Exception e ) {
				Console.Error.Write( e.ToString() );
				
				return false;
			}
		}

		public bool EditTermin(Termin oldone, Termin newone) {
			if( !DeleteTermin( oldone ) ) {
				return false;
			}
			else {
				InsertTermin( newone );
				return true;
			}
		}

		public void SaveTermine( ArrayList termine ) {
			dataSetTermine.AcceptChanges();
			dataSetTermine.WriteXml( xmlFileNameTermine );		
		}
	}
}
