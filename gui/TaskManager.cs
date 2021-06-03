using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;

namespace Organizer
{
	/// <summary>
	/// TaskManager
	/// </summary>
	internal sealed class TaskManager
	{
		private string fileName = "";

		internal TaskManager() {
			Assembly assembly = Assembly.GetAssembly( this.GetType() );
			string filePath = assembly.Location;
			filePath = filePath.Substring( 0, filePath.LastIndexOf( @"\" ) );
			filePath += @"\";

			fileName = filePath + "Organizer.dat";
		}

		internal void SaveTasks(ArrayList al) {
			try {
				Stream s = File.Open( fileName, FileMode.Create, FileAccess.Write );
				BinaryFormatter bf = new BinaryFormatter();

				bf.Serialize( s, al );

				s.Close();
			}
			catch( Exception e ) {
				Console.Out.Write( e.ToString() );
			}
		}

		internal ArrayList LoadTasks() {
			ArrayList al = new ArrayList();

			try {
				Stream s = File.Open( fileName, FileMode.Open, FileAccess.Read );
				BinaryFormatter bf = new BinaryFormatter();

				al = (ArrayList) bf.Deserialize( s );

				s.Close();
			}
			catch( Exception e ) {
				Console.Out.Write( e.ToString() );
			}

			return al;
		}
	}
}
