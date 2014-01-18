﻿using System;
using Cqrs.Events;
using Cqrs.Repositories.Authentication;

namespace CQRSCode.ReadModel.Events
{
	public class ItemsCheckedInToInventory : IEvent<ISingleSignOnToken>
	{
		public readonly int Count;
 
		public ItemsCheckedInToInventory(Guid id, int count) 
		{
			Id = id;
			Count = count;
		}

		public Guid Id { get; set; }

		public int Version { get; set; }

		public DateTimeOffset TimeStamp { get; set; }

		#region Implementation of IMessageWithPermissionToken<ISingleSignOnToken>

		public ISingleSignOnToken PermissionToken { get; set; }

		#endregion
	}
}