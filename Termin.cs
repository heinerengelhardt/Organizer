using System;

namespace Organizer
{
	/// <summary>
	/// Termin
	/// </summary>
	internal class Termin : Object, IComparable
	{
		private DateTime dateTime;
		private string   subject;
		private bool     upToDate;
		private string   id;

		public Termin() {}

		public string Subject {
			get {
				return subject;
			}
			set {
				subject = value;
			}
		}

		public DateTime TheDateTime {
			get {
				return dateTime;
			}
			set {
				dateTime = value;
			}
		}

		public int CompareTo(object o) {
			return TheDateTime.CompareTo( ((Termin) o).TheDateTime );
		}

		public bool UpToDate {
			get {
				return upToDate;
			}
			set {
				upToDate = value;
			}
		}

		public string ID {
			get {
				return id;
			}
			set {
				id = value;
			}
		}
	}
}
