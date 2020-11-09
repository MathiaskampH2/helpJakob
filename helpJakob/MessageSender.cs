namespace HelpJakob
{
    /// <summary>
    /// Comment from Mathias
    /// This Class is responsible of making an object of MessageSender
    /// Which has methods that can send a message to 1 or more receivers
    /// </summary>
    public class MessageSender : MessageBodyConverter
    {
        // Comment from Mathias.
        // This method is redundant i would  delete this method and rename SendMessageToAll to send message
        // Because the only difference is  parameter "to"
        // But you always has a "to" parameter if you etiher has 1 or more message receivers.
        public void SendMessage(MessageCarrier type, Message m, bool isHTML)
        {
            //herinde sendes der en email ud til modtageren
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = MessageBodyConverter.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }

        public void SendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }
    }
}