using System.Collections.Generic;

namespace Scho.NetCore.FlashMessenger.Storage
{
	public interface IMessageStorage
	{
		IEnumerable<Message> Read();
		void Save(IEnumerable<Message> Messages);
	}
}