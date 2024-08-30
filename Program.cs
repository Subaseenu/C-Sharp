using System;

namespace Selectionsort
{
    class Program
    {
        public static void Main()
        {
            int[] arr=new int[5]{2,3,4,1,0};
            for(int i=0;i<arr.Length;i++)
            {
                int min=i;
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[min]>arr[j])
                    {
                        min=j;
                    }
                }
                
                if(arr[min]<arr[i])
                {
                    int temp=arr[min];
                    arr[min]=arr[i];
                    arr[i]=temp;
                    
                }
            }
            for(int k=0;k<arr.Length;k++)
            {
                Console.WriteLine(k);
            }

        }
    }
}
