using LINQ;

internal class Program
{
    private static void Main(string[] args)
    {
        // Testing Task
        /* TestTask testTask = new TestTask();
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

         // Два в одном
         new TwoInOne().run();

         //переменные 
         new Variables().RunQuerySyntax();
         new Variables().RunMethodSyntax();
         //Агрегация 
         new DataAgregation().RunQuerySyntax();
         new DataAgregation().RunMethodSyntax();

         //Сортировка OrderBy
         new OrderBy().RunQuerySyntax();
         new OrderBy().RunMethodSyntax();

         //GroupBy
         new GroupBy().RunQuerySyntax();
         new GroupBy().RunMethodSyntax();*/

        //Обьединение 
       // new Except().RunMethodSyntax();

        //Пересечение
        new Intersect().RunMethodSyntax();  

        //Удаление дубликатов 

    }
}