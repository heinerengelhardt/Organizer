using System;

namespace Organizer
{
	/// <summary>
	/// Task
	/// </summary>
	[Serializable]
	internal class Task : Object
	{
		private string  subject = "";
		private bool    done    = false;

		public Task() {}

		public string Subject {
			get {
				return subject;
			}
			set {
				subject = value;
			}
		}

		public bool Done {
			get {
				return done;
			}
			set {
				done = value;
			}
		}
	}
}
