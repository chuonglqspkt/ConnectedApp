﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectedApp
{
	public interface IMessageDialog
	{
		void SendMessage(string message, string title = null);
		void SendToast(string message);
		void SendConfirmation(string message, string title, Action<bool> confirmationAction);
	}
}
