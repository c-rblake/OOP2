namespace OOP2
{
    public class GremlinAteCpuError : UserError
    {
        public override string UEMessage()
        {
            return "Gremlin in CPU error. Do not feed after midnight.";
        }
    }
}