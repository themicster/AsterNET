namespace AsterNET.Manager.Event
{
    /// <summary>
    /// A QueueMemberRemovedEvent is triggered when a queue member is removed from a queue.<br/>
    /// It is implemented in apps/app_queue.c.<br/>
    /// <para>
    /// <b>Available since : </b> <see href="http://www.voip-info.org/wiki/view/Asterisk+v1.2" target="_blank" alt="Asterisk 1.2 wiki docs">Asterisk 1.2</see>.<br/>
    /// </para>
    /// </summary>
    public class QueueMemberRemovedEvent : AbstractQueueMemberEvent
	{
		/// <summary>
		/// Returns the name of the member's interface.<br/>
		/// E.g. the channel name or agent group.
		/// </summary>
		public new string MemberName { get; set; }

        /// <summary>
        /// Creates a new QueueMemberRemovedEvent
        /// </summary>
        /// <param name="source">ManagerConnection passed through in the event.</param>
		public QueueMemberRemovedEvent(ManagerConnection source)
			: base(source)
		{
		}
	}
}