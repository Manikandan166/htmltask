using system;
using system.collections;
using system.Linq;
using system.genric;
namespace console3
{
    class oddeven
    {
        public static void main(String args[])
        {
            int n;
            n=convert.ToInt32(Console.ReadLine());
            int[] a=new a[n];
            int[] b=new b[n];
            int[] c=new c[n];
            	    Console.WriteLine("Input {0} elements in the array:",n);
            for(int i=0;i<=n;i++)
            {
                Console.WriteLine("element-{o} :",i);
                a[i]=convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<=a.length;i++)
            {
                if(a[i]%2==0])
                {
                    b[i]==a[i];
                }
                else{
                    c[i]=a[i];
                }
            }
            foreach(int i in b[])
            {
                Console.WriteLine("The Even elements are:");
                Console.WriteLine("{0}",i);
            }
            foreach(int i in c[])
            {
                Console.WriteLine("The ODD elements are:");
                Console.WriteLine("{0}",i);
            }
            Console.ReadKey();
        }
    }
}
