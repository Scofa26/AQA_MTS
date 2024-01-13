using LINQ;

internal class Program
{
    private static void Main(string[] args)
    {
        // Testing Task
        TestTask testTask = new TestTask();
        testTask.Solve();

        // Base Sytanx
        new BaseSyntax().RunQuerySyntax();
        new BaseSyntax().RunMethodSyntax();
        new BaseSyntax().RunStringExtension();

        // Where
        new Where().RunQuerySyntax();
        new Where().RunMethodSyntax();

        // Select
        new Select().RunQuerySyntax();
        new Select().RunMethodSyntax();
    }
}