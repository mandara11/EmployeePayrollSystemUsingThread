using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Retrieve Goncharov's "oblomov" from Gutenberg.org.
            string[] words = CreateWordArray(@"http://www.gutenberg.org/files/54700/54700-0.txt");
            #region ParallelTasks
            //perform three tasks in parallel on the source array
            Parallel.Invoke(() =>
            {
                Console.WriteLine("Begin first task...");
                GetLongestWord(words);
            },  //close first Action
                        () =>
                        {
                            Console.WriteLine("Begin second task...");
                            GetMostCommonWords(words);
                        }, //close second Action
                        () =>
                        {
                            Console.WriteLine("Begin third task...");
                            GetCountForword(words, "sleep");
                        } //close third Action
                     };//close parallel.invoke
            Console.WriteLine("Returned from parallel.Invoke");
            #endregion
            Console.WriteLine("Press any key exit");
            Console.ReadKey();
        }
}
}
