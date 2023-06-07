namespace C_Sharp_Examples
{
    internal class _4_VerbatimLiteral
    {
        void Main()
        {
            var path = "C:\\Documents\\User\\Images"; //Using Escape Sequence
            var path1 = @"C:\Documents\User\Images"; //Same using verbatim literal

            var query = "SELECT Name, Age" +
                          "FROM Students "; //Using String Concatenation

            var query1 = @"SELECT Name, Age 
                 FROM Students"; //Same using verbatim literal
        }
    }
}
