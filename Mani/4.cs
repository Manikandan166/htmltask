using system;
using system.collections;
using system.Linq;
using system.genric;
namespace console4
{
    class matrix
    {
        public static void main(String args[])
        {
            int r1,c1,r2,c2;
            Console.WriteLine("Input the rows and columns of first matrix:");
            r1=convert.ToInt32(Console.ReadLine());
            c1=convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the rows and columns of second matrix:");
            r2=convert.ToInt32(Console.ReadLine());
            c2=convert.ToInt32(Console.ReadLine());
           int[,] a=new a[r1][c1];
           int[,] b=new c[r2][c2];
            Console.WriteLine("Input elements in the first matrix:");
            for(int i=0;i<=r1;i++)
            {
                for(int j=0;j<=c1;j++)
                {
                Console.WriteLine("element-[{o}],[{1}], :",i,j);
                a[i][j]=convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i=0;i<=r2;i++)
            {
                for(int j=0;j<=c2;j++)
                {
                Console.WriteLine("element-[{o}],[{1}], :",i,j);
                b[i][j]=convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i=0;i<=r1;i++)
            {
                for(int j=i;j<=c1;j++)
                {
                    mul=a[i][j]*b[i+j][j-j];
                    
                }
            }

        }
    }
}
