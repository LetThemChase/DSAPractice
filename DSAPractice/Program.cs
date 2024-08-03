using DSAPractice;

try
{
    Tool toolInstance = new Tool();
    toolInstance.Run();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);

}
