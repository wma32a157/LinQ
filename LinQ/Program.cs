using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ
{


    class Program
    {
        private static object highScoresQuery;

        static void Main()
        {
            #region Sample 1
            // Specify the data source.
            int[] scores = new int[] { 97, 92, 81, 60 };
            #endregion sample 1


            #region Sample 2
            // Define the query expression.
            IEnumerable<int> highscoreQuery =
                from score in scores
                where score > 80
                select score;

            highscoreQuery = scores.Where(scores => scores > 80);
            #endregion sample 2


            #region Sample 3
            // Execute the query.
            foreach (int i in highscoreQuery)
            {
                Console.Write(i + " ");


                highScoresQuery = scores.Where(x => x > 80).OrderByDescending(x => x);


            }
            #endregion Sample 3


            #region Sample 4
            static void Main(int[] scores)
            {
                IEnumerable<int> highscoreQuery =
               from score in scores
               where score > 80
               orderby score descending
               select score;

                highscoreQuery = scores.Where(x => x > 80).OrderByDescending(x => x);
            }
            #endregion Sample4

            #region Sample 5
            {
                IEnumerable<string> highScoresQuery2 =
                    from score in scores
                    where score > 80
                    orderby score descending
                    select $"The score is {score}";

                highScoresQuery2 = scores.Where(x => x > 80)
                    .OrderByDescending(x => x)
                    .Select(x => $"The score is {x}");




            }
            #endregion Sample 5


            #region Sample 6
            {
                int highScoreCount =
    (from score in scores
     where score > 80
     select score)
     .Count();

                {
                    IEnumerable<int> highScoresQuery3 =
    from score in scores
    where score > 80
    select score;

                    int scoreCount = highScoresQuery3.Count();





                }
                #endregion Sample 6





            }



            #region Sample 7
            {

                // Query #1.
                List<int> numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

                // The query variable can also be implicitly typed by using var
                IEnumerable<int> filteringQuery =
                    from num in numbers
                    where num < 3 || num > 7
                    select num;
                filteringQuery = numbers.Where(x => x < 3 || x > 7);

                // Query #2.
                IEnumerable<int> orderingQuery =
                    from num in numbers
                    where num < 3 || num > 7
                    orderby num ascending
                    select num;

                // Query #3.
                string[] groupingQuery = { "carrots", "cabbage", "broccoli", "beans", "barley" };
                IEnumerable<IGrouping<char, string>> queryFoodGroups =
                    from item in groupingQuery
                    group item by item[0];

                queryFoodGroups = groupingQuery.GroupBy(x => x[0]);

                var result = groupingQuery.GroupBy(x => x[0]);


            }
            #endregion Sample 7



            #region Sample 8
            {
                List<int> numbers1 = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                List<int> numbers2 = new List<int>() { 15, 14, 11, 13, 19, 18, 16, 17, 12, 10 };
                // Query #4.
                double average = numbers1.Average();

                

                // Query #5.
                IEnumerable<int> concatenationQuery = numbers1.Concat(numbers2);





            }
            #endregion Sample 8

            

            #region Sample 9
            {
                // Query #7.

                // Using a query expression with method syntax
                int numCount1 =
                    (from num in numbers1
                     where num < 3 || num > 7
                     select num).Count();

                // Better: Create a new variable to store
                // the method call result
                IEnumerable<int> numbersQuery =
                    from num in numbers1
                    where num < 3 || num > 7
                    select num;

                int numCount2 = numbersQuery.Count();

            }
            #endregion

        }






    }
}