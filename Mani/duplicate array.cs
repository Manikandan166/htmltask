using system;
using system.collections;
using system.Linq;
using system.genric;
namespace console2
{
    class duplicatearray
    {
        public static void main(String args[])
        {
            int n;
            n=convert.ToInt32(Console.ReadLine());
            int[] array=new array[n];
            int[] b = new b[];
           Console.WriteLine("Input {0} elements in the array:",n);
             for(int i=0;i<=n;i++)
            {
                 Console.WriteLine("element-{o} :",i);
                array[i]=convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<=array.length-1;i++)
            {
                for(int j=i;j<=array.length-1;j++)
                {
                    if(array[i]!=array[j])
                    {
                        b[i]=array[i];
                    }
                }

            }
            foreach(int i in b[])
            {
                Console.WriteLine("The Unique Elements Found in the array are:{0}",i);
            }
            Console.ReadKey();
        }
    }
}