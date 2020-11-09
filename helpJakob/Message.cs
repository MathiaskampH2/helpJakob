namespace HelpJakob
{
    /// <summary>
    /// Comment from Mathias
    /// This class is responsible of making an object of a message
    /// </summary>
    public class Message
    {
        // Comment from Mathias.
        // I have made the set / get variable private instead of just "string"
        // so you cannot change the variable after the Message object is instantiated
        private string to, from, body, subject, cc;

        public string To
        {
            get => to;
            set => to = value;
        }

        public string From
        {
            get => from;
            set => from = value;
        }

        public string Body
        {
            get => body;
            set => body = value;
        }

        public string Subject
        {
            get => subject;
            set => subject = value;
        }

        public string Cc
        {
            get => cc;
            set => cc = value;
        }

        // Comment from Mathias.
        // I have moved the SendMessage and SendMessageToAll methods to a new class
        // Called MessageSender.
        // Other than that, i have moved ConvertBodyToHTML method to a new class called MessageBodyConverter

        public Message(string to, string from, string body, string subject, string cc)
        {
            this.to = to;
            this.from = from;
            this.body = body;
            this.subject = subject;
            this.cc = cc;
        }
    }
}