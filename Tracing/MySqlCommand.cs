namespace Tracing
{
    internal class MySqlCommand
    {
        private string v;

        public MySqlCommand(string v)
        {
            this.v = v;
        }

        public MySqlConnection Connection { get; internal set; }
    }
}