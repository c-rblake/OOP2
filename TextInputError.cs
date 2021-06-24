namespace OOP2
{
    public class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in an numericonly field. This fired an error!";

        }
    }
}